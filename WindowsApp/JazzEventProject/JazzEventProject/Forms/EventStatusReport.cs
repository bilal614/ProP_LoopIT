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

        EventAccountDataHelper accountHelper = new EventAccountDataHelper();
        private void EventStatusReport_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DataGridViewRow newrow = new DataGridViewRow();
            newrow.CreateCells(dataGridView1);
            newrow.Cells[0].Value = 1;
            newrow.Cells[1].Value = 2;
            newrow.Cells[2].Value = 3;
            newrow.Cells[3].Value = 4;
            newrow.Cells[4].Value = 5;
            newrow.Cells[5].Value = 5;
            newrow.Cells[6].Value = 5;
            dataGridView1.Rows.Add(newrow);
        }

     }
}
