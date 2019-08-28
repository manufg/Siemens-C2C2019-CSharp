using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementation
{
    abstract class Person
    {
        string name;
        string subject;
        public Person()
        {

        }
        public Person(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
        }
        public string Name { get => name; set => name = value; }
        public string Subject { get => subject; set => subject = value; }

        public override string ToString()
        {
            return $"Name:{ name}, Subject: {subject}";
        }
        public abstract bool IsOutstanding();
    }
}
