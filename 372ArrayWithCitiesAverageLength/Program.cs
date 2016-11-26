using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _372ArrayWithCitiesAverageLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string[] cities = new string[] { "Ивайловград", "София", "Пловдив", "Асеновград",
            "Шумен", "Градешница", "Варна", "Бургас", "Силистра", "Русе", "Хасково", "Созопол", "Попово" };
            int sum = 0;
            for (int i = 0; i < cities.Length; i++)
            {
                sum += cities[i].Length;
            }
            double average = sum / cities.Length;
            Console.WriteLine("Average length: "+average);
            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i].Length < average)
                {
                    Console.WriteLine("- "+cities[i]);
                }
            }
        }
    }
}
