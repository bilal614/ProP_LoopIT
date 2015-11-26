using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazzEventProject.Classes
{
    class ItemDataHelper : DataHelper
    {
        /// <summary>
        /// Read all of the foods item from database put in to the list
        /// </summary>
        /// <returns>List of items</returns>
        public List<Items> GetAllFoods()
        {
            String sql = "SELECT * FROM FOOD";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Items> temp;
            temp = new List<Items>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int FoodID;
                string FoodName;
                int FoodQuantity;
                decimal FoodPrice;
                while (reader.Read())
                {
                    FoodID = Convert.ToInt32(reader["Food_ID"]);
                    FoodName = Convert.ToString(reader["Food_Name"]);
                    FoodQuantity = Convert.ToInt32(reader["Food_Quantity"]);
                    FoodPrice = Convert.ToDecimal(reader["Food_Price"]);

                    temp.Add(new Items(FoodID, FoodName, FoodPrice, FoodQuantity));
                }
            }
            catch
            {
                MessageBox.Show("error while loading");
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        /// <summary>
        /// Get a food item from the list of foods
        /// </summary>
        /// <returns>A object with type item</returns>
        public Items GetAnItem(int id, List<Items> lists)
        {
            Items item = null;
            foreach(var tempItem in lists)
            {
                if (tempItem.ID == id)
                {
                    item = tempItem;
                }
            }
            return item;
        }
         /// <summary>
         /// Sell food with the given id and quantity
         /// </summary>
         /// <param name="id"></param>
         /// <param name="quantity"></param>
         /// <returns></returns>
        public bool SellItem(int id, int quantity, List<Items> ListOfItem)
        {
            Items sitem = GetAnItem(id, ListOfItem);
            if (sitem.Quantity >= quantity)
            {
                sitem.Quantity -= quantity;
                return true;
            }
            else
                return false;
        }
         
        /// <summary>
        /// Check wheather the id is exist in the list or not
        /// </summary>
        /// <param name="ListOfItems"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckUniqueItem(List<Items> ListOfItems, int id)
        {
            bool unique = true;
            foreach (var i in ListOfItems)
            {
                if(i.ID == id)
                {
                    unique = false;
                }
            }
            return unique;
        }

       /// <summary>
       /// Check the material is unique or not. Unique here means that the loaned item id and date return have to be different.
       /// It means that, the application allow clients borrow the same material and return it at different time.
       /// </summary>
       /// <param name="ListOfItems"></param>
       /// <param name="id"></param>
       /// <param name="returnDate"></param>
       /// <returns></returns>
        public bool CheckUniqueItem(List<Material_Invoice_Items> ListOfItems, int id, DateTime returnDate)
        {
            bool unique = true;
            foreach (var i in ListOfItems)
            {
                if (i.Item_Id == id && DateTime.Compare(i.ReturnDate,returnDate) == 0)
                {
                    unique = false;
                }
            }
            return unique;
        }

        /// <summary>
        /// Update a food with the given id. Return the number of updated row if the id is in the table and the updating process is success. 
        /// Otherwise, return false.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>int values</returns>
        public int UpdateAFood(int id, List<Items> listsFood)
        {
            Items seletedFood = GetAnItem(id, listsFood);
            String sql = string.Format("UPDATE FOOD SET FOOD_QUANTITY = {0} WHERE Food_ID = {1};", seletedFood.Quantity, seletedFood.ID);
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
        /// Load all of the material items from database put in to the list
        /// </summary>
        /// <returns>List of items</returns>
        public List<Items> GetAllMaterials()
        {
            String sql = "SELECT * FROM MATERIAL";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Items> temp;
            temp = new List<Items>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int Material_ID;
                string Name;
                decimal LoaningPrice;
                decimal DepositAmount;
                int MaterialQuantity;
                string Description;
                while (reader.Read())
                {
                    Material_ID = Convert.ToInt32(reader["Material_ID"]);
                    Name = Convert.ToString(reader["Name"]);
                    MaterialQuantity = Convert.ToInt32(reader["Material_Quantity"]);
                    LoaningPrice = Convert.ToDecimal(reader["Loaning_Price"]);
                    DepositAmount = Convert.ToDecimal(reader["Deposit_Amount"]);
                    Description = Convert.ToString(reader["Description"]);
                    Material m = new Material(Material_ID, Name, LoaningPrice, MaterialQuantity, DepositAmount, Description);               
                    temp.Add(m);
                }
            }
            catch
            {
                MessageBox.Show("error while loading");
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        /// <summary>
        /// Update a material with the given id. Return the number of updated row if the id is in the table and the updating process is success. 
        /// Otherwise, return false.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>int values</returns>
        public int UpdateAMaterial(int id, List<Items> materials)
        {
            Items seletedMaterial = GetAnItem(id, materials);
            String sql = string.Format("UPDATE MATERIAL SET Material_Quantity = {0} WHERE Material_ID = {1};", seletedMaterial.Quantity, seletedMaterial.ID);
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


//UPDATE FOOD SET FOOD_QUANTITY = 165
//WHERE Food_ID = 1;