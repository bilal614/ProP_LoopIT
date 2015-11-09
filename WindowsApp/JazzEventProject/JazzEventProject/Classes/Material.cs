using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject.Classes
{
    class Material : Items
    {
        decimal DepositAmount { get; set; }
        string Desription { get; set; }

        public Material(int id, string name, decimal price, int quantity, decimal depositAmount, string description )
            :base (id,name,price,quantity)
        {
            this.DepositAmount = depositAmount;
            this.Desription = description;
        }
    }
}
