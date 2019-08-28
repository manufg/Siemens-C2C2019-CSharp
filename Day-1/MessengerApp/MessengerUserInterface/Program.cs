using MessengerLibrary;
using System;

namespace MessengerUserInterface
{
    class Program
    {
        static void Main()
        {
            //extract type object reference
            //1. Thorough type name
            Type type = typeof(Messenger);

            Messenger messenger = new Messenger();

            //2. through reference variable
            Type t = messenger.GetType();

            if (t == type)
                Console.WriteLine("same");

            Console.WriteLine($"Name: {t.Name}");
            Console.WriteLine($"Is abstract: {t.IsAbstract}");
            Console.WriteLine($"Is sealed: {t.IsSealed}");
            Console.WriteLine($"Fully Qualified Name: {t.FullName}");

            string message =
                messenger.DeliverMessage("joydip");
            Console.WriteLine(message);
        }
    }
}
