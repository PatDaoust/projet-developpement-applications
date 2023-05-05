using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionRH
{
    public class Employe
    {
        public int numEmploye;
        public string categorie;
        public FeuilleTemps feuilleTemps;
        public string prenomEmploye;
        public string nomEmploye;
        public string hashMotDePasse;

        public Employe(Employe employe)
        {
            this.numEmploye = employe.numEmploye;
            this.categorie = employe.categorie;
            this.feuilleTemps = employe.feuilleTemps;
        }

        public Employe(int numEmploye, FeuilleTemps feuilleTemps)
        {
            this.numEmploye = numEmploye;
            if (numEmploye < 1000)
            {
                this.categorie = "Administrateur";
            }
            else if (numEmploye >= 1000 || numEmploye < 2000)
            {
                this.categorie = "Employé de production";
            }
            else if (numEmploye > 2000)
            {
                this.categorie = "Employé d'exploitation";
            }
            this.feuilleTemps = feuilleTemps;
        }

        public Employe(int numEmploye, string hashMotDePasse, string nomEmploye, string prenomEmploye) {
            this.numEmploye = numEmploye;
            if (numEmploye < 1000) {
                this.categorie = "Administrateur";
            } else if (numEmploye >= 1000 || numEmploye < 2000) {
                this.categorie = "Production";
            } else if (numEmploye > 2000) {
                this.categorie = "Exploitation";
            }
            this.hashMotDePasse= hashMotDePasse;
            this.nomEmploye=nomEmploye;
            this.prenomEmploye = prenomEmploye;
        }
    }
}
