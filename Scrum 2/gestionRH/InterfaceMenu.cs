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

        public InterfaceMenu()
        {
            InitializeComponent();
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
                    LoginGRH loginGRH = new LoginGRH(empLogin);
                    this.Hide();
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
                if (numUtilisateur >= 1000)
                {
                    EntreeFeuilleDeTemps entreeFeuilleDeTemps = new EntreeFeuilleDeTemps(empLogin);
                    this.Hide();
                    entreeFeuilleDeTemps.ShowDialog();
                    this.Show();
                }
                else if (numUtilisateur > 0 && numUtilisateur < 1000)
                {
                    EntreeFeuilleDeTemps entreeFeuilleDeTemps = new EntreeFeuilleDeTemps(empLogin);
                    this.Hide();
                    entreeFeuilleDeTemps.ShowDialog();
                    this.Show();
                }
            }
            catch
            {
                MessageBox.Show("Ce numéro d'employé n'est pas valide", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
