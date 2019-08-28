using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student : Person
    {
        int id;
        string subject;
        double marks;

        public Student() { }

        //optional argument with default value (4.0/2010)
        public Student(string name, int id, string subject,
            double marks = 0) : base(name)
        {
            //this.name = name;
            this.id = id;
            this.marks = marks;
            this.subject = subject;
        }

        public int Id { get => id; set => id = value; }
        public string Subject { get => subject; set => subject = value; }
        public double Marks { get => marks; set => marks = value; }

        public override string PrintInformation()
        {
            //return "Name: " + name + " Subject: " + subject + " Marks: " + marks;

            //string templates (interpolation)
            return $"Name: {base.PrintInformation()}, Subject: {this.subject}, Marks: { marks} and Id: {id} and Result: { (marks >= 40 ? "passed" : "failed") }";
        }
    }
}
