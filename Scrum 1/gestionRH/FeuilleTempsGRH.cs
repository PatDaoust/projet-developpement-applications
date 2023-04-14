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
        string fichierSelection;
        string[] fichierOuvert;
        JArray errors;

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
            try
            {
                // Get the filename from the selected file path
                fichierSelection = Path.GetFileName(selectedFileName);
                string fileContent = File.ReadAllText(selectedFileName);
                //transform the string into usable format
                fichierOuvert = fileContent.Split(new char[] { ';' });
                txbFichierOuvert.Text = fichierSelection;
                rtbAffiche.Text = fichierOuvert[0];
            }
            catch
            {
                MessageBox.Show("Aucun fichier selectionné!", "Fichier Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //MessageBox.Show(fichier[0]); //TODO remove after debugging            
        }


        public void Valider(string[] feuilleTemps)
        {
            // Extraction du numéro d'employe et des donnees de la feuille de temps
            JObject input = JObject.Parse(feuilleTemps[0]);
                
            // Extract employee number 
            int numeroEmploye = (int)input["numeroEmploye"];

            //Extract timesheet data for each day
            JArray jour1 = (JArray)input["jour1"];
            JArray jour2 = (JArray)input["jour2"];
            JArray jour3 = (JArray)input["jour3"];
            JArray jour4 = (JArray)input["jour4"];
            JArray jour5 = (JArray)input["jour5"];
            JArray weekend1 = (JArray)input["weekend1"];
            JArray weekend2 = (JArray)input["weekend2"];
            JArray timesheetData = new JArray(jour1, jour2, jour3, jour4, jour5, weekend1, weekend2);
            JArray timesheetJours = new JArray(jour1, jour2, jour3, jour4, jour5);
            JArray timesheetWeekend = new JArray(weekend1, weekend2);

            // Validation des donnees de la feuille de temps
            errors = new JArray();

            // Règle 1 : L'employe doit travailler un nombre minimum d'heures au bureau par semaine
            int totalMinutes = 0;
            if (numeroEmploye<1000) {
                foreach (JArray day in timesheetData)
                {
                    foreach (JObject entry in day) {
                        if ((int)entry["projet"] < (900)) { 
                            totalMinutes += (int)entry["minutes"];
                        }
                    }
                }

                if (totalMinutes < (36*60))
                {
                    errors.Add("L'employé d'administration n'a pas travaillé le nombre minimal d'heures eu bureau");
                }
            }

            // Règle 2 : Les employés normaux doivent travailler au moins 38 heures au bureau par semaine (excluant le télétravail)
            totalMinutes = 0;
            if (numeroEmploye>1000) {
                foreach (JArray day in timesheetData) {
                    foreach (JObject entry in day) {
                        if ((int)entry["projet"] < (900)) {
                            totalMinutes += (int)entry["minutes"];
                        }
                    }
                }

                if (totalMinutes < (38*60)) {
                    errors.Add("L'employé normal n'a pas travaillé le nombre minimal d'heures eu bureau");
                }
            }
            // Règle 3 : Aucun employé n'a le droit de passer plus de 43 heures au bureau.
            totalMinutes = 0;
            foreach (JArray day in timesheetData) {
                foreach (JObject entry in day) {
                    if ((int)entry["projet"] < (900)) {
                        totalMinutes += (int)entry["minutes"];
                    }
                }
            }

            if (totalMinutes > (43*60)) {
                errors.Add("L'employé a travaillé trop d'heures eu bureau");
            }

            // Règle 4 : Les employés de l'administration ne doivent pas faire plus de 10 heures de télétravail par semaine.
            if (numeroEmploye<1000) {
                int telecommutingMinutes = 0;
                foreach (JArray day in timesheetData) {
                    foreach (JObject entry in day) {
                        if ((int)entry["projet"] >= (900)) {
                            telecommutingMinutes += (int)entry["minutes"];
                        }
                    }
                }

                if (telecommutingMinutes > (10*60)) {
                    errors.Add("L'employé d'administration a dépassé la durée autorisée pour le travail à distance");
                }
            }

            // Règle 5 : Les employés normaux peuvent faire autant de télétravail qu'ils le souhaitent.
            //rien a verifier

            // Règle 6 : Les employés normaux doivent faire un minimum quotidien de 6 heures au bureau pour les jours ouvrables
            //(lundi au vendredi). 
            if (numeroEmploye>1000) {
                totalMinutes = 0;
                foreach (JArray day in timesheetJours) {
                    foreach (JObject entry in day) {
                        if ((int)entry["projet"] < (900)) {
                            totalMinutes += (int)entry["minutes"];
                        }
                    }
                }

                if (totalMinutes < (6*5*60)) {
                    errors.Add("L'employé normal n'a pas travaillé le minimum quotidien d'heures au bureau");
                }
            }

            // Règle 7 : Les employés de l'administration doivent faire un minimum quotidien de 4 heures au bureau pour les jours
            //ouvrables
            if (numeroEmploye<1000) {
                totalMinutes = 0;
                foreach (JArray day in timesheetJours) {
                    foreach (JObject entry in day) {
                        if ((int)entry["projet"] < (900)) {
                            totalMinutes += (int)entry["minutes"];
                        }
                    }
                }

                if (totalMinutes < (4*5*60)) {
                    errors.Add("L'employé d'administration n'a pas travaillé le minimum quotidien d'heures au bureau");
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Valider(fichierOuvert);
            rtbAffiche.Text = errors.ToString();
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            // Display the save file dialog and get the selected file path
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            string outputFilePath = saveFileDialog1.FileName;

            // Écriture du fichier JSON de sortie
            if (outputFilePath != "")
            {
                File.WriteAllText(outputFilePath, errors.ToString());
            }
        }
    }
}



