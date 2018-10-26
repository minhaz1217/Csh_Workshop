using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh_Workshop_day1
{
    class _5_Arithmatic_Operator
    {
        static void Main(string[] args){
            int a = 1, b = 2, c = 3;
            int d = a + b * c;
            int e = d / c;
            int f = d % b;
            Console.WriteLine(d + " " + e + " " + f);
            /*
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
             * */
            Console.ReadKey();
        }
    }
}
