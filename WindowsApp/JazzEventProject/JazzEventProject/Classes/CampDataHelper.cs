using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazzEventProject.Classes
{
    class CampDataHelper : DataHelper
    {
        /// <summary>
        /// This method returns all the camps listed in the database as Camp class objects.
        /// </summary>
        /// <returns></returns>
        public List<Camp> GetAllCamps()
        {
            String sql = "SELECT * FROM CAMP";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Camp> temp;
            temp = new List<Camp>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int CampID;
                string CampDes;
                int MaxPerson;
                bool available;
                while (reader.Read())
                {
                    CampID = Convert.ToInt32(reader["CampID"]);
                    CampDes = Convert.ToString(reader["Description"]);
                    MaxPerson = Convert.ToInt32(reader["MaxPerson"]);
                    available = Convert.ToBoolean(reader["Available"]);

                    temp.Add(new Camp(CampID, CampDes, MaxPerson, available));
                }
            }
            catch
            {
                MessageBox.Show("error while loading the camps");
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        /// <summary>
        /// This method returns the object Camps from the list of all the camp object available in the databse that are available.
        /// </summary>
        /// <returns></returns>
        public List<Camp> GetFreeCamps()
        {
            List<Camp> allCamps = GetAllCamps();
            List<Camp> freeCamps = null;

            foreach (Camp c in allCamps)
            {
                if (c.Available == true)
                    freeCamps.Add(c);
            }

            return freeCamps;
        }
    }
}
