using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    class Program
    {
        static void Main(string[] args)
        {
            string notes = "schoolNotes.txt";
            string fichierSortie = "moyennesHistoriques.txt";

            if (args.Length != 0)
            {
                foreach (string arg in args)
                {
                    ClassCouncil.SchoolMeans(arg, arg + "Sortie.txt");

                }
            }
            else
            {
                ClassCouncil.SchoolMeans(notes, fichierSortie);
            }

            Random random = new Random();
            List<int> size = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                size.Add(random.Next(45000, 50000));
            }

            SortingPerformance.DisplayPerformances(size, 10);


            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
