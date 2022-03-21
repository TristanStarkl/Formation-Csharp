using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insérer ici votre prénom: ", "");

            string firstName = Console.ReadLine();
            Console.WriteLine($"Yop {firstName} !");
            firstName = $"Yop {firstName}! ça va? T'es prêt à jouer?";
            Console.WriteLine(firstName);
            string response = "";
            while (response != "oui")
                response = Console.ReadLine();
            int i = new Random().Next(1, 100);
            int tries = 0;
            bool isFound = false;
            bool isNumeric = false;
            string tempGuessed = "";
            int guessed = -1;
            while (!isFound)
            {
                while (!isNumeric)
                {
                    Console.WriteLine("Devine un nombre compris supérieur à 0!: ");
                    tempGuessed = Console.ReadLine();
                    isNumeric = int.TryParse(tempGuessed, out guessed);
                }
                if (guessed > i)
                    Console.WriteLine("Trop gros!");
                else if (guessed < i)
                    Console.WriteLine("Top petit!");
                else
                {

                }


            }
        }
    }
}
