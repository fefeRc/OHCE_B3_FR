using OHCE_B3.Langues;

namespace OHCE_B3
{
    public class SystemLangProxy :ILangue
    {
        public string BienDit => System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR" ? Expressions.Français.BienDit : (System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN" ? Expressions.English.BienDit: "");

        public string AuRevoir => System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR" ? Expressions.Français.AuRevoir : (System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN" ? Expressions.English.AuRevoir : "");

        public string direBonjour(PeriodeJournee période)
        {
            if(System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR")
            {
                return période == PeriodeJournee.Soir
                    ? Expressions.Français.Bonsoir
                    : Expressions.Français.Bonjour;
            } else if(System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN")
            {
                return période == PeriodeJournee.Soir
                    ? Expressions.English.Bonsoir
                    : Expressions.English.Bonjour;
            } else
            {
                return "";
            }
        }
    }
}