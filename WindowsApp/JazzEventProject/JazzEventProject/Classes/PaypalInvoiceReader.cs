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
                    int index = b.IndexOf(p);
                    if (index > 3)
                    {
                        
                        int[] arrID = new int[b.Count - 4];
                        decimal[] arrB = new decimal[b.Count - 4];
                        string[] arrS = p.Split(' ');
                        foreach (string l in arrS)
                        {
                            arrS[0] = arrID[index - 4].ToString();
                            arrS[1] = arrB[index - 4].ToString();
                        }
                        
                    }
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
