using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh_Workshop_day1
{
    class _6_Data_Type
    {        
        public static void Main(string[] args){

            int a = 100;
            float b = 54.21f;           //32 bit
            double c = 199.223123;      //64 bit
            decimal d = 192.321321321m; //128 bit
            char e = 'a';
            Console.WriteLine("INT: " + a);
            Console.WriteLine("Float: " + b);
            Console.WriteLine("Double: " + c);
            Console.WriteLine("Decimal: " + d);
            Console.WriteLine("Char: " + e);
            Console.ReadLine();

        }
    }
}
