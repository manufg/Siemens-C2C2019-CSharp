using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRMSAPP.Entities;

namespace HRMSAPP.UserInterface
{
    class Program
    {
        static Employee Create()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Basic: ");
            decimal basic = decimal.Parse(Console.ReadLine());

            Console.Write("Da: ");
            decimal da = decimal.Parse(Console.ReadLine());

            Console.Write("Hra: ");
            decimal hra = decimal.Parse(Console.ReadLine());

            Employee employee = new Employee(name, id, basic, da, hra);
            return employee;
        }
        static void Main()
        {
            Employee employee = Create();
            Console.Write("Project Name: ");
            employee.ProjectName = Console.ReadLine();

            employee.CalculateSalary();
            Console.WriteLine($"Salary of { employee.Name} is {employee.TotalSalary}");
        }
    }
}
