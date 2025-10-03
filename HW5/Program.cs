using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.InputEncoding = System.Text.Encoding.UTF8;

                Yamaha yamahaSystem = new Yamaha();
                yamahaSystem.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khởi chạy chương trình: {ex.Message}");
                Console.WriteLine("Chi tiết lỗi: " + ex.StackTrace);
            }
        }
    }
}
