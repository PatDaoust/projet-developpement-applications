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
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using System.Linq.Expressions;
using DBLibrary;
using FastMember;
using System.Runtime.InteropServices;

namespace gestionRH
{
    public partial class FeuilleTempsGRH : Form
    {
        public int numUtilisateur;
        string fichierSelection;
        string[] fichierOuvert;
        public JArray errors;
        int jourID, projetID, lundi, mardi, mercredi, jeudi, vendredi, samedi, dimanche;
        Employe employeLogin;
        public List<FeuilleTempsModel> feuilleList = InterfaceMenu.feuilleList;
        public string feuilleDeTempsComplet = "";
        String[] valideString;


        public FeuilleTempsGRH(Employe empLogin)
        {
            InitializeComponent();
            employeLogin = empLogin;
            numUtilisateur = employeLogin.numEmploye;
            txbNumUtilisateur.Text = numUtilisateur.ToString();
            remplirTable();
        }

        public void remplirTable()
        {
            List<EmployeModel> employeList = new List<EmployeModel>();
            employeList = SqliteDataAccess.LoadEmploye();
            foreach (EmployeModel user in employeList)
            {
                if (employeLogin.numEmploye == user.employeID)
                {
                    feuilleList = SqliteDataAccess.LoadFeuille(user);
                }
            }
            //Fill the Data Table
            IEnumerable<FeuilleTempsModel> data = feuilleList;
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(data))
            {
                table.Load(reader);
            }
            dgvFeuillesTempsAdmin.DataSource = data;
        }

