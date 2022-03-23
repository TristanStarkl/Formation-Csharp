using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Eratosthene
    {
        public static int[] EratosthenesSieve(int n)
        {
            int[] tableau = new int[n];
            if (n <= 2)
                return new int[10];
            for (int c = 2; c < n; c++)
                tableau[c] = c;
            tableau[0] = -1;
            tableau[1] = -1;
            int biggestInteger = 0;
            int smallestInteger = 0;
            int boucleur;
            do
            {
                boucleur = 0;
                while (boucleur < n)
                {
                    if (tableau[boucleur] != -1)
                    {
                        smallestInteger = tableau[boucleur];
                        boucleur = n *2;
                    }
                    boucleur ++;
                }
                boucleur = n - 1;
                while (boucleur > 0)
                {
                    if (tableau[boucleur] > biggestInteger)
                    {
                        biggestInteger = tableau[boucleur];
                        boucleur = -1;
                    }
                    boucleur --;
                }
                for (int k = 0; k < n + 1; k++)
                {
                    if (k * smallestInteger < n)
                        tableau[k * smallestInteger] = -1;
                }
            } while (smallestInteger < Math.Sqrt(biggestInteger));
 
            // On calcule le nombre d'entier restant;
            int nbRestant = 0;
            for (int l = 0; l < n; l++)
                nbRestant = tableau[l] == -1 ? nbRestant : nbRestant + 1;
            int[] newTableau = new int[nbRestant];
            int i = 0;
            int j = 0;
            while (i < n)
            {
                if (tableau[i] != -1)
                {
                    newTableau[j] = tableau[i];
                    j++;
                }
                i++;
            }
            return newTableau;
        }
    }
}
