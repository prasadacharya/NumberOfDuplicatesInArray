

using System;
using System.Collections.Generic;

namespace NumberOfDuplicatesInArray
{
    class Program
    {

        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };

            int result = CountNonUnique(a);
            Console.WriteLine(result);
        }
        static int CountNonUnique(int[] numbers)
        {



            Dictionary<int, int> dict = new Dictionary<int, int>();


            foreach (int i in numbers)

                if (dict.ContainsKey(i))
                {
                    dict[i]++;



                }
                else
                {
                    dict.Add(i, 1);
                }

            int CountNonUnique = 0;
            foreach (KeyValuePair<int, int> kvp in dict)
            {
                if (kvp.Value > 1)

                    CountNonUnique++;

            }

            return CountNonUnique;
        }


    }
}
