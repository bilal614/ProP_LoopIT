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
                   MessageBox.Show("Error processing your request. Make sure you are coneected to the server and that you used the right table. ");
                   return -1;
                }
                finally
                {
                    connection.Close();
                }
        
        }

        public int TickRev()
        {
            String sql = "SELECT SUM(BALANCE) FROM E_ACCOUNT ";
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
                MessageBox.Show("Error processing your request. Make sure you are coneected to the server and that you used the right table. ");
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }
        public int CampRev()
        {
            String sql = "SELECT SUM(*) FROM E_ACCOUNT ";
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
                MessageBox.Show("Error processing your request. Make sure you are coneected to the server and that you used the right table. ");
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }
        public int FoodRev()
        {
            String sql = "SELECT SUM(*) FROM E_ACCOUNT ";
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
                MessageBox.Show("Error processing your request. Make sure you are coneected to the server and that you used the right table. ");
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }
        public int LoanMatRev()
        {
            String sql = "SELECT SUM(*) FROM E_ACCOUNT ";
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
                MessageBox.Show("Error processing your request. Make sure you are coneected to the server and that you used the right table. ");
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }


    }
}
