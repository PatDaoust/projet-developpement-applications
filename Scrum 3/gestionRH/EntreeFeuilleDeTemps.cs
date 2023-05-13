using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using DBLibrary;
using System.Security.Cryptography.X509Certificates;

namespace gestionRH
{
    public partial class EntreeFeuilleDeTemps : Form
    {

        public static ArrayList jour1 = new ArrayList();
        public static ArrayList jour2 = new ArrayList();
        public static ArrayList jour3 = new ArrayList();
        public static ArrayList jour4 = new ArrayList();
        public static ArrayList jour5 = new ArrayList();
        public static ArrayList weekend1 = new ArrayList();
        public static ArrayList weekend2 = new ArrayList();
        public static List<Projet> projetList = new List<Projet>();
        public static List<FeuilleTempsModel> feuilleList = InterfaceMenu.feuilleList;
        public static string feuilleDeTempsComplet = "";
        public static object choixMois;
        public static object choixJour;
        public Employe employeLogin;
        public static Projet projetEnCours;
        public int numUtilisateur;
        public int jourAn;

        public EntreeFeuilleDeTemps(Employe empLogin)
        {
            InitializeComponent();
            employeLogin = empLogin;
            numUtilisateur = employeLogin.numEmploye;
            textBoxNumeroEmployee.Text = numUtilisateur.ToString();
            refreshFeuille();
        }

        public void refreshFeuille()
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

            jour1.Clear();
            jour2.Clear();
            jour3.Clear();
            jour4.Clear();
            jour5.Clear();
            weekend1.Clear();
            weekend2.Clear();


