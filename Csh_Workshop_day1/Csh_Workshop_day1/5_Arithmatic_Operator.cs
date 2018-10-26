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
            int g = 5;
            g = g / 5;
            Console.WriteLine(g);
            Console.WriteLine("Post and Pre Increment");
            int h = 5;
            Console.WriteLine(h);
            Console.WriteLine(h++);
            Console.WriteLine(h);
            Console.WriteLine(++h);
            Console.WriteLine(h);
            int k = 5;
            int l = ++k;
            Console.WriteLine("{0} {1}", k,l);
            Console.WriteLine("%d %d", k, l);
            int m = 5, n = 3;
            int o = m++ + ++n + ++m;
            Console.WriteLine(o);


            /*
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
             * */
            Console.ReadKey();
        }
    }
}
