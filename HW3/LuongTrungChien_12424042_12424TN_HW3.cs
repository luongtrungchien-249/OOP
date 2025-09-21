using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo nhân viên
            Employee clerk = new Employee("Jane Doe");

            // Tạo các items
            Item milk = new Item("Milk", 2.50, 0.20);
            Item bread = new Item("Bread", 1.80);
            Item eggs = new Item("Eggs", 3.00, 0.50);

            Console.WriteLine("EXTENDED VERSION WITH BILLLINES");

            // Tạo bill lines
            BillLine milkLine = new BillLine(milk, 2);
            BillLine breadLine = new BillLine(bread, 1);
            BillLine eggsLine = new BillLine(eggs, 3);

            Console.WriteLine("\ PREFERRED CUSTOMER WITH QUANTITY");
            DiscountBill extendedBill = new DiscountBill(clerk, true);
            extendedBill.Add(milkLine);
            extendedBill.Add(breadLine);
            extendedBill.Add(eggsLine);
            extendedBill.PrintReceipt();

            Console.WriteLine(" DISCOUNT INFORMATION");
            Console.WriteLine($"Discount count: {extendedBill.GetDiscountCount()}");
            Console.WriteLine($"Discount amount: ${extendedBill.GetDiscountAmount():F2}");
            Console.WriteLine($"Discount percent: {extendedBill.GetDiscountPercent():F2}%");
        }
    }
}

