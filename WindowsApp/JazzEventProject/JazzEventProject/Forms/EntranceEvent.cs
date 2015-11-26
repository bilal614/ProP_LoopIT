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
using Phidgets.Events;
using Phidgets;
namespace JazzEventProject
{
    public partial class EntranceEvent : Form
    {
        int accountId;
        EventAccount currentAccount;
        EventAccountDataHelper accountHelper=new EventAccountDataHelper();
        private RFID RFIDReader;
        private string rfidCode;

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
            RFIDReader.close();
            RFIDReader.Antenna = false;
            RFIDReader.LED = false;
        }
        //
        private void btnActivateRFID_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    RFIDReader.open();
            //    RFIDReader.waitForAttachment(3000);
            //    lbScanStatus.Text = "an RFID-reader is found and opened.";
            //    RFIDReader.Antenna = true;
            //    RFIDReader.LED = true;
            //}
            //catch (PhidgetException) { 
            //    lbScanStatus.Text ="no RFID-reader opened."; 
            //}
            //currentAccount.RFID = rfidCode;
            //bool result = accountHelper.CheckIn(currentAccount.AccountId, rfidCode);
            //if (result)
            //{
            //    MessageBox.Show("Check in successfully");
            //}
            MessageBox.Show("rfidCode is " + rfidCode);
            
        }

        private void EntranceEvent_Load(object sender, EventArgs e)
        {
            //RFID functionalites
            RFIDReader = new RFID();
            RFIDReader.Attach += new AttachEventHandler(ShowWhoIsAttached);
            RFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
            RFIDReader.Tag += new TagEventHandler(ProcessThisTag);
            try
            {
                RFIDReader.open();
                RFIDReader.waitForAttachment(3000);
                lbScanStatus.Text = "an RFID-reader is found and opened.";
                RFIDReader.Antenna = true;
                RFIDReader.LED = true;
            }
            catch (PhidgetException)
            {
                lbScanStatus.Text = "no RFID-reader opened.";
            }
        }

        private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            lbScanStatus.Text = ("RFIDReader attached!, serial nr: " + e.Device.SerialNumber.ToString());
        }

        private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        {
            lbScanStatus.Text = ("RFIDReader detached!, serial nr: " + e.Device.SerialNumber.ToString());
        }

        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            lbScanStatus.Text = ("rfid number is: " + e.Tag);
            MessageBox.Show("rfid number is: " + e.Tag);
            rfidCode = e.Tag;
        }
    }
}
