using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Motor : IMotor
    {
        protected string code;
        protected string name;
        protected double capacity;
        protected int num;
        
        public Motor()
        {
        }
        public Motor(string code, string name, double capacity, int num)
        {
            this.code = code;
            this.name = name;
            this.capacity = capacity;
            this.num = num;
        }

        
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        
        public override void inputInfor()
        {
            try
            {
                Console.Write("Nhập mã xe: ");
                code = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(code))
                    throw new Exception("Mã xe không được để trống!");

                Console.Write("Nhập tên loại xe: ");
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    throw new Exception("Tên xe không được để trống!");

                Console.Write("Nhập dung tích xi-lanh: ");
                if (!double.TryParse(Console.ReadLine(), out capacity) || capacity <= 0)
                    throw new Exception("Dung tích xi-lanh phải là số dương!");

                Console.Write("Nhập kiểu quyền lực (số): ");
                if (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
                    throw new Exception("Kiểu quyền lực phải là số nguyên dương!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi nhập liệu: {ex.Message}");
                throw;
            }
        }
        public override void displayInfor()
        {
            Console.WriteLine($"Mã xe: {code}");
            Console.WriteLine($"Tên xe: {name}");
            Console.WriteLine($"Dung tích xi-lanh: {capacity} cc");
            Console.WriteLine($"Kiểu quyền lực: {num} số");
        }
        public override void changeInfor()
        {
            try
            {
                Console.WriteLine("=== THAY ĐỔI THÔNG TIN XE ===");
                Console.Write("Nhập tên mới (Enter để giữ nguyên): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newName))
                    name = newName;

                Console.Write("Nhập dung tích xi-lanh mới (Enter để giữ nguyên): ");
                string capacityInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(capacityInput))
                {
                    if (!double.TryParse(capacityInput, out double newCapacity) || newCapacity <= 0)
                        throw new Exception("Dung tích xi-lanh phải là số dương!");
                    capacity = newCapacity;
                }

                Console.Write("Nhập kiểu quyền lực mới (Enter để giữ nguyên): ");
                string numInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(numInput))
                {
                    if (!int.TryParse(numInput, out int newNum) || newNum <= 0)
                        throw new Exception("Kiểu quyền lực phải là số nguyên dương!");
                    num = newNum;
                }

                Console.WriteLine("Thay đổi thông tin thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thay đổi thông tin: {ex.Message}");
                throw;
            }
        }
    }
}
