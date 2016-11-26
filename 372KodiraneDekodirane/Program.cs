using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _372KodiraneDekodirane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string[] cities = new string[] { "Ивайловград", "София", "Пловдив", "Асеновград",
            "Шумен", "Градешница", "Варна", "Бургас", "Силистра", "Русе", "Хасково", "Созопол", "Попово" };
            Random rand = new Random();
            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write("{0} ----> ",cities[i]);
                for (int s = 0; s < cities[i].Length; s++)
                {
                    int kod = (int)cities[i][s];
                    int novkod = kod + rand.Next(-5, 5);
                    char ch = (char)novkod;
                    Console.Write(ch);
                }
                Console.WriteLine();
            }

        }
    }
}
