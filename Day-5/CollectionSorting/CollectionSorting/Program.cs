using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSorting
{
    class Program
    {
        static Employee Create()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            return new Employee(id, name, salary);
        }
        static List<Employee> CreateRepository()
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 3; i++)
            {
                employees.Add(Create());
            }
            return employees;
        }
        static void SortEmployees(List<Employee> employees)
        {
            PrintSortMenu();
            GetChoice(out int choice);

            //following call expects Employee class has implemented IComparable/IComparable<T> and implemented CompareTo method
            //employees.Sort();

            //following call expects EmployeeCompraison class has implemented IComparer/IComparer<T> and implemented Compare method
            EmployeeComparison employeeComparison = new EmployeeComparison(choice);
            employees.Sort(employeeComparison);
            /*
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    //if (employees[i].CompareTo(employees[j])>0)
                    if (employeeComparison.Compare(employees[i],employees[j])>0)
                    {
                        Employee temp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = temp;
                    }
                }
            }
            */
        }

        private static void GetChoice(out int choice)
        {
            Console.Write("\nEnter choice[1/2]: ");
            choice = int.Parse(Console.ReadLine());
        }

        private static void PrintSortMenu()
        {
            Console.WriteLine("\n1. sort by id");
            Console.WriteLine("2. sort by name");
            Console.WriteLine("3. sort by salary");
        }

        static void Main()
        {
            List<Employee> employees = CreateRepository();
            SortEmployees(employees);
            PrintEmployees(employees);

            //List<int> numbers = new List<int> { 0, 1, 4, 3, 6, 7, 5, 9, 0, 8, 2 };
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    for (int j = i + 1; j < numbers.Count; j++)
            //    {
            //        if (numbers[i].CompareTo(numbers[j]) > 0)
            //        {

            //        }
            //    }
            //}
        }

        private static void PrintEmployees(List<Employee> employees)
        {
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
