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
        int rfid = 4;//will actually be provided by the scanning of the RFID
        int eID;
        string email;
        EventAccountDataHelper accountHelper = new EventAccountDataHelper();
        CampResDataHelper campDatHelper = new CampResDataHelper();
        CampRes reservation;
        GroupMember scannedMember;
        GroupDataHelper groupHelper=new GroupDataHelper();

        public CampReservation()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            eID=accountHelper.GetEventIdFromRFID(rfid);
            email=accountHelper.GetAccountEmailFromRFID(rfid);
            if (email !="")
            {
                scannedMember=groupHelper.GetGroupMembers(email);
                reservation = campDatHelper.GetCampRes(scannedMember.CampResNo);
            }
            
            if (reservation != null)
            {
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(dataGridView1);
                newrow.Cells[0].Value = scannedMember.CampResNo;
                newrow.Cells[1].Value = reservation.EndDate;
                newrow.Cells[2].Value = reservation.StartDate;
                newrow.Cells[3].Value = reservation.CampId;
                newrow.Cells[4].Value = scannedMember.GroupId;
                newrow.Cells[5].Value = scannedMember.Co_Email;
                newrow.Cells[6].Value = eID;
                newrow.Cells[7].Value = rfid;
                dataGridView1.Rows.Add(newrow);

            }
            else { MessageBox.Show("This accountId does not have a camping reservation."); }

        }


    }
}
