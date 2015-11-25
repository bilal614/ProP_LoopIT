using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace JazzEventProject.Classes
{
    class PaypalInvoiceReader
    {
        // This class will read the data from the text file
        public string tfile {get; set;} // name of the file
 
        public PaypalInvoiceReader(string Tfile)
        {
            this.tfile = Tfile;
        }

        public List<string> readfile()
        {
            FileStream fs = null;
            StreamReader sr = null;

            List<string> b = new List<string>();

            try
            {
                fs = new FileStream(tfile, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                string p = sr.ReadLine();
                while (p != null)
                {
                    b.Add(p);
                    p = sr.ReadLine();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Problem finding the file.");
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

            return b;
        }

        }
}
