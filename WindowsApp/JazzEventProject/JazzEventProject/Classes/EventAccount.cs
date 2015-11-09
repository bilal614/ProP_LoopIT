using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject_V1.Classes
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
    }
}
