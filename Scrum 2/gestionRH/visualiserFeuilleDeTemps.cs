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

namespace gestionRH {
    public partial class visualiserFeuilleDeTemps : Form {

        public int numUtilisateur = LoginGRH.numUtilisateur;
        public ArrayList feuilleJour1 = EntreeFeuilleDeTemps.jour1;
        public String feuilleDeTempsComplet = EntreeFeuilleDeTemps.feuilleDeTempsComplet;

        public visualiserFeuilleDeTemps() {
            InitializeComponent();
            richTextBoxVisualiser.Text = feuilleDeTempsComplet;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void buttonModifier_Click(object sender, EventArgs e) {
            EntreeFeuilleDeTemps.feuilleDeTempsComplet = "";
            this.Close();
        }

        private void buttonSoumetre_Click(object sender, EventArgs e) {
            MessageBox.Show("not yet imlemented");
            //if not validated, popup to warn
            //if validated with errors, popup to warn
            //allow user to select folder where to submit
        }

        private void richTextBoxVisualiser_TextChanged(object sender, EventArgs e) {

        }

        private void buttonValider_Click(object sender, EventArgs e) {
            MessageBox.Show("not yet imlemented");
            //call validate function on new feuille de temps
            //display results
        }
    }
}
