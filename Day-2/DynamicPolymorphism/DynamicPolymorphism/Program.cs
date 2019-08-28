using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class A
    {
        public virtual void Test()
        {
            Console.WriteLine("A test");
        }
    }
    class B:A
    {
        public override void Test()
        {
            Console.WriteLine("B test");
        }
    }
    class C:B
    {
        public override void Test()
        {
            Console.WriteLine("C test");
        }
    }
    class Program
    {
        static void Main()
        {
            A ob = new C();
            ob.Test();
        }
    }
}
