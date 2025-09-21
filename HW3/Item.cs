using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public Item(string name, double price, double discount = 0.0)
        {
            Name = name;
            Price = price;
            Discount = discount;
        }

        public double GetPrice()
        {
            return Price;
        }

        public double GetDiscount()
        {
            return Discount;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price:F2} (Discount: ${Discount:F2})";
        }
    }
}
