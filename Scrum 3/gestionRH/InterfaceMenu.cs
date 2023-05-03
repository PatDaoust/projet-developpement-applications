using DBLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionRH
{
    public partial class InterfaceMenu : Form
    {
        public static int numUtilisateur;
        List<EmployeModel> employeList = new List<EmployeModel>();

        public InterfaceMenu()
        {
            InitializeComponent();
            employeList = SqliteDataAccess.LoadEmploye();
        }

        private void btnMenuAdmin_Click(object sender, EventArgs e)
        {
            FeuilleTemps feuilleTemps = new FeuilleTemps();
            Employe empLogin = new Employe(numUtilisateur, feuilleTemps);
            try
            {
                numUtilisateur = Convert.ToInt32(txbLoginUtilisateur.Text);
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
            catch
            {
                MessageBox.Show("Ce numéro d'employé n'est pas valide", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void btnMenuEmploye_Click(object sender, EventArgs e)
        {
            FeuilleTemps feuilleTemps = new FeuilleTemps();
            Employe empLogin = new Employe(numUtilisateur, feuilleTemps);
            try
            {
                numUtilisateur = Convert.ToInt32(txbLoginUtilisateur.Text);
                if (numUtilisateur >= 1000 && numUtilisateur < 2000)
                {                    
                    this.Hide();
                    empLogin.numEmploye = numUtilisateur;
                    EntreeFeuilleDeTemps entreeFeuilleDeTemps = new EntreeFeuilleDeTemps(empLogin);
                    MessageBox.Show("Vous êtes connecté en tant qu'employé de production", "Connexion Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    entreeFeuilleDeTemps.ShowDialog();
                    this.Show();
                }else if (numUtilisateur >= 2000)
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
            catch
            {
                MessageBox.Show("Ce numéro d'employé n'est pas valide", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(employeList[0].FullName.ToString());
        }
    }
}
