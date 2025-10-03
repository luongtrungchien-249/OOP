using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Yamaha
    {
        private List<Motor> motors;

        public Yamaha()
        {
            motors = new List<Motor>();
        }

        public void Run()
        {
            try
            {
                while (true)
                {
                    Console.Clear();
                    DisplayMenu();
                    Console.Write("Chọn chức năng: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            InputMotors();
                            break;
                        case "2":
                            DisplayAllMotors();
                            break;
                        case "3":
                            SortByWarranty();
                            break;
                        case "4":
                            SearchSerius();
                            break;
                        case "5":
                            Console.WriteLine("Thoát chương trình!");
                            return;
                        default:
                            Console.WriteLine("Chức năng không hợp lệ! Vui lòng chọn lại.");
                            break;
                    }

                    Console.WriteLine("Nhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi hệ thống: {ex.Message}");
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine(" HỆ THỐNG QUẢN LÝ PHÂN PHỐI XE MÁY YAMAHA ");
            Console.WriteLine("1. Nhập thông tin xe");
            Console.WriteLine("2. Hiển thị thông tin xe");
            Console.WriteLine("3. Sắp xếp theo thời gian bảo hành");
            Console.WriteLine("4. Tìm kiếm xe Serius");
            Console.WriteLine("5. Thoát");
        }

        private void InputMotors()
        {
            try
            {
                Console.WriteLine(" NHẬP THÔNG TIN XE ");

                // Input 3 Jupiter
                Console.WriteLine("NHẬP THÔNG TIN 3 XE JUPITER:");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"\nNhập thông tin Jupiter thứ {i + 1}:");
                    Jupiter jupiter = new Jupiter();
                    jupiter.inputInfor();
                    motors.Add(jupiter);
                }

                // Input 3 Serius
                Console.WriteLine("\nNHẬP THÔNG TIN 3 XE SERIUS:");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"\nNhập thông tin Serius thứ {i + 1}:");
                    Serius serius = new Serius();
                    serius.inputInfor();
                    motors.Add(serius);
                }

                Console.WriteLine("Đã nhập thành công 3 xe Jupiter và 3 xe Serius!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi nhập thông tin xe: {ex.Message}");
            }
        }

        private void DisplayAllMotors()
        {
            try
            {
                if (motors.Count == 0)
                {
                    Console.WriteLine("Chưa có thông tin xe nào trong hệ thống!");
                    return;
                }

                Console.WriteLine("DANH SÁCH TẤT CẢ XE");

                var jupiters = motors.OfType<Jupiter>();
                if (jupiters.Any())
                {
                    Console.WriteLine("\n DANH SÁCH XE JUPITER ");
                    foreach (var jupiter in jupiters)
                    {
                        jupiter.displayInfor();
                    }
                }

                var seriusList = motors.OfType<Serius>();
                if (seriusList.Any())
                {
                    Console.WriteLine("\nDANH SÁCH XE SERIUS");
                    foreach (var serius in seriusList)
                    {
                        serius.displayInfor();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi hiển thị thông tin: {ex.Message}");
            }
        }

        private void SortByWarranty()
        {
            try
            {
                if (motors.Count == 0)
                {
                    Console.WriteLine("Chưa có thông tin xe nào trong hệ thống!");
                    return;
                }

                Console.WriteLine("SẮP XẾP THEO THỜI GIAN BẢO HÀNH");

                // Display before sorting
                Console.WriteLine("\n TRƯỚC KHI SẮP XẾP");
                DisplayAllMotors();

                // Sort by warranty
                var sortedMotors = motors.OrderBy(m =>
                {
                    if (m is Jupiter j) return j.Warranty;
                    if (m is Serius s) return s.Warranty;
                    return 0;
                }).ToList();

                motors = sortedMotors;

                // Display after sorting
                Console.WriteLine("\nSAU KHI SẮP XẾP");
                DisplayAllMotors();

                Console.WriteLine("Đã sắp xếp thành công theo thời gian bảo hành!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi sắp xếp: {ex.Message}");
            }
        }

        private void SearchSerius()
        {
            try
            {
                if (motors.Count == 0)
                {
                    Console.WriteLine("Chưa có thông tin xe nào trong hệ thống!");
                    return;
                }

                Console.WriteLine("TÌM KIẾM XE SERIUS");

                var seriusList = motors.OfType<Serius>();

                if (!seriusList.Any())
                {
                    Console.WriteLine("Không tìm thấy xe Serius nào trong hệ thống!");
                    return;
                }

                // Display before sorting
                Console.WriteLine("\nDANH SÁCH XE SERIUS (TRƯỚC KHI SẮP XẾP)");
                foreach (var serius in seriusList)
                {
                    serius.displayInfor();
                }

                // Sort by warranty and display again
                var sortedSerius = seriusList.OrderBy(s => s.Warranty);

                Console.WriteLine("\nDANH SÁCH XE SERIUS (SAU KHI SẮP XẾP THEO BẢO HÀNH)");
                foreach (var serius in sortedSerius)
                {
                    serius.displayInfor();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm: {ex.Message}");
            }
        }
    }
}
