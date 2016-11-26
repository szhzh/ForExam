using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //int kod = 97;
            //char let = (char)kod;
            //Console.WriteLine(let);
            char str = 'Т';
            Console.WriteLine(str);
            int kod = (int)str;
            Console.WriteLine(kod);
            Random rand = new Random();
            int newkod = kod + rand.Next(-5, 5);
            Console.WriteLine(newkod);
            char novstr = (char)newkod;
            Console.WriteLine(novstr);
            
            

            //int a = (char)'Я';
            //Console.WriteLine(a);
        }
        static void TheBiggest(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("The biggest is: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The biggest is: " + b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("The biggest is: " + c);
            }
            else if (a == b && a == c)
            {
                Console.WriteLine("All are the same numbers !");
            }
        }
    }
}
