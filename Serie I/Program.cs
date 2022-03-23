using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    class Program
    {
        static void Main(string[] args)
        {
/*            ElementaryOperations.BasicOperation(9, 9, '+');
            ElementaryOperations.BasicOperation(9, 9, '/');
            ElementaryOperations.BasicOperation(9, 0, '/');
            ElementaryOperations.BasicOperation(9, 9, '-');
            ElementaryOperations.BasicOperation(9, 9, '*');
            ElementaryOperations.BasicOperation(9, 9, 'L');
*/
            /*            ElementaryOperations.IntegerDivision(9, 7);
                        ElementaryOperations.IntegerDivision(9, 9);
            */

            /*            ElementaryOperations.Pow(5, 5);
                        ElementaryOperations.Pow(1, 0);
                        ElementaryOperations.Pow(1, -2);
                        ElementaryOperations.Pow(-5, 3);
            */

            /*            Console.WriteLine(SpeakingClock.GoodDay(12));
                        Console.WriteLine(SpeakingClock.GoodDay(11));
                        Console.WriteLine(SpeakingClock.GoodDay(0));
                        Console.WriteLine(SpeakingClock.GoodDay(13));
                        Console.WriteLine(SpeakingClock.GoodDay(18));
                        Console.WriteLine(SpeakingClock.GoodDay(25));
            */

                        Pyramid.PyramidConstruction(10, true);
                        Pyramid.PyramidConstruction(10, false);
            
            
            

            /*            Console.WriteLine(Factorial.Factorial_(5));
                        Console.WriteLine(Factorial.FactorialRecursive(5));
            */

            /*            PrimeNumbers.DisplayPrimes();
            */
            /*            Console.WriteLine(Euclide.PgcdRecursive(1275, 49));
            */
            /*            Console.WriteLine(Euclide.Pgcd(1275, 1926));
                        Console.WriteLine(Euclide.Pgcd(1275, 1925));
                        Console.WriteLine(Euclide.Pgcd(1275, 49));
            */            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
