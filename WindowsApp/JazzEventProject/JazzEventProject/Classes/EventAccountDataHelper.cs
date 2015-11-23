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
        public delegate EventAccount EventAccountDataHandler(EventAccountDataHelper sender,int accountId);
        //1)protoype of the method
        public event EventAccountDataHandler eventAccountCalled;
        //2) we dfine the event here
        /// <summary>
        /// Returns the eventId of the EventAccount if it exist in the databse otherwise it returns a -1.
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public int GetEventAccountId(int eventId)
        {
            String str_eventId = Convert.ToString(eventId);
            String sql = String.Format("SELECT * FROM E_ACCOUNT WHERE Account_ID={0}",str_eventId);
            MySqlCommand command = new MySqlCommand(sql, connection);

            int tempId=0;

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tempId = Convert.ToInt32(reader["Account_ID"]);
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

        /// <summary>
        /// Added this extra method that returns the balance of the EventAccount with the given EventAccount eventId.
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public decimal GetAccountBalance(int eventId)//method for retreiving the account balance of the eventAccountId given as parameter
        {
            String str_eventId = Convert.ToString(eventId);
            decimal balance = -1;

            if (GetEventAccountId(eventId) >= 0)
            {
                String sql = String.Format("SELECT * FROM E_ACCOUNT WHERE Account_ID={0}", str_eventId);
                MySqlCommand command = new MySqlCommand(sql, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        balance = Convert.ToInt32(reader["Balance"]);
                    }
                }
                catch
                { MessageBox.Show("error while loading the participant."); }
                finally
                { connection.Close(); }
            }

            return balance;//this method will either return the balance if the eventAccountId was found in database
            //otherwise it will return -1
        }

        /// <summary>
        /// This method returns a particular EventAccount with the given eventId as provided in its parameters.
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public EventAccount GetAccount(int eventId)
        {
            String str_eventId = Convert.ToString(eventId);
            String sql = String.Format("SELECT * FROM E_ACCOUNT WHERE Account_ID={0}", str_eventId);
            MySqlCommand command = new MySqlCommand(sql, connection);

            EventAccount tempAccount=null;

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int EventId=0;
                string firstName;
                string lastName;
                string eMail;
                string phone;
                decimal balance;
                bool paymentStatus;
                bool payInAdvance;


                while (reader.Read())
                {
                    EventId = Convert.ToInt32(reader["Account_ID"]);
                    firstName=Convert.ToString(reader["First_Name"]);
                    lastName=Convert.ToString(reader["Last_Name"]);
                    eMail=Convert.ToString(reader["E_mail"]);
                    phone=Convert.ToString(reader["Phone"]);
                    balance=Convert.ToDecimal(reader["Balance"]);
                    paymentStatus=Convert.ToBoolean(reader["Payment_Status"]);
                    payInAdvance=Convert.ToBoolean(reader["Pay_InAdvance"]);

                    if (EventId > 0)
                    {
                        tempAccount = new EventAccount(EventId, firstName, lastName, eMail, phone, balance,
                               paymentStatus, payInAdvance);
                        tempAccount.PaymentStatus = paymentStatus;
                        tempAccount.PayInAddvance = payInAdvance;

                        //if (eventAccountCalled != null)
                        //    eventAccountCalled(this,EventId);//event is raised when a an EventAccount object would be
                        ////returned from this method
                    }
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

        /// <summary>
        /// This method returns all the EventAccounts in the database.
        /// </summary>
        /// <returns></returns>

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
                    EventId = Convert.ToInt32(reader["Account_ID"]);
                    firstName = Convert.ToString(reader["First_Name"]);
                    lastName = Convert.ToString(reader["Last_Name"]);
                    eMail = Convert.ToString(reader["E_mail"]);
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

        ///<summary>
        ///This method allows the participants to check in by being assigned an RFID code. The parameters are 
        ///the eventAccountId of the person and the rfid to be assigned to them. If the rfid is successfully 
        ///assigned to the persons EventAccount entity in the database the method will return a true value.
        ///</summary>
        public bool CheckIn(int id, int rfid)
        {
            EventAccount currentClient = GetAccount(id);
            bool checkIn = false;

            if (currentClient != null && currentClient.RFID>0)//to check if the EventAccount exists in database
            {

                String sql = String.Format("UPDATE E_ACCOUNT SET RFID_Code={0} WHERE Account_ID={1}", rfid, id);
                MySqlCommand command = new MySqlCommand(sql, connection);

                try
                {
                    connection.Open();
                    int nrOfrecordsChanged = command.ExecuteNonQuery();
                    if (nrOfrecordsChanged == 1)
                    { MessageBox.Show("RFID was successfully assigned."); checkIn = true; }
                }
                catch
                { MessageBox.Show("error while loading the participant."); }
                finally
                { connection.Close(); }
            }
            else
            {
                MessageBox.Show("Event account Id does not exist in database.");
            }
            return checkIn;
        }

        ///<summary>
        ///This method allows the participants to check out by giving back the RFID tags when they leave. 
        ///Therfore the RFID_Code of that particular person has to be set to NULL in the database.The parameters 
        ///are the eventAccountId of the person in question. If the rfid is successfully made NULL in the person's 
        ///EventAccount entity in the database the method will return a true value.
        ///</summary>
        public bool CheckOut(int id)
        {
            EventAccount currentClient = GetAccount(id);
            bool checkIn = false;

            if (currentClient != null)//to check if the EventAccount exists in database
            {

                String sql = String.Format("UPDATE E_ACCOUNT SET RFID_Code=-1 WHERE Account_ID={0}", id);
                MySqlCommand command = new MySqlCommand(sql, connection);

                try
                {
                    connection.Open();
                    int nrOfrecordsChanged = command.ExecuteNonQuery();
                    if (nrOfrecordsChanged == 1)
                    { MessageBox.Show("RFID was successfully removed."); checkIn = true; }
                }
                catch
                { MessageBox.Show("error while loading the participant."); }
                finally
                { connection.Close(); }
            }
            else
            {
                MessageBox.Show("Event account Id does not exist in database.");
            }
            return checkIn;
        }

        ///<summary>
        ///This method allows the participants  to pay their entrance fees when they are at the 
        ///entrance desk. The method takes two parameters, the id will find the EventAccount to update the balance 
        ///of the given EventAccount with the given id. Judging from the form for EntranceEvent the only member 
        ///that would change at that point would be the balance of the person when he/she makes the payment to enter 
        ///the event therefore the method has been modified to update the balacnce only.
        ///</summary>          
        public bool UpdateAccountBalanceEntrance(int id,decimal balance)
        {
            EventAccount currentClient = GetAccount(id);
            decimal totalBalance=0;
            bool ticketPaid = false;

            if (currentClient != null) { totalBalance = currentClient.Balance; }//adds existing balance of the
            //currentClient to the totalBalance if that client exists in the DB
            totalBalance += balance;

            if (currentClient != null && totalBalance>=55)//to check if the EventAccount exists in database
            {
                String sql = String.Format("UPDATE E_ACCOUNT SET Balance={0},Payment_Status=TRUE WHERE Account_ID={1}",
                    totalBalance, id);
                MySqlCommand command = new MySqlCommand(sql, connection);
                try
                {
                    connection.Open();
                    int nrOfrecordsChanged = command.ExecuteNonQuery();
                    if (nrOfrecordsChanged == 1)
                    { MessageBox.Show("Balance successfully updated."); ticketPaid = true; }
                }
                catch
                { MessageBox.Show("error while loading the participant."); }
                finally
                { connection.Close(); }
            }
            else
            {
                MessageBox.Show("Event account Id does not exist in database.");
            }

            return ticketPaid;
        }

        ///<summary>
        ///This method allows the participants  to pay their entrance fees when they are at the 
        ///entrance desk. The method takes two parameters, the id will find the EventAccount to update the balance 
        ///of the given EventAccount with the given id. Judging from the form for EntranceEvent the only member 
        ///that would change at that point would be the balance of the person when he/she makes the payment to enter 
        ///the event therefore the method has been modified to update the balacnce only.
        ///</summary> 
        public bool UpdateAccountBalance(int id, decimal balance)
        { 
            EventAccount currentClient = GetAccount(id);
            decimal totalBalance=0;
            bool ticketPaid = false;

            if (currentClient != null) { totalBalance = currentClient.Balance; }//adds existing balance of the
            //currentClient to the totalBalance if that client exists in the DB
            totalBalance += balance;

            if (currentClient != null)
            {
                String sql = String.Format("UPDATE E_ACCOUNT SET Balance={0} WHERE Account_ID={1}",
                    totalBalance, id);
                MySqlCommand command = new MySqlCommand(sql, connection);
                try
                {
                    connection.Open();
                    int nrOfrecordsChanged = command.ExecuteNonQuery();
                    if (nrOfrecordsChanged == 1)
                    { MessageBox.Show("Balance successfully updated."); ticketPaid = true; }
                }
                catch
                { MessageBox.Show("error while loading the participant."); }
                finally
                { connection.Close(); }
            }
            else
            {
                MessageBox.Show("Event account Id does not exist in database.");
            }

            return ticketPaid;
        }


    }
}
