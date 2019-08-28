using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRMSAPP.Entities;
using HRMSAPP.BusinessLayer;

namespace HRMSAPP.UserInterface
{
    class Program
    {
        static int GetRecordCount()
        {
            Console.Write("Enter Number of Records to Save: ");
            return int.Parse(Console.ReadLine());
        }

        static void PrintMenu()
        {
            Console.WriteLine("1. Developer");
            Console.WriteLine("2. Hr");
        }

        static int GetChoice()
        {
            Console.Write("\nEnter choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }

        static Employee Create(int choice)
        {
            Console.Write("\nName: ");
            string name = Console.ReadLine();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Basic: ");
            decimal basic = decimal.Parse(Console.ReadLine());

            Console.Write("Da: ");
            decimal da = decimal.Parse(Console.ReadLine());

            Console.Write("Hra: ");
            decimal hra = decimal.Parse(Console.ReadLine());

            Employee employee = null;
            switch (choice)
            {
                case 1:
                    Console.Write("Incentive: ");
                    decimal incentive = decimal.Parse(Console.ReadLine());
                    employee = new Developer(name, id, basic, da, hra, incentive, Designation.JuniorDeveloper);
                    break;

                case 2:
                    Console.Write("Gratuity: ");
                    decimal gratuity = decimal.Parse(Console.ReadLine());
                    employee = new Hr(name, id, basic, da, hra, gratuity, Designation.Hr);
                    break;

                default:
                    break;
            }
            return employee;
        }

        private static void PrintSalary(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    employee.CalculateSalary();
                    Console.WriteLine($"Salary of { employee.Name} is {employee.TotalSalary}");
                }
            }
        }

        static void Main()
        {
            //int recordCount = GetRecordCount();
            //Employee[] employees = new Employee[recordCount];

            //for (int i = 0; i < employees.Length; i++)
            //{
            PrintMenu();
            int choice = GetChoice();

            //Console.WriteLine($"\nRecord# {(i + 1)}");
            Employee employee = Create(choice);
            EmployeeBo bo = new EmployeeBo();
            bo.Insert(employee);
        }
    }
}
