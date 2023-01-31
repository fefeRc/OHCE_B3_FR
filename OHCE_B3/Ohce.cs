using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE_B3{
    
    public class Ohce{

        private ILangue _langue;

        private PeriodeJournee _periodeJournee;

        public Ohce(ILangue langue, PeriodeJournee periodeJournee){
            _langue = langue;
            _periodeJournee = periodeJournee;
        }

        public string palyndrome(string str){

            StringBuilder stringBuilder = new StringBuilder();

            var reversed = new string(str.Reverse().ToArray());

            stringBuilder.Append(reversed);

            if (str == reversed){
                stringBuilder.Append(_langue.BienDit);
            }

            return stringBuilder.ToString();
        }

        public ILangue getLangue(){
            return _langue;
        }



    }
}