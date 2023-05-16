using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary
{
    public class EmployeModel
    {
        public int employeID { get; set; }
        public string categorie { get; set; }
        public string prenomEmploye { get; set; }
        public string nomEmploye { get; set; }
        public string motDePasse { get; set; }
        public string FullName
        {
            get
            {
                return $"{ prenomEmploye } { nomEmploye }";
            }
        }
    }
}
