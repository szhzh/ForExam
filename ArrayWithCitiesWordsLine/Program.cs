using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithCitiesWordsLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string[] cities = new string[] { "Ивайловград", "София", "Пловдив", "Асеновград",
            "Шумен", "Градешница", "Варна", "Бургас", "Силистра", "Русе", "Хасково", "Созопол", "Попово" };
            for (int i = 0; i < cities.Length - 1; i++)
            {
                for (int s = i + 1; s < cities.Length; s++)
                {
                    if (cities[i].CompareTo(cities[s]) > 0)
                    {
                        string p = cities[i];
                        cities[i] = cities[s];
                        cities[s] = p;
                    }
                }
            }
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }
        }
    }
}
