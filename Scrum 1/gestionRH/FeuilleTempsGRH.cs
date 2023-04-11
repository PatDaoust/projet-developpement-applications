using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using Newtonsoft.Json.Linq;

namespace gestionRH
{
    public partial class FeuilleTempsGRH : Form
    {
        public int numEmploye = LoginGRH.numEmploye;
        public FeuilleTempsGRH()
        {
            InitializeComponent();
            txbNumEmploye.Text = numEmploye.ToString();
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            string[] fichier ={ "../json/FeuilleTempsExemple.json", "../json/RenduExemple.json" };
            Valider(fichier);
        }


        public void Valider(string[] args)
        {
            // Vérifier si les arguments sont fournis
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: TimeSheetValidator inputfile.json result.json");
                return;
            }

            // Lecture du fichier JSON d'entree
            string inputFilePath = args[0];
            string inputJson = File.ReadAllText(inputFilePath);

            // Extraction du numéro d'employe et des donnees de la feuille de temps
            JObject input = JObject.Parse(inputJson);
                
            // Extract employee number and timesheet data
            int employeeNumber = (int)input["numeroEmploye"];
            JArray timesheetData = (JArray)input["jour1"];

            // Validation des donnees de la feuille de temps
            JArray errors = new JArray();

            // Règle 1 : L'employe doit travailler un nombre minimum d'heures
            int totalMinutes = 0;
            foreach (JObject entry in timesheetData)
            {
                totalMinutes += (int)entry["minutes"];
            }
            if (totalMinutes < 240)
            {
                errors.Add("L'employé n'a pas travaillé le nombre minimal d'heures");
            }

            // Règle 2 : L'employé ne peut pas travailler à distance plus de 8 heures par semaine
            int telecommutingMinutes = 0;
            foreach (JObject entry in timesheetData)
            {
                int projectCode = (int)entry["projet"];
                int minutes = (int)entry["minutes"];
                if (projectCode >= 900)
                {
                    telecommutingMinutes += minutes;
                }
            }
            if (telecommutingMinutes > 480)
            {
                errors.Add("L'employé a dépassé la durée autorisée pour le travail à distance");
            }

            // Écriture du fichier JSON de sortie
            string outputFilePath = args[1];
            File.WriteAllText(outputFilePath, errors.ToString());
        }
    }
}



