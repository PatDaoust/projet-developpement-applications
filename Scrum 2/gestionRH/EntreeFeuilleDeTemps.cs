﻿using Newtonsoft.Json.Linq;
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

namespace gestionRH {
    public partial class EntreeFeuilleDeTemps : Form {

        public static ArrayList jour1 = new ArrayList();
        public static ArrayList jour2 = new ArrayList();
        public static ArrayList jour3 = new ArrayList();
        public static ArrayList jour4 = new ArrayList();
        public static ArrayList jour5 = new ArrayList();
        public static ArrayList weekend1 = new ArrayList();
        public static ArrayList weekend2 = new ArrayList();
        public static string feuilleDeTempsComplet = "";
        public static object choixMois;
        public static object choixJour;
        public Employe employeLogin;
        public int numUtilisateur;

        public EntreeFeuilleDeTemps(Employe empLogin) {
            InitializeComponent();
            employeLogin = empLogin;
            numUtilisateur = employeLogin.numEmploye;
            employeLogin.feuilleTemps.jour1 = jour1;
            employeLogin.feuilleTemps.jour1 = jour2;
            employeLogin.feuilleTemps.jour1 = jour3;
            employeLogin.feuilleTemps.jour1 = jour4;
            employeLogin.feuilleTemps.jour1 = jour5;
            employeLogin.feuilleTemps.weekend1 = weekend1;
            employeLogin.feuilleTemps.weekend2 = weekend2;
            textBoxNumeroEmployee.Text = numUtilisateur.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            choixMois = comboBoxMois.SelectedItem;
            if(comboBoxJourDuMois.SelectedItem == null)
            {
                comboBoxJourDuMois.Select(0,0);
            }
            else
            {
                choixJour = comboBoxJourDuMois.SelectedItem;
            }
            
            if (comboBoxMois.SelectedItem.ToString() == "Janvier") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Février") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 28; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
                if (comboBoxMois.SelectedItem.ToString() == "Mars") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Avril") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 30; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Mai") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Juin") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 30; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Juillet") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Août") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Septembre") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 30; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Octobre") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Novembre") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 30; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
            if (comboBoxMois.SelectedItem.ToString() == "Décembre") {
                comboBoxJourDuMois.Items.Clear();
                for (int i = 1; i <= 31; i++) {
                    comboBoxJourDuMois.Items.Add(i);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void textBoxNumeroEmployee_Leave(object sender, EventArgs e) {
            int numUtilisateur;
            try {
                numUtilisateur = Convert.ToInt32(textBoxNumeroEmployee.Text);
            } catch {
                MessageBox.Show("Ce numéro d'employé n'est pas valide", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxJour1Minutes_Leave(object sender, EventArgs e) {
            int minutes;
            try {
                minutes = Convert.ToInt32(textBoxJour1Projet.Text);
            } catch {
                MessageBox.Show("La valeur de minutes doit etre un nombre entier plus que 0", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxJour1Projet_Leave(object sender, EventArgs e) {
            int codeProjet;
            try {
                codeProjet = Convert.ToInt32(textBoxJour1Minutes.Text);
            } catch {
                MessageBox.Show("La valeur du code de projet doit etre un nombre entier plus que 0", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonAjouterJour1_Click(object sender, EventArgs e) {
            String ligneProjet = @" ""projet"": " + textBoxJour1Projet.Text + "," ;
            String ligneMinutes = @" ""minutes"": " + textBoxJour1Minutes.Text;
            String entry = "";
            entry += Environment.NewLine;
            entry+= "{";
            entry+= Environment.NewLine;
            entry+= ligneProjet + Environment.NewLine + ligneMinutes;
            entry+= Environment.NewLine;
            entry+= "},";
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
                    }                    
                }
                if (comboBoxJours.SelectedItem.ToString() == "jour2")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        jour2.Add(entry);
                    }
                }
                if (comboBoxJours.SelectedItem.ToString() == "jour3")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        jour3.Add(entry);
                    }
                }
                if (comboBoxJours.SelectedItem.ToString() == "jour4")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        jour4.Add(entry);
                    }
                }
                if (comboBoxJours.SelectedItem.ToString() == "jour5")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        jour5.Add(entry);
                    }
                }
                if (comboBoxJours.SelectedItem.ToString() == "weekend1")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        weekend1.Add(entry);
                    }
                }
                if (comboBoxJours.SelectedItem.ToString() == "weekend2")
                {
                    if (textBoxJour1Projet.Text != "" && textBoxJour1Minutes.Text != "")
                    {
                        weekend2.Add(entry);
                    }
                }
            }
            //clear textboxes
            textBoxJour1Projet.Text = "";
            textBoxJour1Minutes.Text = "";
        }

        private int calculateDayOfYear() {
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
                for (int i = 0; i < Array.IndexOf(frenchCultureInfo.DateTimeFormat.MonthNames, month.ToLower()); i++) {
                    dayOfYear += daysInMonth[i];
                }
                dayOfYear += day;

                return dayOfYear;
            }
        }

        private void assembleFeuilleDeTemps() {

            feuilleDeTempsComplet = "{" ;
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
            feuilleDeTempsComplet +=   @" ""numeroEmploye"":";
            feuilleDeTempsComplet += textBoxNumeroEmployee.Text;
            feuilleDeTempsComplet +=",";
            //jour1
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +=@" ""jour1"": [ ";
            foreach (var item in jour1) {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +="], ";
            //jour2
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +=@" ""jour2"": [ ";
            foreach (var item in jour2) {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +="], ";
            //jour3
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +=@" ""jour3"": [ ";
            foreach (var item in jour3) {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +="], ";
            //jour4
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +=@" ""jour4"": [ ";
            foreach (var item in jour4) {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +="], ";
            //jour5
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +=@" ""jour5"": [ ";
            foreach (var item in jour5) {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +="], ";
            //weekend1
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +=@" ""weekend1"": [ ";
            foreach (var item in weekend1) {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +="], ";
            //weekend2
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +=@" ""weekend2"": [ ";
            foreach (var item in weekend2) {
                feuilleDeTempsComplet += item.ToString();
            }
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet +="], ";
            //fin
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "}";
        }

        private void buttonVisualiser_Click(object sender, EventArgs e) {
            //call function to put together feuille de temp
            assembleFeuilleDeTemps();
            //call new window
            visualiserFeuilleDeTemps feuilleTemps = new visualiserFeuilleDeTemps(employeLogin);
            feuilleTemps.ShowDialog();
            
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
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
        private String getProjectNum(String input) {
            Regex regex = new Regex(@"\d+");
            Match match = regex.Match(input);

            if (match.Success) {
                string result = match.Value;
                return result;
            }
            return "";
        }

        private void comboBoxSupprimerJour_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour1") {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < jour1.Count; i++) {
                    string projetNum = getProjectNum(jour1[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour2") {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < jour2.Count; i++) {
                    string projetNum = getProjectNum(jour2[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour3") {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < jour3.Count; i++) {
                    string projetNum = getProjectNum(jour3[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour4") {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < jour4.Count; i++) {
                    string projetNum = getProjectNum(jour4[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "jour5") {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < jour5.Count; i++) {
                    string projetNum = getProjectNum(jour5[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "weekend1") {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < weekend1.Count; i++) {
                    string projetNum = getProjectNum(weekend1[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
            if (comboBoxSupprimerJour.SelectedItem.ToString() == "weekend2") {
                comboBoxSuprimerProjet.Items.Clear();
                for (int i = 0; i < weekend2.Count; i++) {
                    string projetNum = getProjectNum(weekend2[i].ToString());
                    comboBoxSuprimerProjet.Items.Add(i + ". " + projetNum);
                }
            }
        }

        private void comboBoxJourDuMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            choixMois = comboBoxMois.SelectedItem;
            choixJour = comboBoxJourDuMois.SelectedItem;
        }
    }
}
