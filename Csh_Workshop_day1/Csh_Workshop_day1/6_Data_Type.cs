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
            int f = new int();
            string g = "Hello World";
            Console.WriteLine("INT: " + a);
            Console.WriteLine("Float: " + b);
            Console.WriteLine("Double: " + c);
            Console.WriteLine("Decimal: " + d);
            Console.WriteLine("Char: " + e);
            Console.WriteLine("New int: " + f);
            Console.WriteLine("String: " + g);
            Console.WriteLine("Taking input (Input int values)");
            int h;
            string i;
            i = Console.ReadLine();
            Console.WriteLine("As String: " +i);
            h = Int32.Parse(i);
            Console.WriteLine("As Int: " + h);
            Console.WriteLine("Read input as int directly (Enter int value)");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Read directly int: " + h);
            Console.WriteLine("Input 2 values");
            Console.WriteLine("TOGETHER: "+ (Convert.ToInt32(Console.ReadLine()) + Int32.Parse(Console.ReadLine())));
            int j = 100;
            short k = (short)j;
            Console.WriteLine(k);

            System.ConsoleKeyInfo ll = Console.ReadKey();
            Console.WriteLine("OUTPUT " + ll.KeyChar);



            Console.ReadLine();

        }
    }
}
