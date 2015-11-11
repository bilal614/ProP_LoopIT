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
        public Camp GetACamp()
        {
            String sql = "SELECT * FROM Camp WHERE CampID = 1";
            MySqlCommand command = new MySqlCommand(sql, connection);

            Camp temp = null;
            

            //try
            //{
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int CampID;
                string CampDes;
                int MaxPerson;
                int available;
                while (reader.Read())
                {
                    CampID = Convert.ToInt32(reader["CampID"]);
                    CampDes = Convert.ToString(reader["Description"]);
                    MaxPerson = Convert.ToInt32(reader["MaxPerson"]);
                    available = Convert.ToInt32(reader["Available"]);
                    temp = new Camp(CampID, CampDes, MaxPerson, available);
                }
            //}
            //catch
            //{
            //    MessageBox.Show("error while loading the camps");
            //}
            //finally
            //{
                connection.Close();
            //}
            return temp;
        }
    }
}
