using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazzEventProject.Classes
{
    class EventReportDataHelper: DataHelper
    {

        public int NrOfReg()
        {
            String sql = "SELECT COUNT(*) FROM E_ACCOUNT ";
                MySqlCommand command = new MySqlCommand(sql, connection);
                int number = 0;
                try
                {
                    connection.Open();
                    number = Convert.ToInt32(command.ExecuteScalar());
                    return number;
                }
                catch
                {
                   return -1;
                }
                finally
                {
                    connection.Close();
                }
        
        }

        public int TickWithDiscount()
        {
            String sql = "SELECT COUNT(*) FROM E_ACCOUNT WHERE Pay_InAdvance = 1 ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int number = 0;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch
            {
            return -1;
            }
            finally
            {
                connection.Close();
            }

        }

        public int TickWithoutDiscount()
        {
            String sql = "SELECT COUNT(*) FROM E_ACCOUNT WHERE (Payment_Status = 1 AND Pay_InAdvance = 0)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int number = 0;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }
        public int NrOfCampRented()
        {
            String sql = "SELECT COUNT(*) FROM CAMPING_RES ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int number = 0;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }
        public int CampRev()
        {
            String sql = "SELECT (COUNT( DISTINCT CampRes_No)*30 + COUNT(GroupID)*20) FROM GROUPMEMBERS ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int number = 0;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }
        public decimal FoodRev()
        {
            String sql = "SELECT SUM(i.Quantity_Sold * f.Food_Price) FROM FOOD_INVOICE i INNER JOIN FOOD f GROUP BY i.Food_ID ";//ON (i.Food_ID = f.Food_ID)
            MySqlCommand command = new MySqlCommand(sql, connection);
            decimal number = 0;
            try
            {
                connection.Open();
                number = Convert.ToDecimal(command.ExecuteScalar());
                return number;
            }
            catch
            {
               return -1;
            }
            finally
            {
                connection.Close();
            }

        }
        public decimal LoanMatRev()
        {
            String sql = "SELECT ROUND(SUM(im.Material_ID * m.Loaning_Price), 2) FROM MATERIAL m INNER JOIN MATERIAL_INVOICE im GROUP BY im.Material_ID ";//ON (m.Material_ID = im.Material_ID)
            MySqlCommand command = new MySqlCommand(sql, connection);
            decimal number = 0;
            try
            {
                connection.Open();
                number = Convert.ToDecimal(command.ExecuteScalar());
                return number;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }


    }
}
