using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _229vFiltriraneNaMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the legth of the first array: ");
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            int suma = SumOfElemnts(a, m);
            Console.WriteLine("The sum of the elements is: "+suma);
            Console.WriteLine("-------------------------------------------|");
            Console.Write("Enter the legth of the second array: ");
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[n];
            int sumb = SumOfElemnts(b, n);
            Console.WriteLine("The sum of the elements is: " + sumb);
            Console.WriteLine("-------------------------------------------|");
            Console.Write("Enter the legth of the third array: ");
            int k = int.Parse(Console.ReadLine());
            int[] c = new int[k];
            int sumc = SumOfElemnts(c, k);
            Console.WriteLine("The sum of the elements is: " + sumc);
            Console.WriteLine("-------------------------------------------|");
            TheBiggest(suma, sumb, sumc);
        }
        static void TheBiggest(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("The biggest is: " + a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine("The biggest is: " + b);
            }
            if (c > a && c > b)
            {
                Console.WriteLine("The biggest is: " + c);
            }
            if (a == b && a == c)
            {
                Console.WriteLine("All the numbers are the same !");
            }
        }
        static int SumOfElemnts(int[] array, int length)
        {
            int sumarr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("element["+i+"]=");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0 && (array[i] >= -30 && array[i] <= 30))
                {
                    sumarr++;
                }
            }
            return sumarr;
 
        }

    }
}
