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
        public ArrayList jour1 = new ArrayList();
        public ArrayList jour2 = new ArrayList();
        public ArrayList jour3 = new ArrayList();
        public ArrayList jour4 = new ArrayList();
        public ArrayList jour5 = new ArrayList();
        public ArrayList weekend1 = new ArrayList();
        public ArrayList weekend2 = new ArrayList();

        public FeuilleTemps()
        {
            this.jour1 = null;
            this.jour2 = null;
            this.jour3 = null;
            this.jour4 = null;
            this.jour5 = null;
            this.weekend1 = null;
            this.weekend2 = null;
        }
        public FeuilleTemps(
            ArrayList jour1,
            ArrayList jour2,
            ArrayList jour3,
            ArrayList jour4,
            ArrayList jour5,
            ArrayList weekend1,
            ArrayList weekend2)
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
