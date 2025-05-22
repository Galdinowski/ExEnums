using System;
using System.Globalization;

using Menu.Entities;
using Menu.Entities.Enums;
namespace Menu
{
    class Program{

        static void Main(string[] agrs)
        {
            Console.WriteLine("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("---------Enter Worker data below--------- ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior) ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
             
             Departament dept = new Departament(deptName);
             Worker worker = new Worker(name,level,baseSalary,dept);

              Console.WriteLine($"How many contract for {worker.Name}?: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (MM/DD/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                 Console.WriteLine($"Value per hour: ");
                double valuePerHours = int.Parse(Console.ReadLine());
                 Console.WriteLine($"Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract (date,valuePerHours,hour);
                worker.AddContract(contract);

            }

            Console.WriteLine("Enter MONTH and Year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($" Name: {worker.Name}");
            Console.WriteLine($" Departament: {worker.Departament.Name}");
            Console.WriteLine($"Income for: ({monthAndYear}) is {worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture)}");



            
           
        }

    }
}