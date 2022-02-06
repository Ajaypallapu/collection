using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace speccollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hybrid Dictionary ");
            HybridDictionary aj = new HybridDictionary(14, false);
            aj.Add(1, "ajay");
            aj.Add(2, "nani");
            aj.Add(3, "babu");
            aj.Add(4, "pallapu");
            foreach (DictionaryEntry a in aj)
            {
                Console.WriteLine(a.Key + " " + a.Value);
            }
            Console.WriteLine(aj.IsFixedSize);
            Console.WriteLine(aj.Count);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("List Dictionary");
            ListDictionary ay = new ListDictionary();
            ay.Add(1,10);
            ay.Add(2, null);
            foreach (DictionaryEntry a in ay)
            {
                Console.WriteLine(a.Key + " " + a.Value);
            }
            Console.WriteLine(ay.IsSynchronized);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("name value collaction ");
            NameValueCollection ak = new NameValueCollection();
            ak.Add("ajay" , "100");
            ak.Add("ajay", "10");

            ak.Add("ajay", "30");

            ak.Add("ajay", "50");
            ak.Add("nani","60");
            for (int i = 0; i < ak.Count; i++) {
                Console.WriteLine(ak.GetKey(i)+" "+ak.Get(i));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ordered dictionary ");
            OrderedDictionary an = new OrderedDictionary();
            an.Add(1 , "ajay");
            an.Add(3,"nani");
            an.Add(9, "babu");
            an.Add(7,"virat");
            foreach (DictionaryEntry ab in an) {
                Console.WriteLine(ab.Key + " " + ab.Value);
            }
            an.Remove(9);
            foreach (DictionaryEntry ab in an)
            {
                Console.WriteLine(ab.Key + " " + ab.Value);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("String Collection");
            StringCollection av = new StringCollection();
            av.Add("Gayle");
            av.Add("Chris");
            String[] am = {"Chris", "toper","hendry","chris","Gayle" };
            av.AddRange(am);
            foreach (String i in av) {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("String Dictinary");
            StringDictionary na = new StringDictionary();
            na.Add("A","ajay");
            na.Add("B", "babu");
            na.Add("c","chari");
            na.Add("D","Danny");
            foreach (DictionaryEntry ob in na) {
                Console.WriteLine(ob.Key+"for"+ ob.Value);
            }


        }
    }
}
