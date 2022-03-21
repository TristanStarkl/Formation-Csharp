using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class SpeakingClock
    {
        public static string GoodDay(int heure)
        {
            string res = $"Il est {heure} heure, ";

            if (heure >= 0 && heure <= 6)
                res += "Merveilleuse nuit!";
            else if (heure > 6 && heure < 12)
                res += "Bonne matinée!";
            else if (heure == 12)
                res += "Bon appétit!";
            else if (heure >= 13 && heure < 18)
                res += "Profitez de votre après-midi!";
            else if (heure >= 18 && heure < 24)
                res += "Passez une bonne soirée!";
            else
                res += "Vous qui habitez hors du temps, soyez maudits!";
            return res;
        }
    }
}
