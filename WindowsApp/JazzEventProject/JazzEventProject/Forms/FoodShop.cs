using JazzEventProject.Classes;
using JazzEventProject.Forms;
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
    public partial class FoodShop : Form
    {
        public FoodShop()
        {
            InitializeComponent();
            btnPrint.Enabled = false;
        }

        //Variables declaration 
        ItemDataHelper ItemData = new ItemDataHelper();
        InvoiceDataHelper InvoiceData = new InvoiceDataHelper();
        Item_InvoiceDataHelper ItemInvoiceData = new Item_InvoiceDataHelper();
        List<Items> ListOfUpdateFood = new List<Items>();//List of items need to be updated
        List<Items> ListOFFoods = new List<Items>();// All of food from database
        List<Items> ListOfSoldFoods = new List<Items>();
        decimal subtotal = 0;
        decimal VAT = 0;
        decimal total = 0;
        int InvoiceID = 0;

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            Form frmFoodlist = new FoodList();
            frmFoodlist.Show();
        }

        private void FoodShop_Load(object sender, EventArgs e)
        {
            tbCurrentDate.Text = DateTime.Now.ToString("d/M/yyyy");
            ListOFFoods = ItemData.GetAllFoods();
        }


        /// <summary>
        /// This catches the press enter key event and add the selected item to the gridview
        /// Update the quantity of selected food 
        /// Added the selected food into the list of sold foods. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbQuantity_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int id = Convert.ToInt32(tbFoodID.Text);
                    int quantity = Convert.ToInt32(tbQuantity.Text);

                    UpdateGridView(id, quantity);
                    UpdateToTal();
                }
            }
            catch
            {
                MessageBox.Show("Please enter the id and quantity of food");
            }

        }

        /// <summary>
        /// Update the total and subtotal showing on form
        /// </summary>
        private void UpdateToTal()
        {
            VAT = subtotal * (decimal)0.21;
            lbSubTotal.Text = "€ " + subtotal.ToString();
            lbVAT.Text = "€ " + VAT.ToString("#.00");
            total = subtotal + VAT;
            lbTotal.Text = "€" + total.ToString("#.00");
        }


        //Refresh textboxes
        private void tbFoodID_Enter(object sender, EventArgs e)
        {
            tbFoodID.Text = "";
        }

        private void tbQuantity_Enter(object sender, EventArgs e)
        {
            tbQuantity.Text = "";
        }

        /// <summary>
        /// Update table F_Invoice, Food_Invoice
        /// Update food instances in list of sold items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Update the quantity of sold food into database
            int nbofSoldFood = 0;
            foreach (var f in ListOfUpdateFood)
            {
                nbofSoldFood += ItemData.UpdateAFood(f.ID, ListOfUpdateFood);
            }

            //Insert a new food invoice into database
            List<Invoice> invoices = InvoiceData.GetAllFoodInvoices();
            InvoiceID = InvoiceData.GenerateInvoiceID(invoices);
            string soldDate = (DateTime.Now).ToString("dd-MM-yyyy");
            int AccountID = 1; // This one will be provide by RFID after the scaning functionality completed
            int nbofInvoice = InvoiceData.AddAFoodInvoice(InvoiceID, soldDate, AccountID);

            //Insert rows into food_invoice (association table between food and invoice)
            int InvoiceItemRows = 0;
            foreach (var f in ListOfSoldFoods)
            {
                InvoiceItemRows += ItemInvoiceData.AddNewSoldFood(InvoiceID, f.Quantity, f.ID);
            }
            if (nbofInvoice == 1 && nbofSoldFood >= 1 & InvoiceItemRows == nbofSoldFood)
            {
                MessageBox.Show("Success!");
                btnPrint.Enabled = true;
            }


        }

        //Updated gridview for all common food in the picture lists.
        private void btSelectBurger_Click(object sender, EventArgs e)
        {
            UpdateGridView(1, 1);
            UpdateToTal();
        }
        private void btnSelectCoffee_Click(object sender, EventArgs e)
        {
            UpdateGridView(7, 1);
            UpdateToTal();
        }

        private void btnSelectedFrenchFies_Click(object sender, EventArgs e)
        {
            UpdateGridView(2, 1);
            UpdateToTal();
        }

        private void btnSelectedBeer_Click(object sender, EventArgs e)
        {
            UpdateGridView(5, 1);
            UpdateToTal();
        }

        private void btnSeletedSalad_Click(object sender, EventArgs e)
        {
            UpdateGridView(4, 1);
            UpdateToTal();
        }

        private void btnSeletedCoca_Click(object sender, EventArgs e)
        {
            UpdateGridView(6, 1);
            UpdateToTal();
        }
        /// <summary>
        /// Update datagirdview after food is selected
        /// </summary>
        private void UpdateGridView(int id, int quantity)
        {
            Items selectedItem = null;
            if (ItemData.CheckUniqueItem(ListOfUpdateFood, id) == true)
            {
                selectedItem = ItemData.GetAnItem(id, ListOFFoods);
                ItemData.SellItem(selectedItem.ID, quantity, ListOFFoods);
                ListOfUpdateFood.Add(selectedItem);
                //Add items into list of sold foods to keep track the quantity
                ListOfSoldFoods.Add(new Items(selectedItem.ID, selectedItem.Name, selectedItem.Price, quantity));
            }
            else
            {
                selectedItem = ItemData.GetAnItem(id, ListOfUpdateFood);
                ItemData.SellItem(selectedItem.ID, quantity, ListOfUpdateFood);
                //Update the quantity for the list of sold food
                Items soldItem = ItemData.GetAnItem(id, ListOfSoldFoods);
                soldItem.Quantity += quantity;
            }
            subtotal += selectedItem.Price * quantity;
            //Add row into the datagridview
            DataGridViewRow newrow = new DataGridViewRow();
            newrow.CreateCells(dataGridViewFood);
            newrow.Cells[0].Value = selectedItem.ID;
            newrow.Cells[1].Value = selectedItem.Name;
            newrow.Cells[2].Value = quantity;
            newrow.Cells[3].Value = selectedItem.Price;
            newrow.Cells[4].Value = selectedItem.Price * quantity;
            dataGridViewFood.Rows.Add(newrow);
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
            int shift_y = 40;
            graphics.DrawString("Food receipt  " + InvoiceID.ToString(), new Font("Arial", 14),
                                new SolidBrush(Color.Black), startX, startY);
            shift_y = shift_y + 20;

            graphics.DrawString("Food name", font, color, startX, startY + shift_y);
            graphics.DrawString("Quantity", font, color, startX + 2*shift_x, startY + shift_y);
            graphics.DrawString("Price", font, color, startX + 3*shift_x, startY + shift_y);
            graphics.DrawString("Total", font, color, startX + 4*shift_x, startY + shift_y);

            shift_y = shift_y + 20;
            foreach (var f in ListOfSoldFoods)
            {
                graphics.DrawString(f.Name, font, color, startX, startY + shift_y);
                graphics.DrawString(f.Quantity.ToString(), font, color, startX + 2*shift_x, startY + shift_y);
                graphics.DrawString(f.Price.ToString("#.00"), font, color, startX + 3*shift_x, startY + shift_y);
                graphics.DrawString((f.Price * f.Quantity).ToString("#.00"), font, color, startX + 4*shift_x, startY + shift_y);
                shift_y = shift_y + 20;
            }
            shift_y = shift_y + 20;
            graphics.DrawString("Sub-total: ", font, color, startX + 3 * shift_x, startY + shift_y);
            graphics.DrawString(subtotal.ToString("#.00"), font, color, startX + 4 * shift_x, startY + shift_y);
            shift_y = shift_y + 20;
            graphics.DrawString("VAT: ", font, color, startX + 3 * shift_x, startY + shift_y);
            graphics.DrawString(VAT.ToString("#.00"), font, color, startX + 4 * shift_x, startY + shift_y);
            shift_y = shift_y + 20;
            graphics.DrawString("Total: ", font, color, startX + 3 * shift_x, startY + shift_y);
            graphics.DrawString(total.ToString("#.00"), font, color, startX + 4 * shift_x, startY + shift_y);


        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
