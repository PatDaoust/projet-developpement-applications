using DBLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionRH
{
    public partial class InterfaceMenu : Form
    {
        public static int numUtilisateur;
        public static List<EmployeModel> employeList = new List<EmployeModel>();
        public static List<FeuilleTempsModel> feuilleList = new List<FeuilleTempsModel>();
        public InterfaceMenu()
        {
            InitializeComponent();
            employeList = SqliteDataAccess.LoadEmploye();
        }

        private void btnMenuAdmin_Click(object sender, EventArgs e)
        {
            FeuilleTemps feuilleTemps = new FeuilleTemps();
            Employe empLogin;
            try
            {
                numUtilisateur = Convert.ToInt32(txbLoginUtilisateur.Text);
                empLogin = new Employe(numUtilisateur, feuilleTemps);

                if (EntrerEmploye(empLogin))
                {
                    if (numUtilisateur < 1000)
                    {
                        this.Hide();
                        empLogin.numEmploye = numUtilisateur;
                        LoginGRH loginGRH = new LoginGRH(empLogin);
                        loginGRH.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Seul les administrateurs peuvent accèder à ce menu", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Cet employé n'existe pas." + '\n' +
                    "Voulez-vous ajouter un nouvel employé?", "Employé Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void btnMenuEmploye_Click(object sender, EventArgs e)
        {
            FeuilleTemps feuilleTemps = new FeuilleTemps();
            Employe empLogin;
            try
            {
                numUtilisateur = Convert.ToInt32(txbLoginUtilisateur.Text);
                empLogin = new Employe(numUtilisateur, feuilleTemps);

                if (EntrerEmploye(empLogin))
                {
                    if (numUtilisateur >= 1000 && numUtilisateur < 2000)
                    {
                        this.Hide();
                        empLogin.numEmploye = numUtilisateur;
                        EntreeFeuilleDeTemps entreeFeuilleDeTemps = new EntreeFeuilleDeTemps(empLogin);
                        MessageBox.Show("Vous êtes connecté en tant qu'employé de production", "Connexion Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        entreeFeuilleDeTemps.ShowDialog();
                        this.Show();
                    }
                    else if (numUtilisateur >= 2000)
                    {
                        this.Hide();
                        empLogin.numEmploye = numUtilisateur;
                        EntreeFeuilleDeTemps entreeFeuilleDeTemps = new EntreeFeuilleDeTemps(empLogin);
                        MessageBox.Show("Vous êtes connecté en tant qu'employé d'exploitation", "Connexion Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        entreeFeuilleDeTemps.ShowDialog();
                        this.Show();
                    }
                    else if (numUtilisateur > 0 && numUtilisateur < 1000)
                    {
                        this.Hide();
                        empLogin.numEmploye = numUtilisateur;
                        EntreeFeuilleDeTemps entreeFeuilleDeTemps = new EntreeFeuilleDeTemps(empLogin);
                        MessageBox.Show("Vous êtes connecté en tant qu'administrateur", "Connexion Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        entreeFeuilleDeTemps.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Cet employé n'existe pas." +'\n'+
                    "Voulez-vous ajouter un nouvel employé?", "Employé Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            creationCompte unCreationCompte = new creationCompte();
            unCreationCompte.ShowDialog();
            this.Show();
        }

        private bool EntrerEmploye(Employe testEmpLogin){
            int numEmploye = testEmpLogin.numEmploye;
            bool trouve = false;
            foreach (EmployeModel user in employeList)
            {
                if (numEmploye == user.employeID)
                {
                    feuilleList = SqliteDataAccess.LoadFeuille(user);
                    testEmpLogin.hashMotDePasse = user.motDePasse;
                    testEmpLogin.nomEmploye = user.nomEmploye;
                    testEmpLogin.prenomEmploye = user.prenomEmploye;
                    trouve = true;
                }
            }
            if (!trouve)
            {
                return false;
            }
            return true;
        }
    }
}