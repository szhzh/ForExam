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
            string[] a = new string[] { "Ивайловград", "София", "Пловдив", "Асеновград",
            "Шумен", "Градешница", "Варна", "Бургас", "Силистра", "Русе", "Хасково", "Созопол", "Попово" };
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int s = i+1; s < a.Length; s++)
                {
                    if (a[i].CompareTo(a[s]) > 0)
                    {
                        string p = a[i];
                        a[i] = a[s];
                        a[s] = p;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
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
