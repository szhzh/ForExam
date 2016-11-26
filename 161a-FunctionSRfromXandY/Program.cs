using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161a_FunctionSRfromXandY
{
    class Program
    {
        static void Main(string[] args)
        {
            double sr = 0;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x < 0 && y < 0)
            {
                x = -x;
                y = -y;
                sr = (x + y) / 2;
            }
            if (x >= 0 && y < 0)
            {
                y = -y;
                sr = (x + y) / 2;
            }
            if (x < 0 && y >= 0)
            {
                x = -x;
                sr = (x + y) / 2;
            }
            if (x >= 0 && y >= 0)
            {
                sr = (x + y) / 2;
            }
            Console.WriteLine((double)sr);
        }
    }
}
