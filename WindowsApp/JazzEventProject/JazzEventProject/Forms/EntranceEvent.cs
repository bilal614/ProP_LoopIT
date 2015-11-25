using JazzEventProject.Classes;
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
    public partial class EntranceEvent : Form
    {
        int accountId;
        EventAccount currentAccount;
        EventAccountDataHelper accountHelper=new EventAccountDataHelper();

        public EntranceEvent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountId = Convert.ToInt32(textBox1.Text);
            currentAccount = accountHelper.GetAccount(accountId);

            if (currentAccount!= null)
            {

                label5.Text=currentAccount.FirstName+" "+currentAccount.LastName;
                label6.Text=currentAccount.Email;
                label7.Text = currentAccount.Phone;
                label14.Text = Convert.ToString(accountId);

                if (currentAccount.PaymentStatus) { label10.Text = "Paid"; }
                else { label10.Text = "Not Paid"; }
                label8.Text = "€ "+Convert.ToString(currentAccount.Balance);
            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                bool ticketPaid = false;
                decimal amount = Convert.ToDecimal(textBox2.Text);

                if (label14.Text != "")
                {
                    int accountId = Convert.ToInt32(label14.Text);
                    EventAccount currentAccount=accountHelper.GetAccount(accountId);
                    ticketPaid=accountHelper.UpdateAccountBalanceEntrance(accountId, amount);
                    label8.Text ="€ "+ Convert.ToString(accountHelper.GetAccountBalance(accountId));
                    if(currentAccount!=null)
                    {
                        if (ticketPaid)
                            label10.Text = "Paid";
                    }
                }
            }
            catch
            { MessageBox.Show("Please enter appropriate amount."); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label14.Text = "";
            label10.Text = "";
            label8.Text = "€ ";
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

/// <summary>
/// This is where the phidget imlpementation is made below.
/// </summary>
        PhidgetHandler phidgetScanner = new PhidgetHandler();

        private void btnScan_Click(object sender, EventArgs e)
        {
            phidgetScanner.OpenRFIDReader();
            label18.Text="";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { phidgetScanner.CloseRFIDReader(); }
            catch { MessageBox.Show("No open RFID scanners detected."); }
           
        }

        private void btnActivateRFID_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {
                button3.Enabled = true;
                if (phidgetScanner.RFIDno != "")
                {
                    accountHelper.CheckIn(currentAccount.AccountId, phidgetScanner.RFIDno);//this method updates the rfid
                    //of the visitor in the database
                    currentAccount.ActivateRFID(phidgetScanner.RFIDno);//this method gives the currentAccount the scanned
                    //RFID number
                    label16.Text = currentAccount.RFID;
                }
            }
            else { MessageBox.Show("Please enter an Event Account Id first and/or scan an RFID."); }
        }



    }
}
