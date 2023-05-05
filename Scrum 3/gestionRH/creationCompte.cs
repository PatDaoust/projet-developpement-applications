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

namespace gestionRH {
    public partial class creationCompte : Form {
        public creationCompte() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private string hashPassword(string password) {
            //from https://stackoverflow.com/questions/4181198/how-to-hash-a-password
            //Create the salt value
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            //get the hash value
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            //Combine the salt and password bytes
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            // combine salt+hash into a string
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;

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
            string hashedmdp = hashPassword(mdp1);
            //create employeeModel object
            EmployeModel employe = new EmployeModel(numEmploye, hashedmdp, nomEmploye, prenomEmploye);
            //cree compte dans base de donnees
            SqliteDataAccess.SaveEmploye(employe);
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
