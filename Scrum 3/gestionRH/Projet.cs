using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionRH
{
    public class Projet
    {
        public int feuilleID { get; set; }
        public int projetID { get; set; }
        public Employe employe { get; set; }
        public FeuilleTemps feuilleTemps { get; set; }

        public Projet(int feuilleID, int projetID, Employe employe, FeuilleTemps feuilleTemps)
        {
            this.feuilleID = feuilleID;
            this.projetID = projetID;
            this.employe = employe;
            this.feuilleTemps = feuilleTemps;
        }
    }
}
