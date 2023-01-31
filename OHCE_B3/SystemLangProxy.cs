using OHCE_B3.Langues;

namespace OHCE_B3
{
    public class SystemLangProxy :ILangue
    {
        public string BienDit => System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR" ? Expressions.Français.BienDit : (System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN" ? Expressions.English.BienDit: "");

        public string AuRevoir => System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR" ? Expressions.Français.AuRevoir : (System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN" ? Expressions.English.AuRevoir : "");

        public string direBonjour(PeriodeJournee période){

            if(System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR"){
                return période == PeriodeJournee.Soir
                    ? Expressions.Français.Bonsoir
                    : Expressions.Français.Bonjour;
                switch (periode)
                {
                    case PeriodeJournee.Matin:
                        return Expressions.Français.Bonjour;
                    case PeriodeJournee.ApresMidi:
                        return Expressions.Français.Bonjour;
                    case PeriodeJournee.Soir:
                        return Expressions.Français.Bonsoir;
                    case PeriodeJournee.Nuit:
                        return Expressions.Français.BonneNuit;
                    default:
                        return "yo";

                }

            } 
            
            else if(System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN"){
                switch (periode){
                    case PeriodeJournee.Matin:
                        return Expressions.English.Bonjour;
                    case PeriodeJournee.ApresMidi:
                        return Expressions.English.Bonjour;
                    case PeriodeJournee.Soir:
                        return Expressions.English.Bonsoir;
                    case PeriodeJournee.Nuit:
                        return Expressions.English.BonneNuit;
                    default:
                        return "yolo";

                } else {
                    return "yolo";
            }
        }
    }
}