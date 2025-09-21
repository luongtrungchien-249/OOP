using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class GroceryBill
    {
        protected Employee clerk;
        protected List<BillLine> billLines;

        public GroceryBill(Employee clerk)
        {
            this.clerk = clerk;
            billLines = new List<BillLine>();
        }

        public virtual void Add(BillLine billLine)
        {
            billLines.Add(billLine);
        }

        public virtual double GetTotal()
        {
            double total = 0;
            foreach (BillLine line in billLines)
            {
                total += line.GetLineTotal();
            }
            return total;
        }

        public virtual void PrintReceipt()
        {
            Console.WriteLine($"Receipt for {clerk.Name}:");
            Console.WriteLine();
            foreach (BillLine line in billLines)
            {
                Console.WriteLine($"- {line}");
            }
            Console.WriteLine();
            Console.WriteLine($"Total: ${GetTotal():F2}");
        }
    }
}
