using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazzEventProject.Classes
{
    class GroupDataHelper:DataHelper
    {
        CampResDataHelper campHelper = new CampResDataHelper();
        List<CampRes> campHolder = null;

        public List<CampRes> CampResNoGetter(CampResDataHelper datHelp, int CampresNo)
        {

            return campHolder;
        }

        ///<summary>
        ///Get all GroupMember in Group table in the database 
        ///</summary>
        public List<GroupMember> GetAllGuests()
        {
            List<GroupMember> allGuests = null;

            try
            {
                String sql = String.Format("SELECT * FROM GROUPMEMBERS");
                MySqlCommand command = new MySqlCommand(sql, connection);

                int groupId; string coEMail; int campResNo; //bool checkIn;

                connection.Open(); 
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    groupId = Convert.ToInt32(reader["GroupID"]);
                    coEMail = Convert.ToString(reader["Co_email"]);
                    campResNo = Convert.ToInt32(reader["CampRes_No"]);
                    //checkIn = Convert.ToBoolean(reader["Check_in"]);

                    //no need to look at checkIn because it is assumed everybodys checkIn value would be false in
                    //database when they arrive at the festival
                    allGuests.Add(new GroupMember(groupId, coEMail, campResNo));
                }

            }
            catch { MessageBox.Show("error while loading the participant."); }
            finally { }
            return allGuests;
        }


        /// <summary>
        /// Returns the a GroupMember object if it exist in the databse otherwise it returns a null. If the CampResNo exists
        /// in the database as in the GroupMember table in database the method will return a CampRes object otherwise
        /// it will return an empty CampRes object.
        /// </summary>
        /// <param >int CampResNo</param>
        /// <returns>GroupMemeber</returns>
    }
}
