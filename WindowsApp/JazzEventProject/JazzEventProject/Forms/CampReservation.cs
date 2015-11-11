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
        public CampReservation()
        {
            InitializeComponent();
        }
        private CampDataHelper CampDh;
        private void CampReservation_Load(object sender, EventArgs e)
        {
            
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            CampDh = new CampDataHelper();
            Camp c = CampDh.GetACamp();
            MessageBox.Show(c.GetInfo());
        }

    }
}
