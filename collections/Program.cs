using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collections
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //stringlistdemo();
            // sortedlistdemo();
            // queuedemo();
            //stackdemo();
            //Hashtabledemo();
          //  arraylistdemo();

            

        }

        //we can instantiate before or after static void main
        // ArrayList alist = new ArrayList();
        private static void arraylistdemo()
        {
            ArrayList al = new ArrayList()
               { "chinni","munni","honey","minu"};
            foreach (string a in al)
            {
                Console.WriteLine(a);

            }
            al.Add("pinky");
            Console.WriteLine();
            string[] r = new string[] { "cat", "mat" };
            al.SetRange(2, r);
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            al.RemoveRange(2, 2);
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Add("supraja");
            Console.WriteLine();
            al.Sort();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
        }

        private static void stringlistdemo()
        {
            List<string> stlst = new List<string>();
            stlst.Add("Programming Languages:");
            stlst.Add("c");
            stlst.Add("java");
            stlst.Add("python");
            foreach (string i in stlst)
            {
                Console.WriteLine(i);
            }
            stlst.Insert(2, "r");
            foreach (string p in stlst)
            {
                Console.WriteLine(p);
            }
        }

        private static void sortedlistdemo()
        {
            SortedList slist = new SortedList(); //sorting will be done based on keys
            slist.Add("zameer", 234);
            slist.Add("arun", 123);
            slist.Add("sameera", 897);
            slist.Add("harsha", 942);
            foreach (string k in slist.Keys)
            {
                Console.WriteLine(k);
            }
            foreach (int v in slist.Values)
            {
                Console.WriteLine(v);
            }
        }

        private static void queuedemo()
        {
            Queue q = new Queue();
            q.Enqueue(123);
            q.Enqueue(980);
            q.Enqueue(675);
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            q.Dequeue();
            q.Dequeue();
            foreach (int j in q)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();
        }

        private static void stackdemo()
        {
            Stack stk = new Stack(); //it will display in reverse order bcoz of stack
            stk.Push("chocolate");
            stk.Push("biscuit");
            stk.Push("Cake");
            foreach (String s in stk)
            {
                Console.WriteLine(s);

            }
            stk.Pop();
            Console.WriteLine();
            foreach (String a in stk)
            {
                Console.WriteLine(a);

            }
            stk.Push("chocolate");
        }

        private static void Hashtabledemo()
        {
            Hashtable hst = new Hashtable();
            hst.Add("raju", "1234");
            hst.Add("srinu", "5674");
            hst.Add("krishna", "4378");
            foreach (string k in hst.Keys)   //it will print keys
            {
                Console.WriteLine(k);
            }
            foreach (string h in hst.Values)   //it will print values
            {
                Console.WriteLine(h);
            }
            hst.Remove("karan");
            foreach (ICollection i in hst.Values)
            {
                Console.WriteLine(i);
            }
        }
    }
}
