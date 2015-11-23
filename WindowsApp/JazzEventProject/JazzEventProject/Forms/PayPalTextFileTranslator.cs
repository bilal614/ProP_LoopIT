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
    public partial class PayPalTextFileTranslator : Form
    {
        public PayPalTextFileTranslator()
        {
            InitializeComponent();
        }

        private PaypalInvoiceReader read;
        public List<string> s;
        private void btnLoadFileAndSave_Click(object sender, EventArgs e)
        {
            
            // this is the loading part that will read the paypal text file. I used a predefined name for testing.
            read = new PaypalInvoiceReader("test.txt");
            s = read.readfile();
            
            foreach ( string m in s)
            {
               richTextBox1.Text += m + "\n";
            }

            // that part below is the saving part that will update the client balance

            EventAccount currentAccount;
            EventAccountDataHelper accountHelper = new EventAccountDataHelper();
            //accountHelper.UpdateAccountBalance();

        }
    }
}
