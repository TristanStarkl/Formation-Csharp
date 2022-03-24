using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class Morse
    {
        private const string Taah = "===";
        private const string Ti = "=";
        private const string Point = ".";
        private const string Point2 = "..";
        private const string PointLetter = "...";
        private const string PointWord = ".....";

        private readonly Dictionary<string, char> _alphabet;

        public Morse()
        {
            _alphabet = new Dictionary<string, char>()
            {
                {$"{Ti}.{Taah}", 'A'},
                {$"{Taah}.{Ti}.{Ti}.{Ti}", 'B'},
                {$"{Taah}.{Ti}.{Taah}.{Ti}", 'C'},
                {$"{Taah}.{Ti}.{Ti}", 'D'},
                {$"{Ti}", 'E'},
                {$"{Ti}.{Ti}.{Taah}.{Ti}", 'F'},
                {$"{Taah}.{Taah}.{Ti}", 'G'},
                {$"{Ti}.{Ti}.{Ti}.{Ti}", 'H'},
                {$"{Ti}.{Ti}", 'I'},
                {$"{Ti}.{Taah}.{Taah}.{Taah}", 'J'},
                {$"{Taah}.{Ti}.{Taah}", 'K'},
                {$"{Ti}.{Taah}.{Ti}.{Ti}", 'L'},
                {$"{Taah}.{Taah}", 'M'},
                {$"{Taah}.{Ti}", 'N'},
                {$"{Taah}.{Taah}.{Taah}", 'O'},
                {$"{Ti}.{Taah}.{Taah}.{Ti}", 'P'},
                {$"{Taah}.{Taah}.{Ti}.{Taah}", 'Q'},
                {$"{Ti}.{Taah}.{Ti}", 'R'},
                {$"{Ti}.{Ti}.{Ti}", 'S'},
                {$"{Taah}", 'T'},
                {$"{Ti}.{Ti}.{Taah}", 'U'},
                {$"{Ti}.{Ti}.{Ti}.{Taah}", 'V'},
                {$"{Ti}.{Taah}.{Taah}", 'W'},
                {$"{Taah}.{Ti}.{Ti}.{Taah}", 'X'},
                {$"{Taah}.{Ti}.{Taah}.{Taah}", 'Y'},
                {$"{Taah}.{Taah}.{Ti}.{Ti}", 'Z'},
                {".......", ' '},
            };
        }

        public int LettersCount(string code)
        {
            string[] listSeparator = { Morse.PointLetter };
            return code.Split(listSeparator, System.StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int WordsCount(string code)
        {
            string[] listSeparator = { Morse.PointWord };
            return code.Split(listSeparator, System.StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public string MorseTranslation(string code)
        {
            string[] listSeparatorWords = { Morse.PointWord };
            string[] listSeparator = { Morse.PointLetter };
            string resultat = "";

            string[] listMots = code.Split(listSeparatorWords, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string letters in listMots)
            {
                string[] letter = letters.Split(listSeparator, System.StringSplitOptions.RemoveEmptyEntries);
                foreach (string chara in letter)
                {
                    try
                    {
                        resultat += this._alphabet[chara];
                    }
                    catch (KeyNotFoundException)
                    {
                        resultat += '+';
                    }
                }
                resultat += ' ';
            }
            return resultat;
        }

        public string EfficientMorseTranslation(string code)
        {
            string[] listSeparatorWords = { Morse.PointWord, Morse.Point2};
            string[] listSeparator = { Morse.PointLetter };
            string resultat = "";

            string[] listMots = code.Split(listSeparatorWords, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string letters in listMots)
            {

                string[] letter = letters.Trim('.').Split(listSeparator, System.StringSplitOptions.RemoveEmptyEntries);
                foreach (string chara in letter)
                {
                    try
                    {
                        string characterCleaned = chara.Replace("..", ".");
                        resultat += this._alphabet[chara];
                    }
                    catch (KeyNotFoundException)
                    {
                        resultat += '+';
                    }
                }
                //resultat += ' ';
            }
            return resultat;
        }

        public string MorseEncryption(string sentence)
        {
            string res = "";

            foreach (char c in sentence)
            {
                foreach (KeyValuePair<string, char> kpv in _alphabet)
                {
                    if (kpv.Value == c)
                        res += kpv.Key;
                }
                res += "...";
            }

            return res;
        }
    }
}
