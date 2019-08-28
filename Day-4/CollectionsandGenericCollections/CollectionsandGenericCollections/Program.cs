using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsandGenericCollections
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (this == other)
                return true;

            if (!this.FirstName.Equals(other.FirstName))
                return false;

            if (!this.LastName.Equals(other.LastName))
                return false;

            return true;
        }
        public override int GetHashCode()
        {
            const int prime = 23;
            int hash = 0;
            hash = this.FirstName.GetHashCode() * prime;
            hash = this.LastName.GetHashCode() * hash;
            return hash;
        }
    }
    class Program
    {
        static void Main()
        {
            //UseArrayList();
            //UseList();
           
            //UseHashTable();
            //UseDictionary();
            
            //UseSortedList();
            UseGenericSortedList();

            //UseSet();
        }

        private static void UseGenericSortedList()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(1, "siemens");
            sortedList.Add(0, "ecity");
            sortedList.Add(2, "bangalore");
            foreach (KeyValuePair<int, string> item in sortedList)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }

        private static void UseDictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "siemens");
            dictionary.Add(0, "ecity");
            dictionary.Add(2, "bangalore");
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

        }

        private static void UseSortedList()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "siemens");
            sortedList.Add(0, 12);
            sortedList.Add(3, 12.34);
            sortedList[2] = 13;
            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine($"{entry.Key}:{entry.Value}");
            }
        }

        private static void UseHashTable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("k1", 12);
            hashtable.Add(0, "siemens");
            hashtable.Add('a', 12.34);
            //object val = hashtable["k1"];
            //val = 13;
            //hashtable["k1"] = val;
            hashtable["k1"] = 13;
            //hashtable.Add("k1", 19);
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}:{entry.Value}");
            }
        }

        private static void UseSet()
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(12);
            set.Add(13);
            set.Add(12);
            //set.Remove(13);
            foreach (int item in set)
            {
                Console.WriteLine(item);
            }

            HashSet<Person> people = new HashSet<Person>();
            Person first = new Person { FirstName = "anil", LastName = "gupta" };
            Person second = new Person { FirstName = "anil", LastName = "gupta" };
            //Person second = first;

            people.Add(first);
            people.Add(second);
            foreach (Person item in people)
            {
                Console.WriteLine(item.FirstName + ", " + item.LastName);
            }
        }

        private static void UseList()
        {
            List<int> list = new List<int>();
            list.Add(12);
            list.Add('a');
            list.Add(34);
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            list.Remove(34);
            list.RemoveAt(1);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void UseArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(12);            //0
            arrayList.Add(12.34);           //1-->2
            arrayList.Add("siemens");   //2-->3
            arrayList.Add(12.34);       //3-->4
            arrayList.Insert(1, 12.34); //4-->1

            Console.WriteLine($"Capacity:{ arrayList.Capacity} and Count:{arrayList.Count}");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            arrayList.Remove(12.34);
            arrayList.RemoveAt(3);
            Console.WriteLine("\nafter deletion\n");
            foreach (object item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
