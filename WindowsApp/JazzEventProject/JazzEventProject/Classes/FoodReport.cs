using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject.Classes
{
    class FoodReport
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int AmountSold { get; set; }
        public int AmountAvailable { get; set; }

        public FoodReport(int foodID, string foodname, int sold, int available)
        {
            this.FoodName = foodname;
            this.FoodID = foodID;
            this.AmountSold = sold;
            this.AmountAvailable = available;
        }
    }
}
