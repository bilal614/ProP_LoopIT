using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject.Classes
{
    class UserReport
    {
        public int UserID { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public decimal MoneySpent { get; set; }
        public decimal AvailableBalance { get; set; }
        public string LoanedMat { get; set; }

        public UserReport(int userID, string fName, string lName, decimal mSpent, decimal AvailBal, string LoanMat)
        {
            this.UserID = userID;
            this.FName = fName;
            this.LName = lName;
            this.MoneySpent = mSpent;
            this.AvailableBalance = AvailBal;
            this.LoanedMat = LoanMat;
        }


    }
}
