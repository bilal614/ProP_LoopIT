using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject.Classes
{
    class MaterialInvoice : Invoice
    {
        public DateTime EndDate { get; set; }

        ///<summary>
        ///Constructor 
        ///</summary>
        public MaterialInvoice(int id, int accountID, DateTime startDate, DateTime endDate)
        :base(id,startDate,accountID)
        {
            this.EndDate = endDate;
        }
    }
}
