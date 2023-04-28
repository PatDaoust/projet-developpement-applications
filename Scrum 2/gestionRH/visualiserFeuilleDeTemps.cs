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
using File = System.IO.File;

namespace gestionRH {
    public partial class visualiserFeuilleDeTemps : Form {

        FeuilleTempsGRH aFeuilleTempsGRH = new FeuilleTempsGRH();
        public int numUtilisateur = InterfaceAdmin.numUtilisateur;
        public ArrayList feuilleJour1 = EntreeFeuilleDeTemps.jour1;
        public String feuilleDeTempsComplet = EntreeFeuilleDeTemps.feuilleDeTempsComplet;
        //JArray errors;
        Boolean isValidated = false;
        Boolean isErrorFree = false;

        public visualiserFeuilleDeTemps() {
            InitializeComponent();
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
                File.WriteAllText(outputFilePath, aFeuilleTempsGRH.errors.ToString());
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
                var submitAnyways = MessageBox.Show("Votre feuille de temps contient des erreurs. Voulez-vous quand même le soumettre ? ", "Sousmission feuille de temps", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                // Check the user's response
                if (submitAnyways == DialogResult.Yes) {
                    // If the user clicked "Yes", submit the timesheet
                    selectSaveFileLocation();
                } else {
                    // If the user clicked "No", do nothing
                    return;
                }
            }
        }

        private void richTextBoxVisualiser_TextChanged(object sender, EventArgs e) {

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
    }
}
