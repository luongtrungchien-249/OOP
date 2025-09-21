using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class BillLine
    {
        private Item item;
        private int quantity;

        public BillLine(Item item, int quantity = 1)
        {
            this.item = item;
            this.quantity = quantity;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetItem(Item item)
        {
            this.item = item;
        }

        public Item GetItem()
        {
            return item;
        }

        public double GetLineTotal()
        {
            return item.GetPrice() * quantity;
        }

        public double GetLineDiscount()
        {
            return item.GetDiscount() * quantity;
        }

        public override string ToString()
        {
            return $"{quantity} x {item.Name} - ${GetLineTotal():F2}";
        }
    }
}
