using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum
{
    enum months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr = 20,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
    
    class program
    {
        public void demoexceptional()
        {
            try
            {
                int a = 100;
                Console.WriteLine("Value of a is:" + a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");

            }
        }

        static void Main(string[] vs)
        {
            Console.WriteLine(Convert.ToInt32(months.May) + 11);
            Console.ReadKey();
        }
    }
}
