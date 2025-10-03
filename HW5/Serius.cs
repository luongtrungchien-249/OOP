using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Serius : Motor
    {
        private int warranty;

        public Serius() : base()
        {
        }

        public Serius(string code, string name, double capacity, int num, int warranty)
            : base(code, name, capacity, num)
        {
            this.warranty = warranty;
        }

        public int Warranty
        {
            get { return warranty; }
            set { warranty = value; }
        }

        public override void inputInfor()
        {
            try
            {
                base.inputInfor();

                Console.Write("Nhập thời gian bảo hành (tháng): ");
                if (!int.TryParse(Console.ReadLine(), out warranty) || warranty <= 0)
                    throw new Exception("Thời gian bảo hành phải là số nguyên dương!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi nhập thông tin Serius: {ex.Message}");
                throw;
            }
        }

        public override void displayInfor()
        {
            base.displayInfor();
            Console.WriteLine($"Thời gian bảo hành: {warranty} tháng");
        }

        public override void changeInfor()
        {
            try
            {
                base.changeInfor();

                Console.Write("Nhập thời gian bảo hành mới (Enter để giữ nguyên): ");
                string warrantyInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(warrantyInput))
                {
                    if (!int.TryParse(warrantyInput, out int newWarranty) || newWarranty <= 0)
                        throw new Exception("Thời gian bảo hành phải là số nguyên dương!");
                    warranty = newWarranty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thay đổi thông tin Serius: {ex.Message}");
                throw;
            }
        }
    }
}
