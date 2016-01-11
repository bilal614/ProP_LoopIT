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
            dataGridViewFoodReport.DataSource = eventstat.GetAllFoodInfors();

            dataGridViewUserReprot.DataSource = eventstat.GetAllUsersInfos();
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

            textBox2.Text = eventstat.NrOfReg().ToString(); textBox2.BackColor = Color.GreenYellow;// visitors expected
            textBox7.Text = eventstat.NrOfVisPresent().ToString(); textBox7.BackColor = Color.GreenYellow;// visitors presents
            textBox6.Text = (eventstat.NrOfReg() - eventstat.NrOfVisPresent()).ToString(); textBox6.BackColor = Color.GreenYellow;// visitors left
            textBox3.Text = eventstat.EvAccountBalance().ToString() + " €"; textBox3.BackColor = Color.GreenYellow;// event account balance
            textBox5.Text = Convert.ToString(150 - eventstat.NrOfCampRented()); textBox5.BackColor = Color.GreenYellow;// Number of free camping spots

            //textBox12.Text = eventstat.BBurgerSold().ToString(); textBox12.BackColor = Color.GreenYellow;// big burger sold
            //textBox11.Text = eventstat.CColaSold().ToString(); textBox11.BackColor = Color.GreenYellow;// coca cola sold
            //textBox9.Text = eventstat.ChickBurgerSold().ToString(); textBox9.BackColor = Color.GreenYellow;// chicken burger sold
            //textBox13.Text = eventstat.FFriesSold().ToString(); textBox13.BackColor = Color.GreenYellow;// french fries sold
            //textBox14.Text = eventstat.HBeerSold().ToString(); textBox14.BackColor = Color.GreenYellow;// Heinneken beer sold
            //textBox15.Text = eventstat.SaladSold().ToString(); textBox15.BackColor = Color.GreenYellow;// Salad sold

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //accountId = Convert.ToInt32(textBox1.Text);
            //currentAccount = accountHelper.GetAccount(accountId);

            //if (currentAccount!= null)
            //{
            //    textBox8.Text = Convert.ToString(500 - currentAccount.Balance) + " €"; textBox8.BackColor = Color.GreenYellow;// Money spent
            //    textBox4.Text = Convert.ToString(currentAccount.Balance) + " €"; textBox4.BackColor = Color.GreenYellow;// Current account balance
            //    textBox10.Text = "Yes"; textBox10.BackColor = Color.GreenYellow;// Camp reserved
            //}

        }

     }
}
