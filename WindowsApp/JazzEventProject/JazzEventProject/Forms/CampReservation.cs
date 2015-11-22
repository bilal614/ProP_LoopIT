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
    public partial class CampReservation : Form
    {
        int accountId;
        EventAccount currentAccount;
        EventAccountDataHelper accountHelper = new EventAccountDataHelper();
        CampResDataHelper campDatHelper = new CampResDataHelper();
        CampRes reservation;

        public CampReservation()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            reservation=campDatHelper.GetAReservation(1);

            if (reservation != null)
            {
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(dataGridView1);
                newrow.Cells[0].Value = reservation.CampResNo;
                newrow.Cells[1].Value = reservation.EndDate;
                newrow.Cells[2].Value = reservation.StartDate;
                newrow.Cells[3].Value = reservation.CampId;
                dataGridView1.Rows.Add(newrow);

            }
            else { MessageBox.Show("This accountId does not have a camping reservation."); }

        }


    }
}
