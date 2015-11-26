using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject.Classes
{
    class Material_Invoice_Items : Invoice_Items
    {
        public DateTime ReturnDate { get; set; }
        public bool ReturnStatus { get; set; }

        public Material_Invoice_Items( int quantity, int materialId, int invoiceID, DateTime returnDate, bool returnStatus)
            :base(invoiceID,materialId,quantity)
        {
            this.ReturnDate = returnDate;
            this.ReturnStatus = returnStatus;
        }
    }
}
