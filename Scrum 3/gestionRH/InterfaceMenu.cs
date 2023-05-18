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
using static gestionRH.SecurePasswordHasher;

namespace gestionRH
{
    public partial class InterfaceMenu : Form
    {
        public static int numUtilisateur;
        public static List<EmployeModel> employeList = new List<EmployeModel>();
        public static List<FeuilleTempsModel> feuilleList = new List<FeuilleTempsModel>();
        public String motPasse = "";
        public Employe employeLogin;
        public InterfaceMenu()
        {
            InitializeComponent();
            employeList = SqliteDataAccess.LoadEmploye();
            //txbLoginUtilisateur is user entered number
            //numUtilisateur = employeLogin.numEmploye;
            //txbNumUtilisateur.Text = numUtilisateur.ToString();
        }

        private void btnMenuAdmin_Click(object sender, EventArgs e)
        {
            try {
                motPasse = txbMotPasse.Text;
                numUtilisateur = Int32.Parse(txbLoginUtilisateur.Text);
                FeuilleTemps feuilleTemps = new FeuilleTemps();
                employeLogin = new Employe(numUtilisateur, feuilleTemps);
                employeLogin.numEmploye = numUtilisateur;
                

                if (EntrerEmploye(employeLogin)){
                    string verifierPasse = employeLogin.hashMotDePasse;
                    if (Verify(motPasse, verifierPasse)) {
                        FeuilleTempsGRH feuilleTempsGRH = new FeuilleTempsGRH(employeLogin);
                        this.Hide();
                        feuilleTempsGRH.ShowDialog();
                        this.Close();
                    } else {
                        throw new Exception();
                    }
            }

            } catch {
                MessageBox.Show("Ce mot de passe n'est pas valide", "Accès Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           
        }

        public void btnMenuEmploye_Click(object sender, EventArgs e)
        {
            try {
                motPasse = txbMotPasse.Text;
                numUtilisateur = Int32.Parse(txbLoginUtilisateur.Text);
                FeuilleTemps feuilleTemps = new FeuilleTemps();
                employeLogin = new Employe(numUtilisateur, feuilleTemps);
                employeLogin.numEmploye = numUtilisateur;

                if (EntrerEmploye(employeLogin)) {
                    string verifierPasse = employeLogin.hashMotDePasse;
                    if (Verify(motPasse, verifierPasse)) {
                        this.Hide();
                        employeLogin.numEmploye = numUtilisateur;
                        EntreeFeuilleDeTemps entreeFeuilleDeTemps = new EntreeFeuilleDeTemps(employeLogin);
                        entreeFeuilleDeTemps.ShowDialog();
                        this.Show();
                    } else {
                        throw new Exception();
                    }
                }

            } catch {
                MessageBox.Show("Ce mot de passe n'est pas valide", "Accès Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            /*
            FeuilleTemps feuilleTemps = new FeuilleTemps();
            Employe empLogin;
            try
            {
                numUtilisateur = Convert.ToInt32(txbLoginUtilisateur.Text);
                empLogin = new Employe(numUtilisateur, feuilleTemps);

                if (EntrerEmploye(empLogin))
                {
                        this.Hide();
                        empLogin.numEmploye = numUtilisateur;
                        EntreeFeuilleDeTemps entreeFeuilleDeTemps = new EntreeFeuilleDeTemps(empLogin);
                        entreeFeuilleDeTemps.ShowDialog();
                        this.Show();
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
            */
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