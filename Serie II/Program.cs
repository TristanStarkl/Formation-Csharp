using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tableau = new int[10] {0, 1, 2, 3, 4,5,6,7,8,9};
            //Console.WriteLine(Search.BinarySearch(tableau, 4));
            //int [] tableau = Eratosthene.EratosthenesSieve(100);
            //for (int i = 0; i < tableau.Length; i++)
            //    Console.WriteLine(tableau[i]);

            Qcm question1 = new Qcm(new string[5] { "12", "56", "3", "18", "533"}, "Combien d'éoliennes faut-il pour remplacer un EPR? ", 5, 10);
            string[] listAnswers2 = new string[5] { "400", "200", "1200", "5000", "487"};
            Qcm question2 = new Qcm(listAnswers2, "Quelle est la quantité d'énergie reçue par la terre sur 1m² provenant du soleil? (Altitude 0) ", 1, 10);
            string[] listAnswers3 = new string[5] { "U235", "U238", "Pu240", "Ca255", "Th233"};
            Qcm question3 = new Qcm(listAnswers3, "Quel est le combustible principal d'un réacteur à sel fondus? ", 5, 10);
            string[] listAnswers4 = new string[5] { "20%", "15%", "30%", "40%", "60%"};
            Qcm question4 = new Qcm(listAnswers4, "Quelle est l'efficacité théorique maximale pour une cellule PV? ", 3, 10);
            string[] listAnswers5 = new string[5] { "Quelques dizaines d'années", "Plusieurs millions d'années", "50 ans", "250 ans", "Mille ans"};
            Qcm question5 = new Qcm(listAnswers5, "Combien de temps de réserves de combustible nucléaire dispose-t-on? Assumons non surgénération. ", 2, 10);
            string[] listAnswers6 = new string[5] { "0", "500", "20000", "18", "2"};
            Qcm question6 = new Qcm(listAnswers6, "Combien de morts dans l'accident nucléaire de Fukushima (2011)? ", 1, 10);

            Qcm[] QuestionsRenouvelables = new Qcm[6] {question1, question2, question3, question4, question5, question6};
            Quiz.AskQuestions(QuestionsRenouvelables);

            //Console.WriteLine(Quiz.AskQuestion(question1));
            int[][] firstMatrix = Matrix.BuildingMatrix(new int[3] { 1, 2, -1}, new int[3] { 1, 2, 5});
            int[][] secondMatrix = Matrix.BuildingMatrix(new int[3] { 1, 2, 3 }, new int[3] { -1, 4, 2 });
            int[][] fifthMatrix = Matrix.BuildingMatrix(new int[3] { 1, 2, 3 }, new int[2] { -1, 4 });
            int[][] sixthMatrix = Matrix.BuildingMatrix(new int[2] { 1, 2}, new int[3] { -1, 4, 8 });
            Console.WriteLine("Display First Matrix: ");
            Matrix.DisplayMatrix(firstMatrix);
            Console.WriteLine("Display Second Matrix: ");
            Matrix.DisplayMatrix(secondMatrix);

            Console.WriteLine("Display Third Matrix: ");
            int[][] thirdMatrix = Matrix.Addition(firstMatrix, secondMatrix);
            Matrix.DisplayMatrix(thirdMatrix);


            Console.WriteLine("Display Fourth Matrix: ");
            int[][] fourthMatrix = Matrix.Substraction(firstMatrix, secondMatrix);
            Matrix.DisplayMatrix(fourthMatrix);
            Console.WriteLine("Display Fifth and Sixth Matrix: ");
            Matrix.DisplayMatrix(fifthMatrix);
            Matrix.DisplayMatrix(sixthMatrix);
            Console.WriteLine("Display the multiplication of 5th and 6th");
            int[][] multiplicationMatrix = Matrix.Multiplication(fifthMatrix, sixthMatrix);
            Matrix.DisplayMatrix(multiplicationMatrix);
            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