        public void chargeFeuile()
        {
            List<EmployeModel> employeList = new List<EmployeModel>();
            employeList = SqliteDataAccess.LoadEmploye();

            foreach (EmployeModel user in employeList)
            {
                if (numUtilisateur == user.employeID)
                {
                    feuilleList = SqliteDataAccess.LoadFeuille(user);
                }
            }

            EntreeFeuilleDeTemps.jour1.Clear();
            EntreeFeuilleDeTemps.jour2.Clear();
            EntreeFeuilleDeTemps.jour3.Clear();
            EntreeFeuilleDeTemps.jour4.Clear();
            EntreeFeuilleDeTemps.jour5.Clear();
            EntreeFeuilleDeTemps.weekend1.Clear();
            EntreeFeuilleDeTemps.weekend2.Clear();

            FeuilleTempsModel feuilleTemps = new FeuilleTempsModel();

            feuilleTemps.projetID = projetID;
            EntreeFeuilleDeTemps.jour1.Add(EntreeFeuilleDeTemps.ajoutEntree(feuilleTemps.projetID, lundi));
            EntreeFeuilleDeTemps.jour2.Add(EntreeFeuilleDeTemps.ajoutEntree(feuilleTemps.projetID, mardi));
            EntreeFeuilleDeTemps.jour3.Add(EntreeFeuilleDeTemps.ajoutEntree(feuilleTemps.projetID, mercredi));
            EntreeFeuilleDeTemps.jour4.Add(EntreeFeuilleDeTemps.ajoutEntree(feuilleTemps.projetID, jeudi));
            EntreeFeuilleDeTemps.jour5.Add(EntreeFeuilleDeTemps.ajoutEntree(feuilleTemps.projetID, vendredi));
            EntreeFeuilleDeTemps.weekend1.Add(EntreeFeuilleDeTemps.ajoutEntree(feuilleTemps.projetID, samedi));
            EntreeFeuilleDeTemps.weekend2.Add(EntreeFeuilleDeTemps.ajoutEntree(feuilleTemps.projetID, dimanche));
            assembleFeuilleDeTemps();
        }
        private void assembleFeuilleDeTemps()
        {
            feuilleDeTempsComplet = "{";
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jourAnnee"": ";
            feuilleDeTempsComplet += jourID;

            feuilleDeTempsComplet += ",";
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""numeroEmploye"":";
            feuilleDeTempsComplet += numUtilisateur;
            feuilleDeTempsComplet += ",";
            //jour1
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jour1"": [ ";
            foreach (var item in EntreeFeuilleDeTemps.jour1)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //jour2
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jour2"": [ ";
            foreach (var item in EntreeFeuilleDeTemps.jour2)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //jour3
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jour3"": [ ";
            foreach (var item in EntreeFeuilleDeTemps.jour3)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //jour4
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jour4"": [ ";
            foreach (var item in EntreeFeuilleDeTemps.jour4)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //jour5
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jour5"": [ ";
            foreach (var item in EntreeFeuilleDeTemps.jour5)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //weekend1
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""weekend1"": [ ";
            foreach (var item in EntreeFeuilleDeTemps.weekend1)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //weekend2
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""weekend2"": [ ";
            foreach (var item in EntreeFeuilleDeTemps.weekend2)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //fin
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "}";
        }

        public void LireString(string lecture)
        {
            string fileContent = lecture;
            //transform the string into usable format
            fichierOuvert = fileContent.Split(new char[] { ';' });
            rtbAffiche.Text = feuilleDeTempsComplet;
        }
        private void btnOuvrir_Click(object sender, EventArgs e)
        {

            string affiche = "Feuille de temps #:" + jourID + ", Projet #:" + projetID;
            txbFichierOuvert.Text = affiche;

            feuilleDeTempsComplet = "";
            chargeFeuile();
            LireString(feuilleDeTempsComplet);
            /*
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
            }*/

            //MessageBox.Show(fichier[0]); //TODO remove after debugging            
        }

        public void regle1(int numeroEmploye, JArray timesheetData)
        {
            // Règle 1 : L'employe d'administration doit travailler un nombre minimum d'heures au bureau par semaine
            int totalMinutes = 0;
            if (numeroEmploye < 1000)
            {
                foreach (JArray day in timesheetData)
                {
                    foreach (JObject entry in day)
                    {
                        if ((int)entry["projet"] < (900) && (int)entry["projet"] != 997 && (int)entry["projet"] != 996)
                        {
                            totalMinutes += (int)entry["minutes"];
                        }
                        else if ((int)entry["projet"] == 997 || (int)entry["projet"] == 996)
                        {
                            totalMinutes += (int)entry["minutes"] / 2;
                        }
                    }
                }
                if (totalMinutes < (40 * 60))
                {
                    errors.Add("L'employé d'administration n'a pas travaillé le nombre minimal d'heures au bureau");
                }
            }
        }

        public void regle2production(int numeroEmploye, JArray timesheetData)
        {
            // Règle 2 : Les employés de production doivent travailler au moins 38 heures au bureau par semaine (excluant le télétravail)
            int totalMinutes = 0;
            if (numeroEmploye >= 1000 && numeroEmploye < 1000)
            {
                foreach (JArray day in timesheetData)
                {
                    foreach (JObject entry in day)
                    {
                        if ((int)entry["projet"] < (900) && (int)entry["projet"] != 997 && (int)entry["projet"] != 996)
                        {
                            totalMinutes += (int)entry["minutes"];
                        }
                        else if ((int)entry["projet"] == 997 || (int)entry["projet"] == 996)
                        {
                            totalMinutes += (int)entry["minutes"] / 2;
                        }
                    }
                }

                if (totalMinutes < (38 * 60))
                {
                    errors.Add("L'employé de production n'a pas travaillé le nombre minimal d'heures au bureau");
                }
            }
        }

        public void regle2exploitation(int numeroEmploye, JArray timesheetData)
        {
            // Règle 2 : Les employés d'exploitation doivent travailler au moins 40 heures au bureau par semaine (excluant le télétravail)
            int totalMinutes = 0;
            if (numeroEmploye >= 2000)
            {
                foreach (JArray day in timesheetData)
                {
                    foreach (JObject entry in day)
                    {
                        if ((int)entry["projet"] < (900) && (int)entry["projet"] != 997 && (int)entry["projet"] != 996)
                        {
                            totalMinutes += (int)entry["minutes"];
                        }
                        else if ((int)entry["projet"] == 997 || (int)entry["projet"] == 996)
                        {
                            totalMinutes += (int)entry["minutes"] / 2;
                        }
                    }
                }

                if (totalMinutes < (40 * 60))
                {
                    errors.Add("L'employé d'exploitation n'a pas travaillé le nombre minimal d'heures au bureau");
                }
            }
        }

        public void regle3(JArray timesheetData)
        {
            // Règle 3 : Aucun employé n'a le droit de passer plus de 43 heures au bureau.
            int totalMinutes = 0;
            foreach (JArray day in timesheetData)
            {
                foreach (JObject entry in day)
                {
                    if ((int)entry["projet"] < (900) && (int)entry["projet"] != 997 && (int)entry["projet"] != 996)
                    {
                        totalMinutes += (int)entry["minutes"];
                    }
                    else if ((int)entry["projet"] == 997 || (int)entry["projet"] == 996)
                    {
                        totalMinutes += (int)entry["minutes"] / 2;
                    }
                }
            }
            if (totalMinutes > (43 * 60))
            {
                errors.Add("L'employé a travaillé trop d'heures au bureau");
            }
        }

        public void regle4(int numeroEmploye, JArray timesheetData)
        {
            // Règle 4 : Les employés de l'administration ne doivent pas faire plus de 10 heures de télétravail par semaine.
            if (numeroEmploye < 1000)
            {
                int telecommutingMinutes = 0;
                foreach (JArray day in timesheetData)
                {
                    foreach (JObject entry in day)
                    {
                        if ((int)entry["projet"] >= (900))
                        {
                            telecommutingMinutes += (int)entry["minutes"];
                        }
                    }
                }
                if (telecommutingMinutes > 0)
                {
                    errors.Add("L'employé d'administration a dépassé la durée autorisée pour le travail à distance");
                }
            }
        }
        public void regle5()
        {
            //rien a verifier
        }
        public void regle6(int numeroEmploye, JArray timesheetJours)
        {
            // Règle 6 : Les employés normaux doivent faire un minimum quotidien de 6 heures au bureau pour les jours ouvrables
            //(lundi au vendredi). 
            int totalMinutes = 0;
            if (numeroEmploye > 1000)
            {
                totalMinutes = 0;
                foreach (JArray day in timesheetJours)
                {
                    foreach (JObject entry in day)
                    {
                        if ((int)entry["projet"] < (900) && (int)entry["projet"] != 997 && (int)entry["projet"] != 996)
                        {
                            totalMinutes += (int)entry["minutes"];
                        }
                        else if ((int)entry["projet"] == 997 || (int)entry["projet"] == 996)
                        {
                            totalMinutes += (int)entry["minutes"] / 2;
                        }
                    }
                }
                if (totalMinutes < (6 * 5 * 60))
                {
                    errors.Add("L'employé de production ou d'exploitation n'a pas travaillé le minimum quotidien d'heures au bureau");
                }
            }
        }
        public void regle7(int numeroEmploye, JArray timesheetJours)
        {
            int totalMinutes = 0;
            if (numeroEmploye < 1000)
            {
                foreach (JArray day in timesheetJours)
                {
                    foreach (JObject entry in day)
                    {
                        if ((int)entry["projet"] < (900) && (int)entry["projet"] != 997 && (int)entry["projet"] != 996)
                        {
                            totalMinutes += (int)entry["minutes"];
                        }
                        else if ((int)entry["projet"] == 997 || (int)entry["projet"] == 996)
                        {
                            totalMinutes += (int)entry["minutes"] / 2;
                        }
                    }
                }

                if (totalMinutes < (4 * 5 * 60))
                {
                    errors.Add("L'employé d'administration n'a pas travaillé le minimum quotidien d'heures au bureau");
                }
            }
        }

        public void regle24h(JArray timesheetData)
        {
            // Règle: le temps d'un employé pour une journée ne dépasse pas 24 heures
            int totalMinutes = 0;
            foreach (JArray day in timesheetData)
            {
                foreach (JObject entry in day)
                {
                    totalMinutes += (int)entry["minutes"];
                }
            }
            if (totalMinutes > (24 * 60))
            {
                errors.Add("L'employé a travaillé plus que 24 heures en une journee");
            }
        }

        public void regleMaladie(JArray timesheetJours, JArray timesheetWeekend)
        {
            // Règle: l'employé doit charger exactement 420 minutes dans le code de projet 999. 
            //Il n'est pas permis d'avoir d'autres activités professionnelles lors d'un congé de maladie
            //Il n'est pas permis d'utiliserles congés de maladie la fin de semaine
            foreach (JArray day in timesheetJours)
            {
                Boolean isSickDay = false;
                int minutesJour = 0;
                foreach (JObject entry in day)
                {
                    if ((int)entry["projet"] == (999))
                    {
                        isSickDay = true;
                        minutesJour += (int)entry["minutes"];
                    }
                    else
                    {
                        minutesJour += (int)entry["minutes"];
                    }
                }
                if (isSickDay && minutesJour > 420)
                {
                    errors.Add("L'employé a travaillé lors d'un congé de maladie");
                }
            }

            //if weekend, add error
            foreach (JArray day in timesheetWeekend)
            {
                foreach (JObject entry in day)
                {
                    if ((int)entry["projet"] == (999))
                    {
                        errors.Add("L'employé a pris un congé de maladie la fin de semaine");
                    }
                }
            }
        }

        public void regleFerie(JArray timesheetJours, JArray timesheetWeekend, int dayofYearMonday)
        {
            //Lors d'un congé férié, l'employé doit charger 420 minutes dans le code de projet 998.
            //Contrairement au congé de maladie, lors d'un congé férié, il est permis de faire du télétravail en plus durant la journée. 
            //Les 420 minutes sont considérées comme du temps de présence au bureau. 
            //Il n'est pas permis d'utiliser les congés fériés la fin de semaine.
            int dayofYear = dayofYearMonday;
            foreach (JArray day in timesheetJours)
            {
                foreach (JObject entry in day)
                {
                    if ((int)entry["projet"] == (998))
                    {
                        if (!isHoliday(dayofYear))
                        {
                            errors.Add("L'employé a pris un congé férié sur un jour non-férié");
                        }
                    }
                }
                dayofYear++;
            }

            //if weekend, add error
            foreach (JArray day in timesheetWeekend)
            {
                foreach (JObject entry in day)
                {
                    if ((int)entry["projet"] == (998))
                    {
                        errors.Add("L'employé a pris un congé férié la fin de semaine");
                    }
                }
            }
        }

        public void regleParental(JArray timesheetWeekend)
        {
            //une semaine de congé parental
            // le code de projet 995 à tous les jours, excluant le week-end
            //if weekend, add error
            foreach (JArray day in timesheetWeekend)
            {
                foreach (JObject entry in day)
                {
                    if ((int)entry["projet"] == (995))
                    {
                        errors.Add("L'employé a pris un congé parental la fin de semaine");
                    }
                }
            }
        }

        public void regleTransport(JArray timesheetJours)
        {
            //peut entrer le code 997 pour un maximum de 1 heure par jour
            //ou
            //peut entrer le code 996 pour un maximum de 1 heure par jour
            int minutesTransport = 0;
            foreach (JArray day in timesheetJours)
            {
                foreach (JObject entry in day)
                {
                    if ((int)entry["projet"] == (997))
                    {
                        minutesTransport += (int)entry["minutes"];
                    }
                    if ((int)entry["projet"] == (996))
                    {
                        minutesTransport += (int)entry["minutes"];
                    }
                }
                if (minutesTransport > 60)
                {
                    errors.Add("L'employé a pris plus qu'un heure de transport dans un jour");
                }
                minutesTransport = 0;
            }
        }


        public Boolean isHoliday(int dayofYear)
        {
            switch (dayofYear)
            {
                case 1:
                    //Jour de l'An 
                    return true;
                    break;
                case 97:
                    //Vendredi saint 
                    return true;
                    break;
                case 100:
                    //Lundi de Pâques
                    return true;
                    break;
                case 142:
                    //Fête de la Reine
                    return true;
                    break;
                case 175:
                    //Saint-Jean-Baptiste
                    return true;
                    break;
                case 182:
                    //Fête du Canada 
                    return true;
                    break;
                case 219:
                    //Jour férié
                    return true;
                    break;
                case 247:
                    //Fête du travail
                    return true;
                    break;
                case 273:
                    //Journée nationale de la vérité et de la réconciliation
                    return true;
                    break;
                case 282:
                    //Action de grâce
                    return true;
                    break;
                case 315:
                    //Jour du Souvenir
                    return true;
                    break;
                case 359:
                    //Noël
                    return true;
                    break;
                case 360:
                    //Lendemain de Noël 
                    return true;
                    break;
                default: //Optional
                    return false;
            }
        }

        public void Valider(string[] feuilleTemps)
        {
            // Extraction du numéro d'employe et des donnees de la feuille de temps
            if (feuilleTemps != null)
            {
                JObject input = JObject.Parse(feuilleTemps[0]);

                // Extract employee number and day of year 
                int numeroEmploye = (int)input["numeroEmploye"];
                int dayofYearMonday = (int)input["jourAnnee"];

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

                regle1(numeroEmploye, timesheetData);
                regle2production(numeroEmploye, timesheetData);
                regle2exploitation(numeroEmploye, timesheetData);
                regle3(timesheetData);
                regle4(numeroEmploye, timesheetData);
                regle5();
                regle6(numeroEmploye, timesheetJours);
                regle7(numeroEmploye, timesheetJours);
                regle24h(timesheetData);
                regleMaladie(timesheetJours, timesheetWeekend);
                regleFerie(timesheetJours, timesheetWeekend, dayofYearMonday);
                regleParental(timesheetWeekend);
                regleTransport(timesheetJours);
            }
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            Valider(fichierOuvert);
            if (fichierOuvert != null)
            {
                rtbAffiche.Text = errors.ToString();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une feuille dans la table avant de valider");
            }
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

        private void dgvFeuillesTempsAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            jourID = Convert.ToInt32(dgvFeuillesTempsAdmin.Rows[e.RowIndex].Cells[0].Value);
            projetID = Convert.ToInt32(dgvFeuillesTempsAdmin.Rows[e.RowIndex].Cells[2].Value);
            lundi = Convert.ToInt32(dgvFeuillesTempsAdmin.Rows[e.RowIndex].Cells[3].Value);
            mardi = Convert.ToInt32(dgvFeuillesTempsAdmin.Rows[e.RowIndex].Cells[4].Value);
            mercredi = Convert.ToInt32(dgvFeuillesTempsAdmin.Rows[e.RowIndex].Cells[5].Value);
            jeudi = Convert.ToInt32(dgvFeuillesTempsAdmin.Rows[e.RowIndex].Cells[6].Value);
            vendredi = Convert.ToInt32(dgvFeuillesTempsAdmin.Rows[e.RowIndex].Cells[7].Value);
            samedi = Convert.ToInt32(dgvFeuillesTempsAdmin.Rows[e.RowIndex].Cells[8].Value);
            dimanche = Convert.ToInt32(dgvFeuillesTempsAdmin.Rows[e.RowIndex].Cells[9].Value);
        }
    }
}