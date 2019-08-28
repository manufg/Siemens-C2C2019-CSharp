using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInterfaces
{
    class Program
    {
        static void Main()
        {
            MyCollection<int> numbers = new MyCollection<int>();
            numbers.Add(12);
            numbers.Add(12);
            numbers.Add(12);
            numbers.Add(12);
            numbers.Add(12);

            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            IEnumerator<int> enumerator = numbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            numbers[1] = 13;
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            MyDictionary<int, int> entries = new MyDictionary<int, int>();
            entries.Add(1, 12);
            entries.Add(2, 13);
            foreach (Entry<int, int> item in entries)
            {
                Console.WriteLine(item.Key + "," + item.Value);
            }

            //Nullable<int> x = null;
            int? x = null;
            x = 10;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
        }
    }
}
