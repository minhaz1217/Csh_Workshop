using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YES_C_sharp_1
{
    class CursorSize
    {
        static void Main(string[] args){
            Console.CursorSize = 1;
            Console.SetWindowSize(40, 40);
            Console.WriteLine("This is the Cursor Class");
            Console.ReadLine();
              
        }
    }
}
