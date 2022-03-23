using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public struct Qcm
    {
        public int Solution;
        public int Weight;
        public string[] Answers;
        public string Question;

        public Qcm(string[] answers, string question, int solution, int weight)
        {
            Solution = solution;
            Answers = answers;
            Weight = weight;
            Question = question;
        }

    }

    public static class Quiz
    {
        public static void AskQuestions(Qcm[] qcms)
        {
            int nbPoints = 0;
            int nbPointsTotaux = 0;

            Console.WriteLine("Questionnaire: ");
            for (int i = 0; i < qcms.Length; i++)
            {
                nbPoints += AskQuestion(qcms[i]);
                nbPointsTotaux += qcms[i].Weight;
            }

            Console.WriteLine($"Résultats du questionnaire : {nbPoints} / {nbPointsTotaux}");
        }

        public static int AskQuestion(Qcm qcm)
        {
            int compteur = 1;
            if (!QcmValidity(qcm))
                throw new ArgumentException();
            Console.WriteLine(qcm.Question);
            for (int i = 0; i < qcm.Answers.Length; i++)
            {
                Console.Write($"{compteur}. ");
                Console.Write($"{qcm.Answers[i]} ");
                 compteur ++;
            }
            Console.WriteLine("");
            int reponse;
            bool invalidResponse;
            do
            {
                Console.Write("Réponse : ");
                reponse = -1;
                int.TryParse(Console.ReadLine(), out reponse);
                if (reponse <= 0 || reponse > qcm.Answers.Length)
                {
                    Console.WriteLine("Réponse invalide! ");
                    invalidResponse = true;
                }
                else
                    invalidResponse = false;
            } while (invalidResponse);
            if (reponse == qcm.Solution)
                return qcm.Weight;
            return 0;
        }

        public static bool QcmValidity(Qcm qcm)
        {
            if (qcm.Solution <= 0 || qcm.Solution > qcm.Answers.Length)
                return false;
            if (qcm.Weight <= 0)
                return false;
            return true;
        }
    }
}
