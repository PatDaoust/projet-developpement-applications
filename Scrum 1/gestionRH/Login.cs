﻿using System;
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
        bool loginReussi = false;
        
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
                    MessageBox.Show("Seul les administrateurs sont autorisés à se connecter", "Privilèges insuffisants", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    loginReussi = false;
                }
                else
                {
                    loginReussi = true;
                }
            }
            catch
            {
                MessageBox.Show("Ce numéro d'employé n'est pas valide", "Numéro Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (loginReussi==true)
            {
                FeuilleTempsGRH feuilleTemps = new FeuilleTempsGRH();
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
