using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161c_ReplaceValueInTheFunction
{
    class Program
    {
        static void Main()
        {
            double sr1=0;
            double sr2=0;
            double sr3=0;
            Console.WriteLine("Enter 2 numbers from the interval [-10;8]: ");
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            if (-10 <= p && p <= 8 && -10 <= q && q <= 8)
            {
                sr1 = Function(2*p, 3*q);
                sr2 = Function(3*p, 2*q);
                sr3 = Function(p, q);
            }
            else
            {
                Console.WriteLine("Invalid data !");
            }
            double result = (double)(sr1 - sr2) / sr3;
            Console.WriteLine(result);
        }
        public static double Function(int x, int y)
        {
            double function = 0;
            if (x < 0 && y < 0)
            {
                x = -x;
                y = -y;
                function = (double)(x + y) / 2;
            }
            if (x >= 0 && y < 0)
            {
                y = -y;
                function = (double)(x + y) / 2;
            }
            if (x < 0 && y >= 0)
            {
                x = -x;
                function = (double)(x + y) / 2;
            }
            if (x >= 0 && y >= 0)
            {
                function = (double)(x + y) / 2;
            }
            return function;
        }
    }
}
