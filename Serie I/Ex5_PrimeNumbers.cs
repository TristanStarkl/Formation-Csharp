using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class PrimeNumbers
    {
        static bool IsPrime(int valeur)
        {
            double sqrtRoot = Math.Sqrt(valeur);
            bool isPrime = true;
            int i = 2;

            if (valeur == 1)
                return false;

            if (valeur == 2)
                return true;

            if (valeur % 2 == 0)
                return false;

            while (i < sqrtRoot + 1)
            {
                if (valeur % i == 0)
                {
                    isPrime = false;
                    i = valeur;
                }

                i++;
            }

            return isPrime;
        }

        public static void DisplayPrimes()
        {
            Console.WriteLine("La liste des nombres premiers de 1 à 100 est: ");
            for (int i = 1; i <= 100; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine(i);
            }
        }
    }
}
