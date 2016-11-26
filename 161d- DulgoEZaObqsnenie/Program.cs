using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161d__DulgoEZaObqsnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.Write("Enter a number: ");
            int q = int.Parse(Console.ReadLine());
            for (int i = -10; i <= 8; i=i+3)
            {
                num = Function(i, q);
                if (num % 2 > 0 && num is int)
                {
                    Console.WriteLine(num);
                }
            }
        }
        public static double Function(int x, int y)
        {
            object function = 0;
            if (x < 0 && y < 0)
            {
                x = -x;
                y = -y;
                function = (x + y) / 2;
                if (function is int)
                {
                    function = (int)function;
                    return (int)function;
                }
                if (function is double)
                {
                    function = (double)function;
                    return (double)function;
                }
            }
            if (x >= 0 && y < 0)
            {
                y = -y;
                function = (x + y) / 2;
                if (function is int)
                {
                    function = (int)function;
                    return (int)function;
                }
                if (function is double)
                {
                    function = (double)function;
                    return (double)function;
                }
            }
            if (x < 0 && y >= 0)
            {
                x = -x;
                function = (x + y) / 2;
                if (function is int)
                {
                    function = (int)function;
                    return (int)function;
                }
                if (function is double)
                {
                    function = (double)function;
                    return (double)function;
                }
            }
            if (x >= 0 && y >= 0)
            {
                function = (x + y) / 2;
                if (function is int)
                {
                    function = (int)function;
                    return (int)function;
                }
                if (function is double)
                {
                    function = (double)function;
                    return (double)function;
                }
            }
        }
    }
}
