using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161b_Enter2NumFromInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers from the interval [-10;8]: ");
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            if (-10 <= p && p <= 8 && -10 <= q && q <= 8)
            {
                Console.WriteLine("Good job !");
            }
            else
            {
                Console.WriteLine("Invalid data !");
            }
        }
    }
}
