using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace JazzEventProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Moving panel to moving form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnEventEntrance_Click(object sender, EventArgs e)
        {
            Form entranceform = new EntranceEvent();
            entranceform.Show();
        }

        private void btnCamp_Click(object sender, EventArgs e)
        {
            Form campform = new CampReservation();
            campform.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form exitform = new ExitEvent();
            exitform.Show();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            Form statusevent = new EventStatusReport();
            statusevent.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            Form loanMaterial = new LoanMaterial();
            loanMaterial.Show();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            Form foodform = new FoodShop();
            foodform.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Form paymentform = new PayPalTextFileTranslator();
            paymentform.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Headerpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximine_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
       
          
        }

      
    }
}
