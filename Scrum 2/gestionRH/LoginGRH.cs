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
        public int numUtilisateur = InterfaceAdmin.numUtilisateur;
        public String motPasse = "";


        public LoginGRH()
        {
            InitializeComponent();
            txbNumUtilisateur.Text = numUtilisateur.ToString();            
        }


        private void btnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                motPasse = txbMotPasse.Text;
                if (motPasse.Equals("admin"))
                {
                    FeuilleTempsGRH feuilleTempsGRH = new FeuilleTempsGRH();
                    this.Hide();
                    feuilleTempsGRH.Show();
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
