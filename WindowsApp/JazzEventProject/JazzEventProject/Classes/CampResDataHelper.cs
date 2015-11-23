using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazzEventProject.Classes
{
    class CampResDataHelper : DataHelper
    {
        //here we create a prototype for getting CampRes objects to compare the CampRes.CampResNo to the CampResNo 
        //reported by the GroupMember objects that we get from the database
        public delegate CampRes CampCompare(CampResDataHelper sender, int campResNo);

        //we define the event
        public event CampCompare campComparison;

        EventAccountDataHelper accountDataHolder = new EventAccountDataHelper();
        EventAccount accountHolder = null;

        public EventAccount EventAccountIdGetter(EventAccountDataHelper datHelp, int iD)
        {
            accountHolder = datHelp.GetAccount(iD);
            return accountHolder;
        }

        /// <summary>
        /// Returns the a CampRes object if it exist in the databse otherwise it returns a null. If the accountId exists
        /// in the database as in the CampReservation table in database the method will return a CampRes object otherwise
        /// it will return an empty CampRes object.
        /// </summary>
        /// <param >int AccountId</param>
        /// <returns>CampRes</returns>
        public CampRes GetAReservation(int accountId)
        {
            accountDataHolder.eventAccountCalled += new EventAccountDataHelper.EventAccountDataHandler(EventAccountIdGetter);

            EventAccountIdGetter(accountDataHolder, accountId);

            CampRes reservation = null;

            String str_campRes = Convert.ToString(accountId);
            String sql = String.Format("SELECT * FROM CAMPING_RES WHERE Account_ID={0}", str_campRes);
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                int campResNo = 0;
                int campId;
                DateTime startDate;
                DateTime endDate;
                int camperAcctId = 0;


                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    campResNo = Convert.ToInt32(reader["CampRes_No"]);
                    camperAcctId = Convert.ToInt32(reader["Account_ID"]);
                    campId = Convert.ToInt32(reader["CAMP_CampID"]);
                    startDate = Convert.ToDateTime(reader["Start_Date"]);
                    endDate = Convert.ToDateTime(reader["End_Date"]);

                    if (campComparison != null)
                        campComparison(this, campResNo);

                    reservation = new CampRes(campResNo, campId, startDate, endDate);
                }

                if (accountHolder.AccountId == camperAcctId)//this ensures that the person registered in the 
                { return reservation; }//campingres table of database also exists in the EventAccount table of
                else { reservation = null; }//the database

            }
            catch
            { MessageBox.Show("error while loading from database."); }
            finally { connection.Close(); }

            return reservation;
        }

        public CampRes GetCampRes(int campResNo)
        {
            CampRes reservationGroup = null;
            try
            {
                String str_campRes = Convert.ToString(campResNo);
                String sql = String.Format("SELECT * FROM CAMPING_RES WHERE CampRes_No={0}", str_campRes);
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int resNo, campId; DateTime startDate, endDate;
                while (reader.Read())
                {
                    resNo = Convert.ToInt32(reader["CampRes_No"]);
                    campId = Convert.ToInt32(reader["CAMP_CampID"]);
                    startDate = Convert.ToDateTime(reader["Start_Date"]);
                    endDate = Convert.ToDateTime(reader["End_Date"]);
                    reservationGroup = new CampRes(resNo, campId, startDate, endDate);
                }

            }
            catch
            { MessageBox.Show("error while loading from database."); }

            return reservationGroup;
        }

    }
}