using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLibrary
{
    public class SqliteDataAccess
    {
        public static List<EmployeModel> LoadEmploye()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var output = con.Query<EmployeModel>("select * from Employe", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<FeuilleTempsModel> LoadFeuille(EmployeModel employe)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var output = con.Query<FeuilleTempsModel>("select * from FeuilleTemps where EmployeID="+employe.employeID, new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveFeuille(FeuilleTempsModel feuille)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    con.Execute("insert into FeuilleTemps (FeuilleID, EmployeID, ProjetID, Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche) values (@feuilleID, @employeID, @projetID, @lundi, @mardi, @mercredi, @jeudi, @vendredi, @samedi, @dimanche)", feuille);
                }
                catch (Exception ex)
                {
                    try
                    {
                        con.Execute("update FeuilleTemps set " +
                            "Lundi = @lundi, " +
                            "Mardi = @mardi, " +
                            "Mercredi = @mercredi, " +
                            "Jeudi = @jeudi, " +
                            "Vendredi = @vendredi, " +
                            "Samedi = @samedi, " +
                            "Dimanche = @dimanche " +
                            "where (FeuilleID = @feuilleID AND " +
                            "ProjetID = @projetID)", feuille);
                    }
                    catch
                    {
                        MessageBox.Show("Feuille existante. Réessayer", "Feuille Existante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        public static void deleteProjet(FeuilleTempsModel feuille)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    con.Execute("delete from FeuilleTemps " +
                        "where (FeuilleID = @feuilleID AND " +
                        "ProjetID = @projetID)", feuille);
                }
                catch
                {
                    MessageBox.Show("Feuille existante. Réessayer", "Feuille Existante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

public static void SaveEmploye(EmployeModel employe)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    con.Execute("insert into Employe (EmployeID, categorie, prenomEmploye, nomEmploye, motDePasse) values (@employeID, @categorie, @prenomEmploye, @nomEmploye, @motDePasse)", employe);

                    MessageBox.Show("Votre compte a été créé avec succès:"+"\n"+
                        "Nouvel EmployeID = " + employe.employeID, "Compte Créé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Usager existant. Réessayer", "Usager Existant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
