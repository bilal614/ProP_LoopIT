using JazzEventProject.Classes;
using Phidgets.Events;
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
        String rfid;//will actually be provided by the scanning of the RFID
        int eID;
        string email;
        EventAccount currentAccount;
        EventAccountDataHelper accountHelper = new EventAccountDataHelper();
        CampResDataHelper campDatHelper = new CampResDataHelper();
        CampRes reservation;
        GroupMember scannedMember;
        GroupDataHelper groupHelper = new GroupDataHelper();
        PhidgetHandler phidgetScanner = new PhidgetHandler();

        public CampReservation()
        {
            InitializeComponent();
        }


        private void CampReservation_Load(object sender, EventArgs e)
        {
            try
            {
                phidgetScanner.OpenRFIDReader();
                phidgetScanner.myRFIDReader.Tag += new TagEventHandler(ChangeTagOnForm);
            }
            catch { MessageBox.Show("No RFID reader detected."); }
        }

        private void ChangeTagOnForm(object sender, TagEventArgs e)
        {
            label20.Text = phidgetScanner.RFIDtagNr;
            if (phidgetScanner.RFIDtagNr != null)
            {
                rfid = phidgetScanner.RFIDtagNr;
                currentAccount = accountHelper.GetEventAccountFromRFID(rfid);
                if (currentAccount != null)
                {
                    eID = accountHelper.GetEventIdFromRFID(rfid);
                    email = accountHelper.GetAccountEmailFromRFID(rfid);
                    if (email != "")
                    {
                        scannedMember = groupHelper.GetGroupMembers(email);
                        if (scannedMember != null)
                        { reservation = campDatHelper.GetCampRes(scannedMember.CampResNo); }
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
                        newrow.Cells[8].Value = scannedMember.CheckIn;
                        dataGridView1.Rows.Add(newrow);

                    }
                    else { MessageBox.Show("This accountId does not have a camping reservation."); }
                }
                else { MessageBox.Show("The scanned RFID code does not exist in database."); }
            }
        }

        private void CampReservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { phidgetScanner.CloseRFIDReader(); }
            catch { MessageBox.Show("No open RFID scanners detected."); }
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (scannedMember != null)
            {
                if (groupHelper.CampCheckIn(scannedMember.Co_Email))
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
                    newrow.Cells[8].Value = scannedMember.CheckIn;
                    dataGridView1.Rows.Add(newrow);
                }
                else { MessageBox.Show("Could not check in."); }
            }
        }


    }
}
