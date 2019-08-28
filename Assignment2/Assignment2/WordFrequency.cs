using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class WordFrequency
    {
        public static char[] GetSeparators(string sentence)
        {
            HashSet<char> separators = new HashSet<char>();
            foreach (char item in sentence)
            {
                if (!char.IsLetter(item) && !char.IsDigit(item))
                {
                    separators.Add(item);
                }
            }
            return separators.ToArray();
        }
        public SortedList<string, int> GetWordFrequency(string sentence)
        {
            SortedList<string, int> result = null;
            if (sentence != null && sentence != string.Empty)
            {
                result = new SortedList<string, int>();

                var separators = GetSeparators(sentence);
                string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (result.ContainsKey(word.ToLower()))
                    {
                        result[word.ToLower()] += 1;
                    }
                    else
                        result.Add(word.ToLower(), 1);
                }
            }
            return result;
        }
    }
}