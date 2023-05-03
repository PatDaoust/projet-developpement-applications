using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static void SaveEmploye(EmployeModel employe)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into Employe (EmployeID, categorie, prenomEmploye, nomEmploye, motDePasse) values (@EmployeID, @categorie, @prenomEmploye, @nomEmploye, @motDePasse)", employe);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
