using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constant_and_Readonly_keyword
{
    class program
    {
        public const int a = 10;
        readonly int b = 10;
        int c = 20;
        public program(int n)
        {
            b= n;   
        }

        static void Main(string[] vs)
        {
            program p = new program();

            Console.WriteLine(p.b);
            p.c = 100;

            Console.ReadKey();
        }
    }
}
