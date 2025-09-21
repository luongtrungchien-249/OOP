using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class DiscountBill : GroceryBill
    {
        private bool preferred;
        private double totalDiscount;
        private int discountCount;

        public DiscountBill(Employee clerk, bool preferred) : base(clerk)
        {
            this.preferred = preferred;
            totalDiscount = 0;
            discountCount = 0;
        }

        public override void Add(BillLine billLine)
        {
            base.Add(billLine);
            if (preferred && billLine.GetItem().GetDiscount() > 0)
            {
                totalDiscount += billLine.GetLineDiscount();
                discountCount++;
            }
        }

        public override double GetTotal()
        {
            if (preferred)
            {
                return base.GetTotal() - totalDiscount;
            }
            return base.GetTotal();
        }

        public int GetDiscountCount()
        {
            return preferred ? discountCount : 0;
        }

        public double GetDiscountAmount()
        {
            return preferred ? totalDiscount : 0.0;
        }

        public double GetDiscountPercent()
        {
            if (!preferred || base.GetTotal() == 0)
                return 0.0;

            return (totalDiscount / base.GetTotal()) * 100;
        }

        public override void PrintReceipt()
        {
            Console.WriteLine($"Receipt for {clerk.Name} ({(preferred ? "Preferred" : "Regular")} Customer):");
            Console.WriteLine();
            foreach (BillLine line in billLines)
            {
                double finalPrice = preferred ?
                    line.GetLineTotal() - line.GetLineDiscount() :
                    line.GetLineTotal();

                Console.WriteLine($"- {line.GetQuantity()} x {line.GetItem().Name}: ${finalPrice:F2}" +
                                (preferred && line.GetItem().GetDiscount() > 0 ?
                                $" (Discount: -${line.GetLineDiscount():F2})" : ""));
            }
            Console.WriteLine();
            Console.WriteLine($"Subtotal: ${base.GetTotal():F2}");
            if (preferred)
            {
                Console.WriteLine($"Discount: -${totalDiscount:F2}");
            }
            Console.WriteLine($"Total: ${GetTotal():F2}");
            if (preferred)
            {
                Console.WriteLine($"Items discounted: {discountCount}");
                Console.WriteLine($"Discount percentage: {GetDiscountPercent():F2}%");
            }
        }
    }
}
