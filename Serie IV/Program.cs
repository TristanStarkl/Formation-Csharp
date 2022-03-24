using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------
            /*            PhoneBook annuaire = new PhoneBook();

                        annuaire.AddPhoneNumber("0626134518", "Thomas RETY");
                        try
                        {
                            annuaire.AddPhoneNumber("0012312312", "Personne qui n'existe pas");
                            annuaire.AddPhoneNumber("1000000000", "a marche pas");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }

                        annuaire.DisplayPhoneBook();*/
            // ------------------------------------------------
            // ------------------------------------------------

            /*     BusinessSchedule bs = new BusinessSchedule();
                 bs.DisplayMeetings();
                 bs.AddBusinessMeeting(DateTime.Now, TimeSpan.FromMinutes(60));
                 bs.AddBusinessMeeting(DateTime.Today, TimeSpan.FromMinutes(60));
                 bs.AddBusinessMeeting(new DateTime(2021, 5, 6), TimeSpan.FromMinutes(60));
                 bs.AddBusinessMeeting(new DateTime(2021, 5, 6), TimeSpan.FromMinutes(60));
                 bs.AddBusinessMeeting(new DateTime(2021, 5, 6), TimeSpan.FromMinutes(60));
                 bs.AddBusinessMeeting(new DateTime(2021, 5, 6), TimeSpan.FromMinutes(60));
                 bs.DisplayMeetings();
     */
            // ------------------------------------------------


            string castor = "int main (int argc, char **argv){int *crustace = malloc(sizeof(int) * argc); write(0, crustace[1])}";
            Console.WriteLine(BracketsControl.BracketsControls(castor));

            // -------------------------------------------------

            string morse1 = "===.=.===.=...===.===.===...===.=.=...=.....===.===...===.===.===...=.===.=...=.=.=...=";
            string morse2 = "...===.=.===.=...===.===.===...===.=.=...=.....";
            Morse morse = new Morse();
            Console.WriteLine(morse.LettersCount(morse1));
            Console.WriteLine(morse.WordsCount(morse1));
            Console.WriteLine(morse.MorseTranslation(morse1));
            Console.WriteLine(morse.EfficientMorseTranslation(morse2));

            string encrypted = morse.MorseEncryption("CODE");
            Console.WriteLine(encrypted);
            Console.WriteLine(morse.EfficientMorseTranslation(encrypted));
            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
