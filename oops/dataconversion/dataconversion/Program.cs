using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace dataconversion
{
    class program
    {
        public int i = 10;
        public float f = 10.1111f;
        public double d = 10.11111111;
        public decimal dc = 10.111111111111111111m;
        public string Str = "1234";
        public object Obj = 123;

        static void main(string[] vs)
        {
            program p = new program();
            Console.WriteLine("Integer i:" + p.i);
            Console.WriteLine("float f:" + p.f);
            Console.WriteLine("double d:" + p.d);
            Console.WriteLine("decimal dc:" + p.dc);

            int i1 = (int)p.f;
            Console.WriteLine("Converted Integer i1:" + i1);

            float f1 = (float)p.i;
            Console.WriteLine("Converted float f1:" + f1);

            var v = (int)p.i;
            Console.WriteLine("Converted Implicit variable v:" + v);

            Console.WriteLine("string str:" + p.Str);
            Console.WriteLine("Converted Integer from string:" + Int32.Parse(p.Str));
            Console.WriteLine("Coverted Integer from string:" + Convert.ToInt32(p.Str));

            p.Str = null;
            Console.WriteLine("convert Interger from string:" + Convert.ToInt32(p.Str));

            p.Str = "111";
            int i;
            bool b = Int32.TryParse(p.Str, out i);
            Console.WriteLine("convert integer from string is possible:" + b); ;
            Console.WriteLine("converted integer from string:" + i);

            Object obj2 = (string)p.Str;
            Console.WriteLine("Convert object from string:" + obj2);

            Console.WriteLine("converted string from object:" + Convert.ToString(p.Obj));

            int i2;
            bool b2=Int32.TryParse((string)p.Str, out i2);

            Console.ReadKey();
        }
    }
}
