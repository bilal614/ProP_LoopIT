using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace JazzEventProject.Classes
{
    class EventAccountDataHelper:DataHelper
    {
        public int GetEventAccountId(int eventId)
        {
            String str_eventId = Convert.ToString(eventId);
            String sql = String.Format("SELECT * FROM E_ACCOUNT WHERE E_Account_ID={0}",str_eventId);
            MySqlCommand command = new MySqlCommand(sql, connection);

            int tempId=0;

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tempId = Convert.ToInt32(reader["E_Account_ID"]);
                }
            }
            catch
            {
                MessageBox.Show("error while loading the participant.");
            }
            finally
            {
                connection.Close();
            }
            if (tempId == 0)
            { tempId = -1; }
            return tempId;//method will return -1 if the event accountId given in its parameters does not exist in 
            //the database
        }

        public EventAccount GetAccount(int eventId)
        {
            String str_eventId = Convert.ToString(eventId);
            String sql = String.Format("SELECT * FROM E_ACCOUNT WHERE E_Account_ID={0}", str_eventId);
            MySqlCommand command = new MySqlCommand(sql, connection);

            EventAccount tempAccount=null;

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int EventId;
                string firstName;
                string lastName;
                string eMail;
                string phone;
                decimal balance;
                bool paymentStatus;
                bool payInAdvance;


                while (reader.Read())
                {
                    EventId = Convert.ToInt32(reader["E_Account_ID"]);
                    firstName=Convert.ToString(reader["First_Name"]);
                    lastName=Convert.ToString(reader["Last_Name"]);
                    eMail=Convert.ToString(reader["Email"]);
                    phone=Convert.ToString(reader["Phone"]);
                    balance=Convert.ToDecimal(reader["Balance"]);
                    paymentStatus=Convert.ToBoolean(reader["Payment_Status"]);
                    payInAdvance=Convert.ToBoolean(reader["Pay_InAdvance"]);

                    if(EventId!=0)
                        tempAccount = new EventAccount(EventId, firstName, lastName, eMail, phone, balance, 
                            paymentStatus, payInAdvance);
                }
            }
            catch
            {
                MessageBox.Show("error while loading the participant.");
            }
            finally
            {
                connection.Close();
            }
            return tempAccount;//returns an EventAccount if the person exists in database else returns null object ref
        }

        public List<EventAccount> GetAllAccounts()
        {
            String sql = String.Format("SELECT * FROM E_ACCOUNT");
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<EventAccount> tempAccount = null;

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int EventId;
                string firstName;
                string lastName;
                string eMail;
                string phone;
                decimal balance;
                bool paymentStatus;
                bool payInAdvance;


                while (reader.Read())
                {
                    EventId = Convert.ToInt32(reader["E_Account_ID"]);
                    firstName = Convert.ToString(reader["First_Name"]);
                    lastName = Convert.ToString(reader["Last_Name"]);
                    eMail = Convert.ToString(reader["Email"]);
                    phone = Convert.ToString(reader["Phone"]);
                    balance = Convert.ToDecimal(reader["Balance"]);
                    paymentStatus = Convert.ToBoolean(reader["Payment_Status"]);
                    payInAdvance = Convert.ToBoolean(reader["Pay_InAdvance"]);

                    if (EventId != 0)
                        tempAccount.Add(new EventAccount(EventId, firstName, lastName, eMail, phone, balance,
                            paymentStatus, payInAdvance));
                }
            }
            catch
            {
                MessageBox.Show("error while loading the participant.");
            }
            finally
            {
                connection.Close();
            }
            return tempAccount;//returns an EventAccount if the person exists in database else returns null object ref
        }


    }
}
