using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithCitiesMoreThatTwoO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string[] cities = new string[] { "Ивайловград", "София", "Пловдив", "Асеновград", "Шумен", "Градешница", "Варна", "Бургас", "Силистра", "Русе", "Хасково","Созопол","Попово"};
            for (int i = 0; i < cities.Length; i++)
            {
                int counter = 0;
                    for (int s = 0; s < cities[i].Length; s++)
			    {
                        if (cities[i][s].CompareTo('о')==0 || cities[i][s].CompareTo('О')==0)
                        {
                            counter++;
                            if (counter > 2)
                            {
                                Console.WriteLine("- "+cities[i]);
                            }
                        }
			 
			    }
            }
        }
    }
}
