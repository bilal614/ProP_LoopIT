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
    public partial class EventStatusReport : Form
    {
        public EventStatusReport()
        {
            InitializeComponent();
        }
        int accountId;
        EventAccount currentAccount;
        EventReportDataHelper eventstat = new EventReportDataHelper();
        EventAccountDataHelper accountHelper = new EventAccountDataHelper();
        private void EventStatusReport_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             DataGridViewRow newrow = new DataGridViewRow();
            newrow.CreateCells(dataGridView1);
            newrow.Cells[0].Value = eventstat.NrOfReg() +" Users";
            newrow.Cells[1].Value = eventstat.TickWithDiscount() * 45 + eventstat.TickWithoutDiscount() * 50 + " €";
            newrow.Cells[2].Value = eventstat.NrOfCampRented() + " rented camps";
            newrow.Cells[3].Value = eventstat.CampRev() + " €";
            newrow.Cells[4].Value = eventstat.FoodRev() + " €";
            newrow.Cells[5].Value = eventstat.LoanMatRev() + " €";
            newrow.Cells[6].Value = eventstat.TickWithDiscount() * 45 + eventstat.TickWithoutDiscount() * 50 + eventstat.CampRev() + eventstat.FoodRev() + eventstat.LoanMatRev() + " €";
            dataGridView1.Rows.Add(newrow);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountId = Convert.ToInt32(textBox1.Text);
            currentAccount = accountHelper.GetAccount(accountId);

            if (currentAccount!= null)
            {

                textBox8.Text = Convert.ToString(currentAccount.Balance) + " €";
                

               
            }

        }

     }
}
