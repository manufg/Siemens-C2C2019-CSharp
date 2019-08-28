using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClassMethods
{
    class Student
    {
        string name;
        int id;
        public Student()
        {

        }
        public Student(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Student)
                {
                    Student other = obj as Student;
                    if (this == other)
                        return true;
                    if (!this.id.Equals(other.id))
                        return false;
                    if (!this.name.Equals(other.name))
                        return false;
                    return true;
                }
                else
                {
                    ArgumentException ex = new ArgumentException($"argument of type {obj.GetType().Name} was passed instead of {this.GetType().Name}");
                    throw ex;
                }
            }
            else
            {
                NullReferenceException ex = new NullReferenceException($"null reference was passed to Equals method");
                throw ex;
            }
        }
        public override string ToString()
        {
            return $"Name: {this.name} and Id: {this.id}";
        }
    }
    class Program
    {
        static void Main()
        {
            //obejct initializer (C# - 3.0, .Net - 3.0, 2007)
            Student first = new Student { Name = "anil", Id = 1 };
            Student second = new Student { Name = "anil", Id = 1 };
            //Student second = first;

            try
            {
                bool state = first.Equals(second);
                if (state)
                    Console.WriteLine("same");
                else
                    Console.WriteLine("not");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine(first);
        }
    }
}
