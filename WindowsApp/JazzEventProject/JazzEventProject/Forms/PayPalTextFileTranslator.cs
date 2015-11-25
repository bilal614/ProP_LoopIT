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
            
            // this is the loading part that will read the paypal text file. 
            // I used a predefined name for testing. We will just have to indicate the name 
            // of the paypal textfile for the updates.
            // At the same time it will update the balance of the client
            read = new PaypalInvoiceReader("test.txt");
            s = read.readfile();
            
            foreach ( string m in s)
            {
               richTextBox1.Text += m + "\n";

               int index = s.IndexOf(m);
               if (index > 3)
               {

                   int[] arrID = new int[s.Count - 4];
                   decimal[] arrB = new decimal[s.Count - 4];
                   string[] arrS = m.Split(' ');
                   foreach (string l in arrS)
                   {
                       arrID[index - 4] = Convert.ToInt32(arrS[0]);
                       arrB[index - 4] = Convert.ToDecimal(arrS[1]);
                   }
                   
                   EventAccountDataHelper accountHelper = new EventAccountDataHelper();

                   accountHelper.UpdateAccountBalance(arrID[index - 4], arrB[index - 4]);
               }
            }

            
        }
    }
}
