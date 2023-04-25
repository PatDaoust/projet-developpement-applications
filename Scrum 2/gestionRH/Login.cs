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
        public static int numUtilisateur;
        bool loginAdminReussi = false;
        bool loginNormalReussi = false;


        public LoginGRH()
        {
            InitializeComponent();
        }


        private void btnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                numUtilisateur = Convert.ToInt32(txbNumUtilisateur.Text);
                if (numUtilisateur > 1000)
                {
                    loginAdminReussi = false;
                    loginNormalReussi= true;
                }
                else
                {
                    loginAdminReussi = true;
                }
            }
            catch
            {
                MessageBox.Show("Ce numéro d'employé n'est pas valide", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (loginAdminReussi==true) {
                FeuilleTempsGRH feuilleTemps = new FeuilleTempsGRH();
                this.Hide();
                feuilleTemps.ShowDialog();
                this.Close();
            } else if (loginNormalReussi==true) {
                EntreeFeuilleDeTemps feuilleTemps = new EntreeFeuilleDeTemps();
                this.Hide();
                feuilleTemps.ShowDialog();
                this.Close();
            }
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txbNumUtilisateur.Clear();
        }
    }
}
