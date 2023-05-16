using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionRH
{
    public class FeuilleTemps
    {
        public int jour1;
        public int jour2;
        public int jour3;
        public int jour4;
        public int jour5;
        public int weekend1;
        public int weekend2;

        public FeuilleTemps()
        {
            this.jour1 = 0;
            this.jour2 = 0;
            this.jour3 = 0;
            this.jour4 = 0;
            this.jour5 = 0;
            this.weekend1 = 0;
            this.weekend2 = 0;
        }
        public FeuilleTemps(
            int jour1,
            int jour2,
            int jour3,
            int jour4,
            int jour5,
            int weekend1,
            int weekend2)
        {
            this.jour1=jour1;
            this.jour2=jour2;
            this.jour3=jour3;                
            this.jour4=jour4;
            this.jour5=jour5;
            this.weekend1=weekend1;
            this.weekend2=weekend2;
        }
    }
}
