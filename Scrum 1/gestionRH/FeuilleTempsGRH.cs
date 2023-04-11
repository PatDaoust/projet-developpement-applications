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
using System.Diagnostics;
using Newtonsoft.Json;

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
            //user selects JSON file to be analyzed
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            string selectedFileName = openFileDialog1.FileName;
            string fileContent = File.ReadAllText(selectedFileName);
            //transform the string into usable format
            string[] fichier= fileContent.Split(new char[] {';' }); 
            //MessageBox.Show(fichier[0]); //TODO remove after debugging
            Valider(fichier);
        }


        public void Valider(string[] args)
        {
            /*
            // Vérifier si les arguments sont fournis
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: TimeSheetValidator inputfile.json result.json");
                return;
            }
            */
            MessageBox.Show("valider lancer");

            // Lecture du fichier JSON d'entree
            //string inputFilePath = args[0];
            //string inputJson = File.ReadAllText(inputFilePath);

            // Extraction du numéro d'employe et des donnees de la feuille de temps
            JObject input = JObject.Parse(args[0]);
                
            // Extract employee number 
            int employeeNumber = (int)input["numeroEmploye"];

            //Extract timesheet data for each day
            JArray jour1 = (JArray)input["jour1"];
            JArray jour2 = (JArray)input["jour2"];
            JArray jour3 = (JArray)input["jour3"];
            JArray jour4 = (JArray)input["jour4"];
            JArray jour5 = (JArray)input["jour5"];
            JArray weekend1 = (JArray)input["weekend1"];
            JArray weekend2 = (JArray)input["weekend2"];
            JArray timesheetData = new JArray(jour1, jour2, jour3, jour4, jour5, weekend1, weekend2);

            MessageBox.Show(timesheetData.ToString()); //TODO remove after debugging

            // Validation des donnees de la feuille de temps
            JArray errors = new JArray();

            // Règle 1 : L'employe doit travailler un nombre minimum d'heures au bureau par semaine
            int totalMinutes = 0;
            foreach (JArray day in timesheetData)
            {
                foreach (JObject entry in day) {
                    if ((int)entry["projet"] < (36*60)) { 
                        totalMinutes += (int)entry["minutes"];
                    }
                }
            }

            if (totalMinutes < (36*60))
            {
                errors.Add("L'employé n'a pas travaillé le nombre minimal d'heures eu bureau");
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



