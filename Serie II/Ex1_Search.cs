using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Search
    {
        public static int LinearSearch(int[] tableau, int valeur)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] == valeur)
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] tableau, int valeur)
        {
            int minStep = 0;
            int maxStep = tableau.Length - 1;
            int i;
            do
            {
                i = (minStep + maxStep) / 2;
                if (tableau[i] == valeur)
                    return i;
                else if (tableau[i] > valeur)
                    minStep++;
                else if (tableau[i] < valeur)
                    maxStep++;
            } while (minStep <= maxStep);
            return -1;
        }
    }
}
