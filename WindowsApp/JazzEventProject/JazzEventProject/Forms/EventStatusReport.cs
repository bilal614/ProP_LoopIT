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

        EventReportDataHelper eventstat = new EventReportDataHelper();
        private void EventStatusReport_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             DataGridViewRow newrow = new DataGridViewRow();
            newrow.CreateCells(dataGridView1);
            newrow.Cells[0].Value = eventstat.NrOfReg();
            newrow.Cells[1].Value = eventstat.TickWithDiscount() * 45 + eventstat.TickWithoutDiscount() * 50;
            newrow.Cells[2].Value = eventstat.NrOfCampRented();
            newrow.Cells[3].Value = eventstat.CampRev();
            newrow.Cells[4].Value = eventstat.FoodRev();
            newrow.Cells[5].Value = eventstat.LoanMatRev();
            newrow.Cells[6].Value = eventstat.TickWithDiscount() * 45 + eventstat.TickWithoutDiscount() * 50 +eventstat.CampRev() + eventstat.FoodRev() + eventstat.LoanMatRev();
            dataGridView1.Rows.Add(newrow);
        }

     }
}
