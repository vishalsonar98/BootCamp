using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace collection_generics
{
    class program
    {
        static void Main(string[] args)
        {
            //non-generic collection
            ArrayList arrl = new ArrayList();
            Queue q = new Queue();
            Stack s = new Stack();

            arrl.Add("vishal");
            arrl.Add(10);

            foreach (Object o in arrl)
            {
                Console.WriteLine(o);
            }

            q.Enqueue("vishal");
            q.Enqueue(100);

            foreach (Object o in q)
            {
                Console.WriteLine(o);
            }

            s.Push(100);
            foreach(Object o in s)
            {
                Console.WriteLine(o);
            }

            //generic collection
            List<Int32> IntegerGenericExm = new List<Int32>();
            IntegerGenericExm.Add(10);
            IntegerGenericExm.AddRange(new int[] { 20, 30, 40, 50 });

            foreach (int I in IntegerGenericExm)
            {
                Console.WriteLine(I);
            }

            Console.ReadKey();
        }
    }
}
