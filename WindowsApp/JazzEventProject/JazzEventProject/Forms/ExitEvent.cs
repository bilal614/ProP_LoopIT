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
    public partial class ExitEvent : Form
    {
        int accountId;
        EventAccount currentAccount;
        EventAccountDataHelper accountHelper = new EventAccountDataHelper();

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
                    label7.Text = Convert.ToString(currentAccount.Phone);

                    if (currentAccount.RFID <= 0)
                    { label9.Text = "Returned"; }
                    else { label9.Text = "Not Returned"; }
                    //must add the total spending of the client at the festival

                    label12.Text = Convert.ToString(currentAccount.Balance);
                }
            }
            catch { MessageBox.Show("Please enter an id in the textbox."); }
        }


    }
}
