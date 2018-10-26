using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YES_C_sharp_1
{
    class _4_Variables
    {
        static void Main(string[] args){
            int number = 10;
            bool bol = true;
            Console.WriteLine("Integer: " + number );
            Console.WriteLine("BOOL: "  + bol);
            int i = 100;
            int j = i;
            Console.WriteLine("BOOLEAN: " + !(i == j) );


            Console.ReadKey();
        }
    }
}
