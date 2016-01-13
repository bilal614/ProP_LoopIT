using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication11
{
    class Invoice
    {
        //instance variables
        private int id;//this is an ID for the invoices from food & drink sales and materials loaned 

        private DateTime date;

        private int accountId;
        //properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        //constructors
        public Invoice(int id, DateTime d, int actId)
        {
            this.Id = id;
            this.Date = d;
            this.AccountId = actId;
        }
        //methods


    }
}
