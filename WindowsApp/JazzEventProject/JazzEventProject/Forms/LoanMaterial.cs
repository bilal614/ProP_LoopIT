using JazzEventProject.Classes;
using Phidgets.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace JazzEventProject
{
    public partial class LoanMaterial : Form
    {
        //Variables declaration 
        ItemDataHelper ItemData = new ItemDataHelper();
        InvoiceDataHelper InvoiceData = new InvoiceDataHelper();
        Item_InvoiceDataHelper ItemInvoiceData = new Item_InvoiceDataHelper();
        EventAccountDataHelper AccountdData = new EventAccountDataHelper();
        List<Items> ListOfUpdateMaterials = new List<Items>();//List of items need to be updated
        List<Items> ListOfMaterials = new List<Items>();// All of material from database
        List<Items> ListOfLoanedMaterials = new List<Items>();
        List<Material_Invoice_Items> ListOfMaterialsInInvoice = new List<Material_Invoice_Items>(); // List of materials in current loaning invoices
        decimal subtotal = 0;
        decimal VAT = 0;
        decimal total = 0;
        DateTime currentDate = DateTime.Now;
        //Variables are used for printing stuff.
        int InvoiceID = 0;

        //RFID & payment
        PhidgetHandler phidgetScanner = new PhidgetHandler();
        string customerRFID = null;
        EventAccount currentAccount = null;

        public LoanMaterial()
        {
            InitializeComponent();
        }
        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            //Form frm = new MaterialList();
            //frm.Show();
        }

        private void LoanMaterial_Load(object sender, EventArgs e)
        {
            tbCurrentDate.Text = DateTime.Now.ToString("d/M/yyyy");
            ListOfMaterials = ItemData.GetAllMaterials();
            foreach (var i in ListOfMaterials)
            {
                Material m = (Material)i;
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(dataGridViewMaterialList);
                newrow.Cells[0].Value = m.ID;
                newrow.Cells[1].Value = m.Name;
                newrow.Cells[2].Value = m.Price;
                newrow.Cells[3].Value = m.DepositAmount;
                newrow.Cells[4].Value = m.Quantity;
                newrow.Cells[5].Value = m.Description;
                dataGridViewMaterialList.Rows.Add(newrow);
            }
            btnPrint.Enabled = false;

            //Activate and open RFID
            try
            {
                phidgetScanner.OpenRFIDReader();
                phidgetScanner.myRFIDReader.Tag += new TagEventHandler(ChangeTagOnForm);
            }
            catch { MessageBox.Show("No RFID reader detected."); }
        }

        /// <summary>
        /// This catches the press enter key event and add the selected item to the gridview
        /// Update the quantity of selected material 
        /// Added the selected material into the list of sold materials. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbQuantity_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int id = Convert.ToInt32(tbMaterialID.Text);
                    int quantity = Convert.ToInt32(tbQuantity.Text);
                    DateTime returnDate = Convert.ToDateTime(dateTimePickerReturnDate.Value);// Need to check the return date > current date
                    if(DateTime.Compare(currentDate,returnDate) < 0)
                    {
                        UpdateGridView(id, quantity, returnDate);
                        UpdateToTal();
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct value of the return date");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter the id and quantity of the materials");
            }

        }

        /// <summary>
        /// Update datagirdview after a material is selected
        /// </summary>
        private void UpdateGridView(int id, int quantity, DateTime returnDate)
        {
            Items selectedItem = null;
            if (ItemData.CheckUniqueItem(ListOfMaterialsInInvoice, id, returnDate) == true)
            {
                selectedItem = ItemData.GetAnItem(id, ListOfMaterials);
                ItemData.SellItem(selectedItem.ID, quantity, ListOfMaterials);
                ListOfUpdateMaterials.Add(selectedItem);
                //Add items into list of loaned material to keep track the quantity
                ListOfLoanedMaterials.Add(new Items(selectedItem.ID, selectedItem.Name, selectedItem.Price, quantity));
                //Add items into Material_Invoice_Item
                ListOfMaterialsInInvoice.Add(new Material_Invoice_Items(quantity, selectedItem.ID, InvoiceID, returnDate, false));

            }
            else
            {
                selectedItem = ItemData.GetAnItem(id, ListOfUpdateMaterials);
                ItemData.SellItem(selectedItem.ID, quantity, ListOfUpdateMaterials);
                //Update the quantity for the list of sold food
                Items soldItem = ItemData.GetAnItem(id, ListOfLoanedMaterials);
                soldItem.Quantity += quantity;
                foreach (var f in ListOfMaterialsInInvoice)
                {
                    f.Quantity += quantity;
                }
            }
            int nbofDates = (returnDate - currentDate).Days;
            subtotal += selectedItem.Price * quantity;
            //Add row into the datagridview
            DataGridViewRow newrow = new DataGridViewRow();
            newrow.CreateCells(dataGridViewMaterial);
            newrow.Cells[0].Value = selectedItem.ID;
            newrow.Cells[1].Value = selectedItem.Name;
            newrow.Cells[2].Value = returnDate.ToString("dd-MM-yyyy");
            newrow.Cells[3].Value = quantity;
            newrow.Cells[4].Value = selectedItem.Price.ToString("0.00");
            newrow.Cells[5].Value = (selectedItem.Price * quantity * nbofDates).ToString("0.00");
            dataGridViewMaterial.Rows.Add(newrow);
        }

        /// <summary>
        /// Update the total and subtotal showing on form
        /// </summary>
        private void UpdateToTal()
        {
            VAT = subtotal * (decimal)0.21;
            lbSubTotal.Text = "€ " + subtotal.ToString("0.00");
            lbVAT.Text = "€ " + VAT.ToString("0.00");
            total = subtotal + VAT;
            lbTotal.Text = "€" + total.ToString("0.00");
        }

        private void tbMaterialID_Enter(object sender, EventArgs e)
        {
            tbMaterialID.Text = "";
        }

        private void tbQuantity_Enter(object sender, EventArgs e)
        {
            tbQuantity.Text = "";
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                phidgetScanner.CloseRFIDReader();
            }
            catch
            {
                MessageBox.Show("No open RFID scanners detected.");
            }
        }

        private void btSelectCamera_Click(object sender, EventArgs e)
        {
            UpdateGridView(4, 1, currentDate);
            UpdateToTal();
        }

        private void btnSelectedUSB_Click(object sender, EventArgs e)
        {
            UpdateGridView(3, 1, currentDate);
            UpdateToTal();
        }

        private void btnSelectUSBCable_Click(object sender, EventArgs e)
        {
            UpdateGridView(1, 1, currentDate);
            UpdateToTal();
        }

        private void btnSelectChanger_Click(object sender, EventArgs e)
        {
            UpdateGridView(2, 1, currentDate);
            UpdateToTal();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (currentAccount.Balance >= total)
            {
                //Update the new balance
                decimal balanceupdate = 0 - total;
                AccountdData.UpdateAccountBalance(currentAccount.AccountId, balanceupdate);

                lblBalance.Text = currentAccount.Balance.ToString("0.00");

                //Update the quantity of loaned material into database
                int nbofLoanedMaterial = 0;
                foreach (var f in ListOfUpdateMaterials)
                {
                    nbofLoanedMaterial += ItemData.UpdateAMaterial(f.ID, ListOfUpdateMaterials);
                }

                //Insert a new material invoice into database
                List<Invoice> invoices = InvoiceData.GetAllMaterialInvoices();
                InvoiceID = InvoiceData.GenerateInvoiceID(invoices);
                string startingDate = (DateTime.Now).ToString("dd-MM-yyyy");
                int AccountID = currentAccount.AccountId; // This one will be provide by RFID after the scaning functionality completed
                int nbofInvoice = InvoiceData.AddAMaterialInvoice(InvoiceID, startingDate, AccountID, false);

                //Insert rows into material_invoice (association table between material and invoice)
                int InvoiceItemRows = 0;
                foreach (var f in ListOfMaterialsInInvoice)
                {
                    InvoiceItemRows += ItemInvoiceData.AddNewLoanedMaterial(InvoiceID, f.Quantity, f.Item_Id, f.ReturnDate, false);
                }
                if (nbofInvoice == 1 && nbofLoanedMaterial >= 1)
                {
                    MessageBox.Show("Success!");
                    btnPrint.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            pdoc.DefaultPageSettings.PaperSize.Height = 720;

            pdoc.DefaultPageSettings.PaperSize.Width = 620;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }

        }
        private void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);
            SolidBrush color = new SolidBrush(Color.Black);

            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 55;
            int shift_x = 80;
            int shift_y = 20;
            graphics.DrawString("Loaning material receipt:  " + InvoiceID.ToString(), new Font("Arial", 14),
                                new SolidBrush(Color.Black), startX, startY);
            startY += 30;
            graphics.DrawString("Loaning date:  " + currentDate.ToString("dd-MM-yyy"), new Font("Arial", 12),
                                new SolidBrush(Color.Black), startX, startY);
            startY += 10;

            graphics.DrawString("Material name", font, color, startX, startY + shift_y);
            graphics.DrawString("Quantity", font, color, startX + 2 * shift_x, startY + shift_y);
            graphics.DrawString("Price/day", font, color, startX + 3 * shift_x, startY + shift_y);
            graphics.DrawString("Return date", font, color, startX + 4 * shift_x, startY + shift_y);
            graphics.DrawString("Total", font, color, startX + 5 * shift_x, startY + shift_y);

            shift_y = shift_y + 20;
            foreach (var f in ListOfLoanedMaterials)
            {
                graphics.DrawString(f.Name, font, color, startX, startY + shift_y);
                graphics.DrawString(f.Quantity.ToString(), font, color, startX + 2 * shift_x, startY + shift_y);
                graphics.DrawString(f.Price.ToString("0.00"), font, color, startX + 3 * shift_x, startY + shift_y);
                DateTime returnDate = GetReturnDate(ItemData.GetAnItem(f.ID, ListOfLoanedMaterials).ID, ListOfMaterialsInInvoice);
                graphics.DrawString(returnDate.ToString("dd-MM-yyy"), font, color, startX + 4 * shift_x, startY + shift_y);
                graphics.DrawString((f.Price * f.Quantity).ToString("0.00"), font, color, startX + 5 * shift_x, startY + shift_y);
                shift_y = shift_y + 20;
            }
            shift_y = shift_y + 20;
            graphics.DrawString("Sub-total: ", font, color, startX + 4 * shift_x, startY + shift_y);
            graphics.DrawString(subtotal.ToString("0.00"), font, color, startX + 5 * shift_x, startY + shift_y);
            shift_y = shift_y + 20;
            graphics.DrawString("VAT: ", font, color, startX + 4 * shift_x, startY + shift_y);
            graphics.DrawString(VAT.ToString("0.00"), font, color, startX + 5 * shift_x, startY + shift_y);
            shift_y = shift_y + 20;
            graphics.DrawString("Total: ", font, color, startX + 4 * shift_x, startY + shift_y);
            graphics.DrawString(total.ToString("0.00"), font, color, startX + 5 * shift_x, startY + shift_y);


        }

        //Get return date from list of borrowed items
        private DateTime GetReturnDate(int m_id, List<Material_Invoice_Items>Items)
        {
            DateTime returnDate = currentDate;
            foreach (var f in Items)
            {
                if(f.Item_Id == m_id)
                {
                    returnDate = f.ReturnDate;
                }
            }
            return returnDate;
        }

        private void ChangeTagOnForm(object sender, TagEventArgs e)
        {
            customerRFID = phidgetScanner.RFIDtagNr;
            currentAccount = AccountdData.GetEventAccountFromRFID(customerRFID);
            if (currentAccount != null)
            {
                lblName.Text = currentAccount.FirstName;
                lblBalance.Text = currentAccount.Balance.ToString("0.00");
            }
            else { MessageBox.Show("The scanned RFID code does not exist in database."); }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Reset the working section for new user
            dataGridViewMaterial.Rows.Clear();
            dataGridViewMaterial.Refresh();
            ListOfLoanedMaterials.Clear();
            ListOfUpdateMaterials.Clear();
            ListOfMaterialsInInvoice.Clear();
        }

        private void LoanMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                phidgetScanner.CloseRFIDReader();
            }
            catch
            {
                MessageBox.Show("No open RFID scanners detected.");
            }
        }
    }
}
