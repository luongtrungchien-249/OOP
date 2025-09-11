static void Main(string[] args)
{
    Console.InputEncoding = Encoding.UTF8;
    Console.OutputEncoding = Encoding.UTF8;

    Console.WriteLine(" QUẢN LÝ THÔNG TIN PERSON ");

    int n;
    
    while (true)
    {
        Console.Write("Nhập số lượng Person: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out n) && n > 0)
        {
            break;
        }
        Console.WriteLine("Số lượng phải là số nguyên dương! Vui lòng nhập lại.");
    }

    Person[] persons = new Person[n];

    
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"\n=== NHẬP THÔNG TIN NGƯỜI THỨ {i + 1}/{n} ===");

        Console.Write("Vui lòng nhập tên: ");
        string name = Console.ReadLine();

        Console.Write("Vui lòng nhập địa chỉ: ");
        string address = Console.ReadLine();

        
        bool validSalary = false;
        while (!validSalary)
        {
            Console.Write("Vui lòng nhập lương: ");
            string salaryInput = Console.ReadLine();

            try
            {
                persons[i] = Person.Nhap(name, address, salaryInput);
                validSalary = true;
                Console.WriteLine(" Nhập thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" {ex.Message}");
            }
        }

        
        Console.WriteLine("\nThông tin vừa nhập:");
        Person.HienThi(persons[i]);
    }

    
    Console.WriteLine("\n" + new string('=', 50));
    Console.WriteLine("DANH SÁCH TẤT CẢ NGƯỜI");
    Console.WriteLine(new string('=', 50));

    for (int i = 0; i < persons.Length; i++)
    {
        Console.WriteLine($"Người thứ {i + 1}:");
        Person.HienThi(persons[i]);
    }

    
    persons = Person.SortBySalary(persons);

    
    Console.WriteLine("\n" + new string('=', 50));
    Console.WriteLine("DANH SÁCH SAU KHI SẮP XẾP THEO LƯƠNG (TĂNG DẦN)");
    Console.WriteLine(new string('=', 50));

    for (int i = 0; i < persons.Length; i++)
    {
        Console.WriteLine($"Thứ hạng {i + 1}:");
        Person.HienThi(persons[i]);
    }

    Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
    Console.ReadKey();
}
