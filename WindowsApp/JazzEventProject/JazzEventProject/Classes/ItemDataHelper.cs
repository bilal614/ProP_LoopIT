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
        public Items GetAFood(int id, List<Items> listsFood)
        {
            Items item = null;
            foreach(var tempItem in listsFood)
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
        public bool SellFood(int id, int quantity, List<Items> listsFood)
        {
            Items sitem = GetAFood(id,listsFood);
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
        /// Update a food with the given id. Return true if the id is in the table and the updating process is success. 
        /// Otherwise, return false.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>boolean values</returns>
        public int UpdateAFood(int id, List<Items> listsFood)
        {
            Items seletedFood = GetAFood(id, listsFood);
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
    }
}


//UPDATE FOOD SET FOOD_QUANTITY = 165
//WHERE Food_ID = 1;