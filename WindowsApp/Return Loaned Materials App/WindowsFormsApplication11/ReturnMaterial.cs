using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;
using Phidgets.Events;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        private List<Items> materials;
        private ItemDataHelper dataHelper;
        private EventAccount person;
        private EventAccountDataHelper eaDataHelper;
        private List<Material_Invoice_Items> loanedMaterials;
        private int selectedItem;
        private InvoiceDataHelper invoiceDataHelper;


        PhidgetHandler phidgetScanner;
        string customerRFID;

        public Form1()
        {
            InitializeComponent();
            //turetu is duomenu bazes sukrauti itemus ir issaugoti sarase +
            dataHelper = new ItemDataHelper();
            materials = dataHelper.GetAllMaterials();
            eaDataHelper = new EventAccountDataHelper();
            phidgetScanner = new PhidgetHandler();
            customerRFID = null;
            invoiceDataHelper = new InvoiceDataHelper();
            //Activate and Open RFID +
            try
            {
                phidgetScanner.OpenRFIDReader();
                phidgetScanner.myRFIDReader.Tag += new TagEventHandler(ChangeTagOnForm);
            }
            catch { MessageBox.Show("No RFID reader detected."); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Updates users loaned materials list +
            loanedMaterials[selectedItem].ReturnStatus = true;
            loanedMaterials[selectedItem].ReturnDate = DateTime.Now;
            
            //prideda ta daikta y evento duomenu baze. Add item to event database
            int selectedItemID = loanedMaterials[selectedItem].Item_Id;
            materials.Find(x => x.ID == selectedItemID).Quantity++;
            dataHelper.UpdateAMaterial(selectedItemID, materials);
            //Update Invoice

            invoiceDataHelper.UpdateMaterialInvoiceItems(loanedMaterials);

            //Refund deposit +
            eaDataHelper.UpdateAccountBalance(person.AccountId, ((Material)materials.Find(x => x.ID == selectedItemID)).DepositAmount);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = this.listBox1.SelectedIndex;

        }

        //kazkas turi but kas nuskanuoja RFID. Smth that scans RFID +
        private void ChangeTagOnForm(object sender, TagEventArgs e)
        {
            customerRFID = phidgetScanner.RFIDtagNr;
            person = eaDataHelper.GetEventAccountFromRFID(customerRFID);
            if (person != null)
            {
                lbName.Text = person.FirstName;
                //Get loaned materials list
                loanedMaterials = invoiceDataHelper.GetPersonalMaterialInvoices(person.AccountId);

                //Put items list into listbox +
                for(int i = 0; i < loanedMaterials.Count; i++)
                {
                    listBox1.Items.Add(loanedMaterials[i]);
                }
            }
            else
            {
                lbName.Text = "The scanned RFID code does not exist in database.";
            }

        }
    }
}


