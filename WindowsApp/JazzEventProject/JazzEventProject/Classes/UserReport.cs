using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject.Classes
{
    class UserReport
    {
        
        public int UserID { get; set; }

        [DisplayName("First Name")]
        public String FName { get; set; }

        [DisplayName("Last Name")]
        public String LName { get; set; }
        public decimal MoneySpent { get; set; }

        [DisplayName("Available Balance")]
        public decimal AvailableBalance { get; set; }

        [DisplayName("Phone Number")]
        public int Phone { get; set; }
        public string LoanedMat { get; set; }

        public UserReport(int userID, string fName, string lName, decimal mSpent, decimal AvailBal, int phone, string LoanMat)
        {
            this.UserID = userID;
            this.FName = fName;
            this.LName = lName;
            this.MoneySpent = mSpent;
            this.AvailableBalance = AvailBal;
            this.Phone = phone;
            this.LoanedMat = LoanMat;
        }


    }
}
