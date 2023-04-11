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
        public static int numEmploye;
        public LoginGRH()
        {
            InitializeComponent();
        }


        private void btnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                numEmploye = Convert.ToInt32(txbNumEmploye.Text);
            }
            catch
            {
                MessageBox.Show("Ce numéro d'employé n'est pas valide", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            FeuilleTempsGRH feuilleTemps = new FeuilleTempsGRH();
            this.Hide();
            feuilleTemps.ShowDialog();
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txbNumEmploye.Clear();
        }
    }
}
