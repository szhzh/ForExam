using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _372ArrayWithCitiesMaxLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string[] cities = new string[] { "Ивайловград", "София", "Пловдив", "Асеновград", "Шумен", "Градешница", "Варна", "Бургас", "Силистра", "Русе", "Хасково", "Созопол", "Попово" };
            int max = cities[0].Length;
            for (int i = 1; i < cities.Length; i++)
            {
                if (max < cities[i].Length)
                {
                    max = cities[i].Length;
                }
                if (max > cities[i].Length || max == cities[i].Length)
                {
                    continue;
                }
            }
            Console.WriteLine("The maximum length is: "+max);
            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i].Length == max)
                {
                    Console.WriteLine("- "+ cities[i]);
                }
            }
        }
    }
}
