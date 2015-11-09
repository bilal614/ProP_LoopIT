using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject
{
    class Items
    {
        //Properties
        public int ID { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        ///<Summary>
        ///Constructor
        ///</Summary>
        public Items(int id, string name, decimal price, int quantity)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity; 
        }

    }
}
