using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nongeneric2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);
            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");
            arlist1.AddRange(arr); 
            arlist1.AddRange(myQ);
            arlist1.Remove(null); 
            arlist1.RemoveAt(4); 
            arlist1.RemoveRange(0, 2);
            for (int i = 0; i < arlist1.Count; i++) {
                Console.WriteLine(arlist1[i]);
            }
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); 
            numberNames.Add(2, "Two");
            numberNames.Add(7, "Three");
            numberNames.Add(4, "Three");
            numberNames.Add(5, "Three");
            /*Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(4, "four");
            dict.Add(6, "six");
            dict.Add(5, "five");*/

            Hashtable ht = new Hashtable(numberNames);
            ICollection aj = ht.Keys;
            foreach (int i in aj) {
                Console.WriteLine(i+","+ht[i]);
            }
        }
    }
}
