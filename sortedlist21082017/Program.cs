using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist21082017
{
    class Program
    {
        static void Main(string[] args)
        {
            //    SortedList sl = new SortedList();
            //    Console.WriteLine("Adding some numbers");

            //    sl.Add("001","Swathi");
            //    sl.Add("002", "Sooraj");
            //    sl.Add("003", "Biju");
            //    sl.Add("006", "ttt");
            //    sl.Add("004", "Lijo");

            //    if (sl.ContainsValue("Nuha Li"))
            //    {
            //        Console.WriteLine("Element is already present in sorted list");
            //    }
            //    else
            //    {
            //        sl.Add("005", "Nuha Li");
            //    }

            //   //get a collection of keys

            //    foreach(string k in sl.Keys)
            //    {
            //        Console.WriteLine(k + ":" + sl[k]);
            //    }
            //    sl.GetKeyList();
            //    foreach (string k in sl.Keys)
            //    {
            //        Console.WriteLine(k);
            //    }
            //    Console.WriteLine(sl.IndexOfValue("Nuha Li"));
            //    sl.Clear();
            //    foreach (string k in sl.Keys)
            //    {
            //        Console.WriteLine(k);
            //    }
            //    Console.ReadKey();

            //Stack st = new Stack();

            //st.Push('A');
            //st.Push('M');
            //st.Push('G');
            //st.Push('W');

            //Console.WriteLine("Current stack: ");
            //foreach (char s in st)
            //{
            //    Console.Write(s + " ");
            //}

            //Console.WriteLine();

            //st.Push('V');
            //st.Push('H');
            //st.Push('f');
            //Console.WriteLine("Current stack: ");
            //foreach (char s in st)
            //{
            //    Console.Write(s + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine("Removing values ");
            //st.Pop();
            //st.Pop();


            //Console.WriteLine("Current stack: ");
            //foreach (char s in st)
            //{
            //    Console.Write(s + " ");
            //}

            Queue que = new Queue();

            que.Enqueue('A');
            que.Enqueue('M');
            que.Enqueue('G');
            que.Enqueue('W');
            que.Enqueue('X');

            Console.WriteLine("Current queue: ");
            foreach (char c in que) Console.Write(c + " ");

            Console.WriteLine();
            que.Enqueue('V');
            que.Enqueue('H');
            Console.WriteLine("Current queue: ");
            foreach (char c in que)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            char ch=(char)que.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch=(char)que.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            Console.WriteLine("Modified queue: ");
            foreach (char c in que)
            {
                Console.Write(c + " ");
            }
            que.ToArray();
            Console.WriteLine();
            Console.WriteLine("Modified array: ");
            foreach (char c in que)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine(que.Count);
            Console.ReadKey();
        }
    }
    }

