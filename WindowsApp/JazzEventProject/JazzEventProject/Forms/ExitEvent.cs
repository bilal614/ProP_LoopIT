using JazzEventProject.Classes;
using Phidgets.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazzEventProject
{
    public partial class ExitEvent : Form
    {
        int accountId;
        EventAccount currentAccount;
        EventAccountDataHelper accountHelper = new EventAccountDataHelper();
        PhidgetHandler phidgetScanner = new PhidgetHandler();

        public ExitEvent()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                accountId=Convert.ToInt32(textBox1.Text);
                currentAccount=accountHelper.GetAccount(accountId);

                if (currentAccount != null)
                {
                    label5.Text = Convert.ToString(currentAccount.FirstName) + " " + Convert.ToString(currentAccount.LastName);
                    label6.Text = Convert.ToString(currentAccount.Email); 
                    label22.Text = Convert.ToString(currentAccount.AccountId)+", "+currentAccount.RFID;
                    label7.Text = Convert.ToString(currentAccount.Phone);

                    if (currentAccount.RFID == "")
                    { label9.Text = "Returned"; }
                    else { label9.Text = "Not Returned"; }
                    //must add the total spending of the client at the festival

                    label12.Text = Convert.ToString(currentAccount.Balance);
                }
            }
            catch { MessageBox.Show("Please enter an id in the textbox."); }
        }

        private void ExitEvent_Load(object sender, EventArgs e)
        {
            try
            {
                phidgetScanner.OpenRFIDReader();
                phidgetScanner.myRFIDReader.Tag += new TagEventHandler(ChangeTagOnForm);
            }
            catch { MessageBox.Show("No RFID reader detected."); }
        }

        private void ChangeTagOnForm(object sender, TagEventArgs e)
        {
            label20.Text = phidgetScanner.RFIDtagNr;
            if(phidgetScanner.RFIDtagNr!=null)
            {
                String rfidNr=phidgetScanner.RFIDtagNr;
                currentAccount=accountHelper.GetEventAccountFromRFID(rfidNr);
                label5.Text = ""; label6.Text = ""; label7.Text = ""; label12.Text = ""; label13.Text = ""; label22.Text = "";
                if (currentAccount != null)
                {
                    label5.Text = currentAccount.FirstName + " " + currentAccount.LastName;
                    label6.Text = currentAccount.Email;
                    label7.Text = currentAccount.Phone;
                    label12.Text = Convert.ToString(currentAccount.Balance);
                    label13.Text = "";
                    label22.Text = Convert.ToString(currentAccount.AccountId);
                    if (currentAccount.RFID == "")
                    { label9.Text = "Returned"; }
                    else {  label9.Text="Not Returned, "+currentAccount.RFID;}        
                }
                else { MessageBox.Show("The scanned RFID code does not exist in database."); }
            }
        }

        private void ExitEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { phidgetScanner.CloseRFIDReader(); }
            catch { MessageBox.Show("No open RFID scanners detected."); }
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActivateRFID_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {
                if (phidgetScanner.RFIDtagNr != null)
                {
                    accountHelper.CheckIn(currentAccount.AccountId, "");//this method updates the rfid
                    //of the visitor in the database back to a null string
                    currentAccount.ActivateRFID(phidgetScanner.RFIDtagNr);//this method gives the currentAccount a null
                    //string value for its RFID number in order to show that the person's RFID has been deactivated
                    label16.Text = currentAccount.RFID;
                    MessageBox.Show(String.Format("RFID: {0} has been deactivated for event account id: {1}"
                        , phidgetScanner.RFIDtagNr, currentAccount.AccountId));
                    label22.Text = "";
                }
                else { MessageBox.Show("Please scan an RFID."); }
            }
            else { MessageBox.Show("Please enter an Event Account Id."); }
        }


    }
}
