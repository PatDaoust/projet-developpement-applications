using DBLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static gestionRH.SecurePasswordHasher;

namespace gestionRH {
    public partial class creationCompte : Form {
        public creationCompte() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void buttonCreeCompte_Click(object sender, EventArgs e) {
            //capture info from text boxes
            int numEmploye;
            try {
                numEmploye = Convert.ToInt32(textBoxNumeroEmployee.Text);
            } catch {
                MessageBox.Show("Ce numéro d'employé n'est pas valide", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string prenomEmploye = textBoxPrenom.Text;
            string nomEmploye = textBoxNom.Text;
            //get MDP1 and MDP2, validate same
            string mdp1 = textBoxMDP1.Text;
            string mdp2 = textBoxMDP2.Text;
            if (!mdp1.Equals(mdp2)) {
                MessageBox.Show("votre mot de passe ne correspond pas à lui-même", "Mot de passe Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string hashedmdp = Hash(mdp1);
            //create employeeModel object
            Employe employe = new Employe(numEmploye, hashedmdp, nomEmploye, prenomEmploye);
            EmployeModel employeModel = new EmployeModel();
            employeModel.employeID = employe.numEmploye;
            employeModel.categorie = employe.categorie;
            employeModel.prenomEmploye = employe.prenomEmploye;
            employeModel.nomEmploye = employe.nomEmploye;
            employeModel.motDePasse = employe.hashMotDePasse;
            //cree compte dans base de donnees
            SqliteDataAccess.SaveEmploye(employeModel);
            InterfaceMenu.employeList = SqliteDataAccess.LoadEmploye();
            this.Close();
        }

        private void textBoxNumeroEmployee_Leave(object sender, EventArgs e) {
            //if not number, error
            int numUtilisateur;
            try {
                numUtilisateur = Convert.ToInt32(textBoxNumeroEmployee.Text);
            } catch {
                MessageBox.Show("Ce numéro d'employé n'est pas valide", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}