using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studiesc_
{
    internal class Person
    {
        private string name;
        private string address;
        private double salary;

        
        public Person(string name, string address, double salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        
        public static Person Nhap(string name, string address, string sSalary)
        {
            double salary = 0;

            
            if (string.IsNullOrWhiteSpace(sSalary))
            {
                throw new Exception("Bạn phải nhập lương.");
            }

            if (!double.TryParse(sSalary, out salary))
            {
                throw new Exception("Bạn phải nhập số.");
            }

            if (salary <= 0)
            {
                throw new Exception("Lương phải lớn hơn 0.");
            }

            return new Person(name, address, salary);
        }

        
        public static void HienThi(Person person)
        {
            Console.WriteLine($"Tên: {person.Name}");
            Console.WriteLine($"Địa chỉ: {person.Address}");
            Console.WriteLine($"Lương: {person.Salary:N0} VND");
            Console.WriteLine("---------------------------");
        }

        public static Person[] SortBySalary(Person[] persons)
        {
            if (persons == null || persons.Length == 0)
                return persons;

            for (int i = 0; i < persons.Length - 1; i++)
            {
                for (int j = 0; j < persons.Length - i - 1; j++)
                {
                    if (persons[j].Salary > persons[j + 1].Salary)
                    {
                        
                        Person temp = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = temp;
                    }
                }
            }
            return persons;
        }
    }
}
