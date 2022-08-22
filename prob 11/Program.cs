using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob_11
{
   class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "Delhi");
            //dic.Add(2, "Mumbai");
            //dic.Add(3, "Chennai");

            //foreach (KeyValuePair<int, string> item in dic)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);

            //}

            SortedList s1 = new SortedList();
            s1.Add(1, "Delhi");
            s1.Add(2, "Mumbai");
            s1.Add(3, "Chennai");
            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            Console.ReadKey();
        }
    }
}
