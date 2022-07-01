using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = 200;
            y = 500;
            z = 300;
            Console.WriteLine("(1) x = 200, y = 500, z = 300");
            Console.WriteLine("(2) z = x * y");
            Console.WriteLine("(2) x =" + x + ",y =" + y + ",z =" + x * y);
            Console.WriteLine("(3) y = y * 2 - z");
            Console.WriteLine("(3) x =" + x + ",y =" + (y * 2 - x * y) + ",z =" + x * y);
            Console.WriteLine("(4) x = x + 5");
            Console.WriteLine("(4) x =" + ( x + 5 )+ ",y =" + (y * 2 - x * y) + ",z =" + x * y);
            Console.WriteLine("(5) z = z + x");
            Console.WriteLine("(5) x =" + (x + 5) + ",y =" + (y * 2 - x * y) + ",z =" + (x * y + x + 5));
            Console.WriteLine("(6) x = x * 3 + y");
            Console.WriteLine("(6) x =" + ((x + 5) * 3 + (y * 2 - x * y))+ ",y =" + (y * 2 - x * y) + ",z =" + (x * y + x + 5));
            Console.WriteLine("(7) y = z / 3 - x");
            Console.WriteLine("(6) x =" + ((x + 5) * 3 + (y * 2 - x * y)) + ",y =" + ((x * y + x + 5) / 3 - ((x + 5) * 3 + (y * 2 - x * y))) + ",z =" + (x * y + x + 5));
            Console.ReadLine();
        }
    }
}
