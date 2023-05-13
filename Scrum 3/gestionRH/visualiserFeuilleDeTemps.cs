using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLibrary;
using File = System.IO.File;

namespace gestionRH {
    public partial class visualiserFeuilleDeTemps : Form {

        Employe employeLogin;
        FeuilleTempsGRH aFeuilleTempsGRH;
        public int numUtilisateur;
        public Projet projet = EntreeFeuilleDeTemps.projetEnCours;
        public String feuilleDeTempsComplet = EntreeFeuilleDeTemps.feuilleDeTempsComplet;
        public List<Projet> projetList = EntreeFeuilleDeTemps.projetList;
        public List<FeuilleTempsModel> feuilleList = InterfaceMenu.feuilleList;

        //JArray errors;
        Boolean isValidated = false;
        Boolean isErrorFree = false;

        public visualiserFeuilleDeTemps(Employe empLogin) {
            InitializeComponent();
            employeLogin = empLogin;
            numUtilisateur = employeLogin.numEmploye;

            aFeuilleTempsGRH = new FeuilleTempsGRH(empLogin);
            richTextBoxVisualiser.Text = feuilleDeTempsComplet;
        }


        private void buttonModifier_Click(object sender, EventArgs e) {
            EntreeFeuilleDeTemps.feuilleDeTempsComplet = "";
            this.Close();
        }

        private void selectSaveFileLocation() {
            // Display the save file dialog and get the selected file path
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            string outputFilePath = saveFileDialog1.FileName;
            // Écriture du fichier JSON de sortie
            if (outputFilePath != "") {
                File.WriteAllText(outputFilePath, feuilleDeTempsComplet);
            }
        }

        private void buttonSoumetre_Click(object sender, EventArgs e) {
            //if not validated, popup to warn
            if (!isValidated) {
                MessageBox.Show("vous devez valider votre feuille de temps avant de la soumettre");
                return;
            }
            //if validated with errors, popup to warn
            if (isErrorFree) {
                selectSaveFileLocation();
            } else {
                var submitAnyways = MessageBox.Show("Votre feuille de temps contient des erreurs. Voulez-vous quand même le soumettre ? ", "Sousmission feuille de temps", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                // Check the user's response
                if (submitAnyways == DialogResult.Yes) {
                    // If the user clicked "Yes", submit the timesheet
                    try
                    {
                        remplirFeuille();
                        projetList.Clear();
                        MessageBox.Show("Votre feuille de temps a été ajoutée avec succès!", "Feuille Créée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue, contactez votre technicien", "Erreur Inattendue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    selectSaveFileLocation();
                } else {
                    // If the user clicked "No", do nothing
                    return;
                }
            }
            EntreeFeuilleDeTemps refresh = new EntreeFeuilleDeTemps(employeLogin);
            refresh.refreshFeuille();
        }

        private void buttonValider_Click(object sender, EventArgs e) {
            string[] feuilleDeTempsToValidate = new string[] { feuilleDeTempsComplet };
            aFeuilleTempsGRH.Valider(feuilleDeTempsToValidate);
            //display results
            richTextBoxVisualiser.Text = aFeuilleTempsGRH.errors.ToString();
            isValidated = true;
            if (aFeuilleTempsGRH.errors.Count == 0) {
                isErrorFree = true;
            }
        }

        private void remplirFeuille()
        {
            List<EmployeModel> employeList = new List<EmployeModel>();
            employeList = SqliteDataAccess.LoadEmploye();
            
            foreach (Projet sauvegarde in projetList)
            {
                //remplir la feuille de temps avec les données de la BD
                FeuilleTempsModel genereFeuilleTemps = new FeuilleTempsModel();
                
                genereFeuilleTemps.feuilleID = sauvegarde.feuilleID;
                genereFeuilleTemps.employeID = employeLogin.numEmploye;
                genereFeuilleTemps.projetID = sauvegarde.projetID;

                foreach (EmployeModel user in employeList)
                {
                    if (employeLogin.numEmploye == user.employeID)
                    {
                        feuilleList = SqliteDataAccess.LoadFeuille(user);
                    }
                }
                //if update, add existing values
                foreach (FeuilleTempsModel feuille in feuilleList)
                {
                    if (feuille.projetID == genereFeuilleTemps.projetID && feuille.feuilleID == genereFeuilleTemps.feuilleID)
                    {
                        sauvegarde.feuilleTemps.jour1 += feuille.lundi;
                        sauvegarde.feuilleTemps.jour2 += feuille.mardi;
                        sauvegarde.feuilleTemps.jour3 += feuille.mercredi;
                        sauvegarde.feuilleTemps.jour4 += feuille.jeudi;
                        sauvegarde.feuilleTemps.jour5 += feuille.vendredi;
                        sauvegarde.feuilleTemps.weekend1 += feuille.samedi;
                        sauvegarde.feuilleTemps.weekend2 += feuille.dimanche;
                    }                    
                }
                //insert values
                genereFeuilleTemps.lundi = sauvegarde.feuilleTemps.jour1;
                genereFeuilleTemps.mardi = sauvegarde.feuilleTemps.jour2;
                genereFeuilleTemps.mercredi = sauvegarde.feuilleTemps.jour3;
                genereFeuilleTemps.jeudi = sauvegarde.feuilleTemps.jour4;
                genereFeuilleTemps.vendredi = sauvegarde.feuilleTemps.jour5;
                genereFeuilleTemps.samedi = sauvegarde.feuilleTemps.weekend1;
                genereFeuilleTemps.dimanche = sauvegarde.feuilleTemps.weekend2;

                SqliteDataAccess.SaveFeuille(genereFeuilleTemps);
            }            
        }
    }
}
