using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1); 
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);
            numbers.RemoveAt(3);
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");
            numberNames.Remove(5);
            if (numberNames.ContainsKey(4))
            {
                numberNames[4] = "four";
            }
            foreach (var kvp in numberNames)
                Console.WriteLine( kvp.Key+","+ kvp.Value);
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Pop();

            foreach (var item in myStack)
                Console.Write(item + ",");
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            for (int i = 0; i < callerIds.Count; i++) {
                Console.WriteLine(callerIds.Dequeue());
            }
            Dictionary<int, string> numberName = new Dictionary<int, string>();
            numberName.Add(1, "One"); 
            numberName.Add(2, "Two");
            numberName.Add(3, "Three");
            if (numberName.ContainsKey(3))
            {
                numberName[3] = "four";
            }
            if (numberName.ContainsKey(2))
            { 
                numberName.Remove(2);
            }
        }
    }
}
