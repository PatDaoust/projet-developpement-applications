using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary
{
    public class FeuilleTempsModel
    {
        public int feuilleID { get; set; }
        public int employeID { get; set; }
        public int projetID { get; set; }
        public int lundi { get; set; }
        public int mardi { get; set; }
        public int mercredi { get; set; }
        public int jeudi { get; set; }            
        public int vendredi { get; set; }
        public int samedi { get; set; }
        public int dimanche { get; set; }
    }
}
