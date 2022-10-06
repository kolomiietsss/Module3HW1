using System;
using System.Collections.Generic;

// using System.Collections.Generic;
namespace Module3HW1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mylist = new MyList<int>();
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            Console.WriteLine(mylist.Count); // 3
            var mylist3 = new int[] { 4, 5, 6 };
            mylist.AddRange(mylist3);
            var list = new List<int>() { 7, 8, 9 };
            mylist.AddRange(list);
            Console.WriteLine(mylist.Count); // 9
            Console.WriteLine("-------------------------");
            var b = mylist.RemoveAt(0); // T
            Console.WriteLine(b);
            var r = mylist.Remove(2); // T
            Console.WriteLine(r);
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
