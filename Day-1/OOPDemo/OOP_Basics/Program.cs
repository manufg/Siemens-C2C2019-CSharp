using Entities;
using System;

namespace OOP_Basics
{
    class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("1. Student");
            Console.WriteLine("2. Trainer");
        }
        static int GetChoice()
        {
            Console.Write("\nEnter choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        static Person Create(int choice)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Person person = null;
            switch (choice)
            {
                case 1:
                    Console.Write("Id: ");
                    int studentId = int.Parse(Console.ReadLine());

                    Console.Write("Subject: ");
                    string studentSubject = Console.ReadLine();

                    Console.Write("Marks: ");
                    double studentMarks = double.Parse(Console.ReadLine());

                    person = new Student(marks: studentMarks, id: studentId, name: name, subject: studentSubject);
                    break;

                case 2:
                    Console.Write("Domain: ");
                    string trainerDomain = Console.ReadLine();
                    person = new Trainer(name, trainerDomain);
                    break;

                default:
                    break;
            }
            return person;
        }
        static void Main()
        {
            PrintMenu();
            int choice = GetChoice();
            Person person = Create(choice);
            string information = person.PrintInformation();

            //string information = null;
            //if (person is Student)
            //{
            //    //Student student = (Student)person;
            //    Student student = person as Student;
            //    information = student.PrintStudentInformation();
            //}
            //else if(person is Trainer)
            //{
            //    Trainer trainer = person as Trainer;
            //    information = trainer.PrintTrainerInformation();
            //}
            Console.WriteLine(information);
        }
    }
}
