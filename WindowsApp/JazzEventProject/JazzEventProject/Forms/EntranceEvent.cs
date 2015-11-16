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

            if (accountHelper.GetAccount(accountId) != null)
            {
                currentAccount = accountHelper.GetAccount(accountId);

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
                decimal amount = Convert.ToDecimal(textBox2.Text);

                if (label14.Text != "")
                {
                    int accountId = Convert.ToInt32(label14.Text);
                    accountHelper.UpdateAccountBalance(accountId, amount);
                    label8.Text ="€ "+ Convert.ToString(accountHelper.GetAccountBalance(accountId));
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

    }
}
