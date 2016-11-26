using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _225_OutputTheElementsOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the length of the arrya: ");
            //int n = int.Parse(Console.ReadLine());
            Random num = new Random(); 
            double[] array = new double[50];
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = num.Next(0, 100);
                Console.WriteLine("array["+i+"]="+array[i]);
            }

        }
    }
}
