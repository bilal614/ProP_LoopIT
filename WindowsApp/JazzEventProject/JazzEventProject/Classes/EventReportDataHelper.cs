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
        public int FoodRev()
        {
            String sql = "SELECT SUM(Quantity_Sold * 50) FROM FOOD_INVOICE ";
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
        public int LoanMatRev()
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


    }
}
