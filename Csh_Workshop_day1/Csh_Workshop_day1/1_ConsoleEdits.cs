/* Program name: Hello Universe
 * 
 * Author : Minhazul Hayat Khan
 * 
 * 
 * 
 *  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YES_C_sharp_1
{
    class ConsoleEdits
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.Title = "HELLO WORLD";

            Console.WriteLine("Hello World");
            Console.Beep(2100, 1000);
            Console.Beep(2100, 500);
            Console.Beep(2100, 1000);
            Console.Beep(2100, 500);
            Console.Beep(2100, 1000);

            Console.CursorSize(100);

            Console.ReadKey();
        }
    }
}
