using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication11
{
    class Material : Items
    {
        public decimal DepositAmount { get; set; }
        public string Description { get; set; }

        public Material(int id, string name, decimal price, int quantity, decimal depositAmount, string description )
            :base (id,name,price,quantity)
        {
            this.DepositAmount = depositAmount;
            this.Description = description;
        }
    }
}
