using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YES_C_sharp_1
{
    class Beep{
        static void Main(string[] args){
            Console.WriteLine("Beep Class");
            Console.Beep(2100, 1000);
            Console.Beep(2100, 500);
            Console.Beep(2100, 1000);
            Console.Beep(2100, 500);
            Console.Beep(2100, 1000);
            Console.ReadKey();
        }
    }
}
