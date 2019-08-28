using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementation
{
    class Student : Person
    {
        double marks;

        public Student()
        {

        }
        public Student(string name, string subject, double marks)
            : base(name, subject)
        {
            this.marks = marks;
        }

        public override bool IsOutstanding()
        {
            return this.marks >= 85 ? true : false;
        }
        public override string ToString()
        {
            return $"{base.ToString()} and Marks: {marks}";
        }
    }
}
