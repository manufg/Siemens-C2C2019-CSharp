using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementation
{
    class Professor : Person
    {
        int booksPublished;
        public Professor()
        {

        }
        public Professor(string name, string subject, int books)
            : base(name, subject)
        {
            this.booksPublished = books;
        }
        public override bool IsOutstanding()
        {
            return this.booksPublished >= 5 ? true : false;
        }
        public override string ToString()
        {
            return $"{ base.ToString()} and Books Published: {booksPublished}";
        }
    }
}
