using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject
{
    class Invoice_Items
    {
        //Properties
        public int Invoice_Id { get; set; }
        public int Item_Id { get; set; }
        public int Quantity { get; set; }

        ///<summary>
        ///Constructors
        ///</summary>
        public Invoice_Items(int invoice_id, int item_id, int quantity)
        {
            this.Invoice_Id = invoice_id;
            this.Item_Id = item_id;
            this.Quantity = quantity;
        }
    }
}
