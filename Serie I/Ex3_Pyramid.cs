using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Pyramid
    {
        public static void PyramidConstruction(int n, bool isSmooth)
        {
            string res = "";
            int ligneActuelle = 1;
            int nbEtoiles = -1;

            for (int i = 0; i < n; i++)
            {
                res = "";
                nbEtoiles += 2;
                for (int j = 0; j < (n - ligneActuelle); j++)
                {
                    res += " ";
                }
                for (int j = 0; j < nbEtoiles; j++)
                {
                    if (!isSmooth && (ligneActuelle % 2 == 0))
                        res += "-";
                    else
                        res += "+";
                }
                ligneActuelle++;
                Console.WriteLine(res);
            }
            //TODO
        }
    }
}
