using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication11
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

        public string ToString()
        {
            return Item_Id + "\t" + Quantity + "\t" + ReturnStatus;
        }
    }
}
