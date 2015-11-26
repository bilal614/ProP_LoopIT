using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject.Classes
{
    class Item_InvoiceDataHelper : DataHelper
    {
        /// <summary>
        /// Insert a new food_invoice into databse
        /// </summary>
        /// <param name="invoice_id"></param>
        /// <param name="quantity"></param>
        /// <param name="foodID"></param>
        /// <returns></returns>
        public int AddNewSoldFood(int invoice_id, int quantity, int foodID)
        {
            String sql = String.Format("INSERT INTO FOOD_INVOICE(Quantity_Sold, Food_InvoiceID, Food_ID) VALUES ({0}, {1}, {2});", quantity, invoice_id, foodID);
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

       
        public int AddNewLoanedMaterial(int invoice_id, int quantity, int materialID, DateTime returnDate, bool returnStatus)
        {
            String sql = String.Format("INSERT INTO MATERIAL_INVOICE( Material_Quantity, Material_ID, Material_InvoiceID, ReturnDate, ReturnStatus) VALUES ({0}, {1}, {2}, STR_TO_DATE('{3}', '%d-%m-%Y'), {4});", quantity, materialID, invoice_id, returnDate, returnStatus);
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
    }
}
