using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject
{
    class EventAccount
    {
        public int AccountId { get; private set; }
        public int RFID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }
        public bool PaymentStatus { get; set; }
        public bool PayInAddvance { get; set; }

        ///<summary>
        ///Constructor method for creating an event account object.
        ///</summary>
        public EventAccount (int accountid, string firstname, string lastname, string email, string phone, decimal balance, bool paymentStatus, bool payInAdvance)
        {
            this.AccountId = accountid;
            this.RFID = -1;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Phone = phone;
            this.Balance = balance;
        }

        ///<summary>
        ///The implementation of this method will subtract the balance by 50 euros for the entrance fee in case of the participant did not pay in advance on website 
        ///Check if the PaymentStatus == false
        ///The status need to be updated after payment is done.
        ///</summary>
        public void PayEntranceFee()
        {
            this.Balance -= 50;
            if (PaymentStatus == false)
                this.PaymentStatus = true;
        }

        ///<summary>
        ///Added money into account's balance
        ///</summary>
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        ///<summary>
        ///Withdraw money from account's balance. 
        ///This method should check and return false if the balance is not enough
        ///</summary>
        public bool Withdraw(decimal amount)
        {
            if(this.Balance >= amount)
            {
                this.Balance -= amount;
                return true;
            }
            return false;
        }

        ///<summary>
        ///sets the RFID_Code by the given code in case of the RFID’s value is -1 (it means that the value in database is NULL) and return true. 
        ///Otherwise the method will be return false. This methods will be called in the check-in procedure of event.
        ///</summary>
        public bool ActivateRFID(int code)
        {
            if(this.RFID == -1)
            {
                this.RFID = code;
                return true;
            }
            else
                return false;
        }
        ///<summary>
        ///sets the RFID_Code return -1 (meaning that the client left)
        ///</summary>
        public bool DeactiveRFID()
        {
            if(this.RFID != -1)
            {
                this.RFID = -1;
                return true;
            }
            return false;
        }
    }
}
