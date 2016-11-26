using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76b_EvaluateTheStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                sum = 1;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    sum = sum + (double)1 / Math.Pow(i, 2);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
