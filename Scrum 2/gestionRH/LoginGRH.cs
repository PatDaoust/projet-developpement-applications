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
    public partial class LoginGRH : Form
    {
        public int numUtilisateur;
        public String motPasse = "";
        public Employe employeLogin;

        public LoginGRH(Employe empLogin)
        {
            InitializeComponent();
            employeLogin = empLogin;
            numUtilisateur = employeLogin.numEmploye;
            txbNumUtilisateur.Text = numUtilisateur.ToString();            
        }


        private void btnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                motPasse = txbMotPasse.Text;
                if (motPasse.Equals("admin"))
                {
                    FeuilleTempsGRH feuilleTempsGRH = new FeuilleTempsGRH(employeLogin);
                    this.Hide();
                    feuilleTempsGRH.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception();
                }

            }
            catch
            {
                MessageBox.Show("Ce mot de passe n'est pas valide", "Accès Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txbMotPasse.Clear();
        }
    }
}
