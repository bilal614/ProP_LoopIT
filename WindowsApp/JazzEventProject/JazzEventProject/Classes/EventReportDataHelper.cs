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

        // Visitors who check in

        public int NrOfVisPresent()
        {
            String sql = "SELECT COUNT(*) FROM `e_account` WHERE RFID_Code IS NOT NULL ";
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

        // All event account balance

        public decimal EvAccountBalance()
        {
            String sql = "SELECT ROUND(IFNULL(SUM(Balance),0),2) FROM E_ACCOUNT  ";
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

        // Big burger sold
        public int BBurgerSold()
        {
            String sql = "SELECT IFNULL(SUM(Quantity_Sold),0) FROM FOOD_INVOICE WHERE Food_ID = 1 "; 
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

        // Cocacola sold
        public int CColaSold()
        {
            String sql = "SELECT IFNULL(SUM(Quantity_Sold),0) FROM FOOD_INVOICE WHERE Food_ID = 6 ";
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

        // Chicken burger sold
        public int ChickBurgerSold()
        {
            String sql = "SELECT IFNULL(SUM(Quantity_Sold),0) FROM FOOD_INVOICE WHERE Food_ID = 3 ";
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

        // French fries sold
        public int FFriesSold()
        {
            String sql = "SELECT IFNULL(SUM(Quantity_Sold),0) FROM FOOD_INVOICE WHERE Food_ID = 2 ";
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

        // Heinneken beer sold
        public int HBeerSold()
        {
            String sql = "SELECT IFNULL(SUM(Quantity_Sold),0) FROM FOOD_INVOICE WHERE Food_ID = 5 ";
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

        // Salad sold
        public int SaladSold()
        {
            String sql = "SELECT IFNULL(SUM(Quantity_Sold),0) FROM FOOD_INVOICE WHERE Food_ID = 4 ";
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


        //Select food report infors
        public List<FoodReport> GetAllFoodInfors()
        {
            String sql = "select f.food_ID as foodID, f.food_name as foodName, sum(fi.quantity_sold) soldQuantity, f.food_quantity availableQuantity from food f join food_invoice fi on f.food_id = fi.food_id group by f.food_id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<FoodReport> temp;
            temp = new List<FoodReport>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                 int FoodID;
                string FoodName;
                int amountSold;
                int amountAval;
                while (reader.Read())
                {
                    FoodID = Convert.ToInt32(reader["foodID"]);
                    FoodName = Convert.ToString(reader["foodName"]);
                    amountSold = Convert.ToInt32(reader["soldQuantity"]);
                    amountAval = Convert.ToInt32(reader["availableQuantity"]);

                    temp.Add(new FoodReport(FoodID, FoodName, amountSold, amountAval));

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

        // Select all users information

        public List<UserReport> GetAllUsersInfos()
        {
            String sql = " SELECT e.Account_ID as UserID, e.First_Name as FName, e.Last_Name as LName, e.Balance as U_Bal, e.Phone as Phone, IFNULL(m.ReturnStatus,0) as LoanMat, IFNULL(SUM(f.Quantity_Sold * fo.Food_Price),0) AS TOTAL FROM e_account e LEFT JOIN m_invoice m ON e.Account_ID = m.Account_ID LEFT JOIN F_INVOICE i ON e.Account_ID = i.Account_ID LEFT JOIN FOOD_Invoice f ON i.Food_InvoiceID = f.Food_InvoiceID LEFT JOIN FOOD fo ON f.food_ID = fo.food_ID GROUP BY e.Account_ID ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<UserReport> temp2;
            temp2 = new List<UserReport>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int User_ID;
                string First_Name;
                string Last_Name;
                decimal User_Balance;
                int Phone;
                decimal Money_Spent;
                decimal Avail_Bal;
                string Loaned_Material;
                while (reader.Read())
                {
                    User_ID = Convert.ToInt32(reader["UserID"]);
                    First_Name = Convert.ToString(reader["FName"]);
                    Last_Name = Convert.ToString(reader["LName"]);
                    Money_Spent = Convert.ToDecimal(reader["TOTAL"]) ;
                    User_Balance = Convert.ToDecimal(reader["U_Bal"]);
                    Phone = Convert.ToInt32(reader["Phone"]);
                    
                    Avail_Bal = User_Balance - Money_Spent;
                    if (Convert.ToInt32(reader["LoanMat"]) == 0)
                        Loaned_Material = "No";
                    else
                        Loaned_Material = "Yes";
                        ;

                        temp2.Add(new UserReport(User_ID, First_Name, Last_Name, Money_Spent , Avail_Bal, Phone, Loaned_Material));
                }
            }
            catch
            {
                MessageBox.Show("error while loading users");
            }
            finally
            {
                connection.Close();
            }
            return temp2;
        }
    }
}
