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

        /// <summary>
        /// Insert a new invoice into database
        /// </summary>
        /// <param name="foodID"></param>
        /// <param name="SoldDate"></param>
        /// <param name="Account_ID"></param>
        /// <returns></returns>
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
        public int GenerateInvoiceID(List<Invoice> Invoices)
        {
            //Find the highest id
            int maxid = 0;
            try
            {
                maxid = Invoices[0].Id;
            }
            catch
            {
                MessageBox.Show("No invoices is created");
            }
            finally
            {
                for (int i = 1; i < Invoices.Count(); i++)
                {
                    if (maxid <= Invoices[i].Id)
                    {
                        maxid = Invoices[i].Id;
                    }
                }
            }
            return maxid + 1;
        }

       /// <summary>
       /// Insert a loaning material invoice into database
       /// 
       /// </summary>
       /// <param name="InvoiceID"></param>
       /// <param name="StartDate"></param>
       /// <param name="Account_ID"></param>
       /// <param name="returnStatus"></param>
       /// <returns></returns>
        public int AddAMaterialInvoice(int InvoiceID, string StartDate, int Account_ID, bool returnStatus)
        {
            String sql = String.Format("INSERT INTO M_INVOICE(Material_InvoiceID, Start_Date, Account_ID, ReturnStatus) VALUES ({0},STR_TO_DATE('{1}', '%d-%m-%Y'), {2}, {3});", InvoiceID, StartDate, Account_ID, returnStatus);
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
        /// Get all materials from database
        /// </summary>
        /// <returns></returns>
        public List<Invoice> GetAllMaterialInvoices()
        {
            String sql = "SELECT * FROM M_Invoice";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Invoice> temp;
            temp = new List<Invoice>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int Material_InvoiceID;
                DateTime LoanDate;
                bool ReturnStatus;
                int Account_ID;
                while (reader.Read())
                {
                    Material_InvoiceID = Convert.ToInt32(reader["Material_InvoiceID"]);
                    LoanDate = Convert.ToDateTime(reader["Start_Date"]);
                    Account_ID = Convert.ToInt32(reader["Account_ID"]);
                    ReturnStatus = Convert.ToBoolean(reader["ReturnStatus"]);


                    temp.Add(new MaterialInvoice(Material_InvoiceID, LoanDate,Account_ID, ReturnStatus));
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
    }
}
