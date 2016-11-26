using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76a_EvaluateTheStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + (double)1 / i;
                
            }
            Console.WriteLine(sum);
        }
    }
}
