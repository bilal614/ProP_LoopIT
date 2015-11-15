using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazzEventProject.Classes
{
    class InvoiceDataHelper : DataHelper
    {
        /// <summary>
        /// Select all invoices for food from database.
        /// </summary>
        /// <returns>List of food invoices</returns>
        public List<Invoice> GetAllFoodInvoices()
        {
            String sql = "SELECT * FROM F_Invoice";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Invoice> temp;
            temp = new List<Invoice>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int Food_InvoiceID;
                DateTime SoldDate;
                int Account_ID;
                while (reader.Read())
                {
                    Food_InvoiceID = Convert.ToInt32(reader["Food_InvoiceID"]);
                    SoldDate = Convert.ToDateTime(reader["SoldDate"]);
                    Account_ID = Convert.ToInt32(reader["Account_ID"]);


                    temp.Add(new Invoice(Food_InvoiceID, SoldDate, Account_ID));
                }
            }
            catch
            {
                MessageBox.Show("error while loading the invoices");
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        public int AddAFoodInvoice(int foodID, string SoldDate, int Account_ID)
        {
            String sql = String.Format("INSERT INTO F_INVOICE(Food_InvoiceID, SoldDate, Account_ID) VALUES ({0},STR_TO_DATE('{1}', '%d-%m-%Y'), {2});", foodID, SoldDate, Account_ID);
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Generate the Invoice ID, automaticly
        /// Find the maximum invoice id and plus it for 1
        /// </summary>
        /// <returns></returns>
        public int GenerateInvoiceID()
        {
            List<Invoice> temp = GetAllFoodInvoices();
            //Find the highest id
            int id = -1;
            for (int i = 0; i < temp.Count() - 1 ; i++)
            {
                if(temp[i].Id <= temp[i+1].Id)
                {
                    id = temp[i + 1].Id;
                }
            }
            id = id + 1;
            return id;
        }
    }
}
