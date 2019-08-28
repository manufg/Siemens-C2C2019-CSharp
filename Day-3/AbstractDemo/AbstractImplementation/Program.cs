using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementation
{
    class Program
    {
        static int GetRecordCount()
        {
            Console.Write("how many records? ");
            return int.Parse(Console.ReadLine());
        }
        static void PrintMenu()
        {
            Console.WriteLine("\n1. Student");
            Console.WriteLine("2. Professor");
        }
        static int GetChoice()
        {
            Console.Write("\nEnter Choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        static Person CreatePerson(int choice)
        {
            Console.Write("\nName: ");
            string name = Console.ReadLine();

            Console.Write("Subject: ");
            string subject = Console.ReadLine();

            Person person = null;
            switch (choice)
            {
                case 1:
                    Console.Write("Marks: ");
                    double marks = double.Parse(Console.ReadLine());
                    person = new Student(name, subject, marks);
                    break;

                case 2:
                    Console.Write("Books Published: ");
                    int booksCount = int.Parse(Console.ReadLine());
                    person = new Professor(name, subject, booksCount);
                    break;

                default:
                    break;
            }
            return person;
        }
        //static void CreateStorage(ref Person[] people, int recordCount)
        static void CreateStorage(out Person[] people, int recordCount)
        {
            people = new Person[recordCount];
        }
        static void AddPerson(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                PrintMenu();
                int choice = GetChoice();
                Person person = CreatePerson(choice);
                people[i] = person;
            }
        }
        static void PrintOutstandingPerson(Person[] people)
        {
            foreach (Person person in people)
            {
                if (person != null)
                    if (person.IsOutstanding())
                        Console.WriteLine(person);
                //Console.WriteLine(person.ToString());
            }
        }
        static void Main()
        {
            int recordCount = GetRecordCount();

            //pass by reference: need to assign value to local variable, and the called function can assign a new value
            //Person[] people = null;
            //CreateStorage(ref people, recordCount);

            //pass by out: no need to assign value to local variable, but the called function must assign the value
            Person[] people;
            CreateStorage(out people, recordCount);

            AddPerson(people);
            PrintOutstandingPerson(people);
        }
    }
}
