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
        public EntreeFeuilleDeTemps() {
            InitializeComponent();
            textBoxNumeroEmployee.Text = LoginGRH.numUtilisateur.ToString();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
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
            //add to correct arraylist
            if (comboBoxJours.SelectedItem.ToString() == "jour1") {
                jour1.Add(entry);
            }
            if (comboBoxJours.SelectedItem.ToString() == "jour2") {
                jour2.Add(entry);
            }
            if (comboBoxJours.SelectedItem.ToString() == "jour3") {
                jour3.Add(entry);
            }
            if (comboBoxJours.SelectedItem.ToString() == "jour4") {
                jour4.Add(entry);
            }
            if (comboBoxJours.SelectedItem.ToString() == "jour5") {
                jour5.Add(entry);
            }
            if (comboBoxJours.SelectedItem.ToString() == "weekend1") {
                weekend1.Add(entry);
            }
            if (comboBoxJours.SelectedItem.ToString() == "weekend2") {
                weekend2.Add(entry);
            }
            //clear textboxes
            textBoxJour1Projet.Text = "";
            textBoxJour1Minutes.Text = "";
        }

        private int calculateDayOfYear() {
            {
                string month = comboBoxMois.SelectedText;
                int day = 0;
                int.TryParse(comboBoxJourDuMois.SelectedText, out day);

                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int dayOfYear = 0;

                // Calculate day of the year
                for (int i = 0; i < Array.IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.MonthNames, month.ToLower()); i++) {
                    dayOfYear += daysInMonth[i];
                }
                dayOfYear += day;

                return dayOfYear;
            }
        }
        private void assembleFeuilleDeTemps() {
            feuilleDeTempsComplet += "{" ;
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += @" ""jourAnnee"": ";
            feuilleDeTempsComplet += calculateDayOfYear();
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
            //feuilleDeTempsComplet +=
            //fin
            feuilleDeTempsComplet += Environment.NewLine;
            feuilleDeTempsComplet += "}";
        }

        private void buttonVisualiser_Click(object sender, EventArgs e) {
            //call function to put together feuille de temp
            assembleFeuilleDeTemps();
            //call new window
            visualiserFeuilleDeTemps feuilleTemps = new visualiserFeuilleDeTemps();
            feuilleTemps.ShowDialog();
        }

        private void EntreeFeuilleDeTemps_Load(object sender, EventArgs e) {

        }
    }
}
