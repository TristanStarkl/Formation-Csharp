using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public struct Matiere
    {
        public string Name;
        public List<float> ListNotes;
        public float Moyenne;

        public Matiere(float note, string name)
        {
            ListNotes = new List<float> { note };
            Name = name;
            Moyenne = 0f;
        }

        public void CalculMean()
        {
            float total = 0f;
            foreach (float note in ListNotes)
            {
                total += note;
            }
            Moyenne = total / (float)ListNotes.Count;
        }

    }
    public static class ClassCouncil
    {
        public static void SchoolMeans(string input, string output)
        {
            string[] listColumns;
            float note;
            bool found;

            List<Matiere> listMatieres = new List<Matiere>();
            try
            {
                using (StreamReader reader = new StreamReader(input))
                {
                    while (!reader.EndOfStream)
                    {
                        listColumns = reader.ReadLine().Split(';');
                        if (listColumns.Length == 3)
                        {
                            try
                            {
                                found = false;
                                note = float.Parse(listColumns[2].Replace(".", ","));
                                if (note < 0 || note > 20)
                                    throw new Exception("La note est trop grande.");
                                // On recherche maintenant si la matière existe déjà
                                foreach (Matiere matiere in listMatieres)
                                {
                                    if (matiere.Name == listColumns[1])
                                    {
                                        found = true;
                                        matiere.ListNotes.Add(note);
                                    }
                                }
                                if (!found)
                                {
                                    Matiere temp = new Matiere(note, listColumns[1]);
                                    listMatieres.Add(temp);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"Erreur: La note de {listColumns[0]} pour la matière {listColumns[1]} est invalide. {e}");
                            }
                        }
                    }
                    using (StreamWriter writer = new StreamWriter(output, true))
                    {
                        foreach (Matiere matiere in listMatieres)
                        {
                            matiere.CalculMean();
                            writer.WriteLine($"{matiere.Name};{matiere.Moyenne}");
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Erreur! le fichier {input} n'existe pas.");
            }

        }
    }
}
