using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Euclide
    {
        public static int Pgcd(int a, int b)
        {
            int pgcd = 1;
            int smaller = a < b ? a : b;

            for (int i = 1; i < smaller; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                    pgcd = i;
            }

            return pgcd;
        }

        public static int PgcdRecursive(int a, int b)
        {
            int r = a % b;
            if (r == 0)
                return b;
            return PgcdRecursive(b, r);
        }
    }
}
