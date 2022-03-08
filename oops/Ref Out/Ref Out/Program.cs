using System;

namespace Ref_Out
{
    class program
    {
        static void example1(ref int value)
        {
            value = 1;
        }
        static void example2(out int value)
        {
            value = 2;
        }

        static void example3(int value)
        {
            Console.WriteLine(value);
            value = 3;
            Console.WriteLine(value);   
        }

        static void Main(string[] vs)
        {
            int val1 = 10;
            int val2 = 20;

            program.example1(ref val1);
            Console.WriteLine(val1);

            program.example2(out val2);
            Console.WriteLine(val2);

            int a = 30;
            example3(a);
            Console.WriteLine(a);
            var v = 10;
            v = 20;
            Console.WriteLine(v);

            var v2 = "vishal";
            v2 = "sonar";
            Console.WriteLine(v2);

            Object O1 = 10;
            O1 = "Jeel";
            O1 = true;
            O1 = 20.20f;
            O1 = 'A';

            Console.ReadKey();



        }
    }
}
