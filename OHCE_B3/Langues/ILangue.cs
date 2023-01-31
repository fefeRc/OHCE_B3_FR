using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE_B3.Langues{
    
    public interface ILangue{

        string BienDit { get; }
        
        string direBonjour(PeriodeJournee periodeJournee);
        
        string AuRevoir { get; }

    }
}