            foreach (FeuilleTempsModel feuilleTemps in feuilleList)
            {
                jour1.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.lundi));
                jour2.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.mardi));
                jour3.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.mercredi));
                jour4.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.jeudi));
                jour5.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.vendredi));
                weekend1.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.samedi));
                weekend2.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.dimanche));
            }
        }

        public void refreshFeuille(Projet projetEnCours)
        {
            jour1.Clear();
            jour2.Clear();
            jour3.Clear();
            jour4.Clear();
            jour5.Clear();
            weekend1.Clear();
            weekend2.Clear();

            foreach (FeuilleTempsModel feuilleTemps in feuilleList)
            {
                jour1.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.lundi));
                jour2.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.mardi));
                jour3.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.mercredi));
                jour4.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.jeudi));
                jour5.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.vendredi));
                weekend1.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.samedi));
                weekend2.Add(ajoutEntree(feuilleTemps.projetID, feuilleTemps.dimanche));
            }
            foreach (Projet projet in projetList)
            {
                jour1.Add(ajoutEntree(projet.projetID, projet.feuilleTemps.jour1));
                jour2.Add(ajoutEntree(projet.projetID, projet.feuilleTemps.jour2));
                jour3.Add(ajoutEntree(projet.projetID, projet.feuilleTemps.jour3));
                jour4.Add(ajoutEntree(projet.projetID, projet.feuilleTemps.jour4));
                jour5.Add(ajoutEntree(projet.projetID, projet.feuilleTemps.jour5));
                weekend1.Add(ajoutEntree(projet.projetID, projet.feuilleTemps.weekend1));
                weekend2.Add(ajoutEntree(projet.projetID, projet.feuilleTemps.weekend2));
            }
        }

        public static string ajoutEntree(int projet, int minutes)
        {
            String ligneProjet = @" ""projet"": " + projet.ToString() + ",";
            String ligneMinutes = @" ""minutes"": " + minutes.ToString();
            String entry = "";
            entry += Environment.NewLine;
            entry += "{";
            entry += Environment.NewLine;
            entry += ligneProjet + Environment.NewLine + ligneMinutes;
            entry += Environment.NewLine;
            entry += "},";
            return entry;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choixMois = comboBoxMois.SelectedItem;
            if (comboBoxJourDuMois.SelectedItem == null)
            {
                comboBoxJourDuMois.Select(0, 0);
            }
            else
            {
                choixJour = comboBoxJourDuMois.SelectedItem;
            }

            if (comboBoxMois.SelectedItem.ToString() == "Janvier")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Février")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 28; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Mars")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Avril")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Mai")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Juin")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Juillet")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Août")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Septembre")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Octobre")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Novembre")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Décembre")
            {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            refreshFeuille();
        }

        private void textBoxNumeroEmployee_Leave(object sender, EventArgs e)
        {
            int numUtilisateur;
            try
            {
                numUtilisateur = Convert.ToInt32(textBoxNumeroEmployee.Text);
            }
            catch
            {
                MessageBox.Show("Ce numéro d'employé n'est pas valide", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxJour1Minutes_Leave(object sender, EventArgs e)
        {
            int minutes;
            try
            {
                minutes = Convert.ToInt32(textBoxJour1Projet.Text);
            }
            catch
            {
                MessageBox.Show("La valeur de minutes doit etre un nombre entier plus que 0", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxJour1Projet_Leave(object sender, EventArgs e)
        {
            int codeProjet;
            try
            {
                codeProjet = Convert.ToInt32(textBoxJour1Minutes.Text);
            }
            catch
            {
                MessageBox.Show("La valeur du code de projet doit etre un nombre entier plus que 0", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonAjouterJour1_Click(object sender, EventArgs e)
        {
            if (choixMois != null && choixJour != null)
            {
                jourAn = calculateDayOfYear();
            }
            else
            {
                MessageBox.Show("Date absente, veuiller réviser");
            }
            int projetEntreID = 0;
            int minutesEntreID = 0;

            if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
            {
                try
                {
                    projetEntreID = Convert.ToInt32(textBoxJour1Projet.Text);
                    minutesEntreID = Convert.ToInt32(textBoxJour1Minutes.Text);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Veuillez remplir tous les champs", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            FeuilleTemps feuilleEnCours = new FeuilleTemps();
            projetEnCours = new Projet(jourAn, projetEntreID, employeLogin, feuilleEnCours);

            String entry = ajoutEntree(projetEntreID, minutesEntreID);

            if (comboBoxJours.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //add to correct arraylist
                if (comboBoxJours.SelectedItem.ToString() == "jour1")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        jour1.Add(entry);
                        projetEnCours.feuilleTemps.jour1 = minutesEntreID;
                    }
                }
                if (comboBoxJours.SelectedItem.ToString() == "jour2")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        jour2.Add(entry);
                        projetEnCours.feuilleTemps.jour2 = minutesEntreID;
                    }
                }
                if (comboBoxJours.SelectedItem.ToString() == "jour3")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        jour3.Add(entry);
                        projetEnCours.feuilleTemps.jour3 = minutesEntreID;
                    }
                }
                if (comboBoxJours.SelectedItem.ToString() == "jour4")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        jour4.Add(entry);
                        projetEnCours.feuilleTemps.jour4 = minutesEntreID;
                    }
                }
                if (comboBoxJours.SelectedItem.ToString() == "jour5")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        jour5.Add(entry);
                        projetEnCours.feuilleTemps.jour5 = minutesEntreID;
                    }
                }
                if (comboBoxJours.SelectedItem.ToString() == "weekend1")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        weekend1.Add(entry);
                        projetEnCours.feuilleTemps.weekend1 = minutesEntreID;
                    }
                }
                if (comboBoxJours.SelectedItem.ToString() == "weekend2")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        weekend2.Add(entry);
                        projetEnCours.feuilleTemps.weekend2 = minutesEntreID;
                    }
                }
            }
            projetList.Add(projetEnCours);
            refreshFeuille(projetEnCours);
            //clear textboxes
            textBoxJour1Projet.Text = "";
            textBoxJour1Minutes.Text = "";
        }

        private int calculateDayOfYear()
        {
            {
                string month = choixMois.ToString();
                int day = Convert.ToInt32(choixJour.ToString());

                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                int year = DateTime.Now.Year;
                if (DateTime.IsLeapYear(year))
                {
                    daysInMonth[1] = 29; // If it is a leap year, set February to have 29 days.
                }

                int dayOfYear = 0;
                var frenchCultureInfo = new CultureInfo("fr-FR");

                // Calculate day of the year
                for (int i = 0; i < Array.IndexOf(frenchCultureInfo.DateTimeFormat.MonthNames, month.ToLower()); i++)
                {
                    dayOfYear += daysInMonth[i];
                }
                dayOfYear += day;

                return dayOfYear;
            }
        }

        private void assembleFeuilleDeTemps()
        {
            feuilleDeTempsComplet = "{";
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jourAnnee"": ";
            if (choixMois != null && choixJour != null)
            {
                feuilleDeTempsComplet += calculateDayOfYear();
            }
            else
            {
                MessageBox.Show("Date absente, veuiller réviser");
            }
            feuilleDeTempsComplet += ",";
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""numeroEmploye"":";
            feuilleDeTempsComplet += textBoxNumeroEmployee.Text;
            feuilleDeTempsComplet += ",";
            //jour1
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jour1"": [ ";
            foreach (var item in jour1)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //jour2
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jour2"": [ ";
            foreach (var item in jour2)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //jour3
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jour3"": [ ";
            foreach (var item in jour3)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //jour4
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jour4"": [ ";
            foreach (var item in jour4)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //jour5
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jour5"": [ ";
            foreach (var item in jour5)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //weekend1
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""weekend1"": [ ";
            foreach (var item in weekend1)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //weekend2
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""weekend2"": [ ";
            foreach (var item in weekend2)
            {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "], ";
            //fin
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "}";
        }

        private void buttonVisualiser_Click(object sender, EventArgs e)
        {
            //call function to put together feuille de temps
            assembleFeuilleDeTemps();

            //call new window
            visualiserFeuilleDeTemps feuilleTemps = new visualiserFeuilleDeTemps(employeLogin);
            feuilleTemps.ShowDialog();

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            List<EmployeModel> employeList = new List<EmployeModel>();
            employeList = SqliteDataAccess.LoadEmploye();
            FeuilleTempsModel genereFeuilleTemps = new FeuilleTempsModel();
            int projetEntreID = 0;
            try
            {
                projetEntreID = Convert.ToInt32(comboBoxSuprimerProjet.Text);
            }
            catch
            {
                MessageBox.Show("Veuillez entrer un numéro de projet valide", "Numéro de projet invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            genereFeuilleTemps.feuilleID = calculateDayOfYear();
            genereFeuilleTemps.employeID = employeLogin.numEmploye;
            genereFeuilleTemps.projetID = projetEntreID;

            foreach (EmployeModel user in employeList)
            {
                if (employeLogin.numEmploye == user.employeID)
                {
                    feuilleList = SqliteDataAccess.LoadFeuille(user);
                }
            }
            foreach (FeuilleTempsModel feuille in feuilleList)
            {
                if (feuille.projetID == genereFeuilleTemps.projetID && feuille.feuilleID == genereFeuilleTemps.feuilleID)
                {
                    SqliteDataAccess.deleteProjet(genereFeuilleTemps);
                }
            }
            try
            {
                if (comboBoxSupprimerJour.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez remplir tous les champs", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //read selected array from comboBoxSupprimerJour
                    if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour1")
                    {
                        //remove item from corresponding array/index
                        jour1.RemoveAt(comboBoxSuprimerProjet.SelectedIndex);
                    }
                    if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour2")
                    {
                        //remove item from corresponding array/index
                        jour2.RemoveAt(comboBoxSuprimerProjet.SelectedIndex);
                    }
                    if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour3")
                    {
                        //remove item from corresponding array/index
                        jour3.RemoveAt(comboBoxSuprimerProjet.SelectedIndex);
                    }
                    if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour4")
                    {
                        //remove item from corresponding array/index
                        jour4.RemoveAt(comboBoxSuprimerProjet.SelectedIndex);
                    }
                    if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour5")
                    {
                        //remove item from corresponding array/index
                        jour5.RemoveAt(comboBoxSuprimerProjet.SelectedIndex);
                    }
                    if (comboBoxSupprimerJour.SelectedItem.ToString() == "weekend1")
                    {
                        //remove item from corresponding array/index
                        weekend1.RemoveAt(comboBoxSuprimerProjet.SelectedIndex);
                    }
                    if (comboBoxSupprimerJour.SelectedItem.ToString() == "weekend2")
                    {
                        //remove item from corresponding array/index
                        weekend2.RemoveAt(comboBoxSuprimerProjet.SelectedIndex);
                    }
                    comboBoxSuprimerProjet.SelectedIndex = -1;
                    comboBoxSuprimerProjet.Items.Clear();
                }
            }
            catch { }
        }
        private String getProjectNum(String input)
        {
            Regex regex = new Regex(@"\d+");
            Match match = regex.Match(input);

            if (match.Success)
            {
                string result = match.Value;
                return result;
            }
            return "";
        }

        private void comboBoxSupprimerJour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour1")
            {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < jour1.Count; i++)
                {
                    string projetNum = getProjectNum(jour1[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour2")
            {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < jour2.Count; i++)
                {
                    string projetNum = getProjectNum(jour2[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour3")
            {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < jour3.Count; i++)
                {
                    string projetNum = getProjectNum(jour3[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour4")
            {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < jour4.Count; i++)
                {
                    string projetNum = getProjectNum(jour4[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour5")
            {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < jour5.Count; i++)
                {
                    string projetNum = getProjectNum(jour5[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "weekend1")
            {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < weekend1.Count; i++)
                {
                    string projetNum = getProjectNum(weekend1[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "weekend2")
            {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < weekend2.Count; i++)
                {
                    string projetNum = getProjectNum(weekend2[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
        }

        private void comboBoxJourDuMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            choixMois = comboBoxMois.SelectedItem;
            choixJour = comboBoxJourDuMois.SelectedItem;
            refreshFeuille();
        }

        private void buttonAutofill_Click(object sender, EventArgs e)
        {
            //take jour1, pour remplir jour2 a jour5 
            jour2 = jour1;
            jour3 = jour1;
            jour4 = jour1;
            jour5 = jour1;
        }

        private void textBoxJour1Minutes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
