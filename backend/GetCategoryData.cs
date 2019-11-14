using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace antroji_praktika.backend
{
    public class GetCategoryData
    {
        
        SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=DbAntras.db;");
        public List<Preke> GetPavadinimas()
        {
            m_dbConnection.Open();
            string sql1 = $"SELECT Pavadinimas FROM Prekes";
            string sql2 = $"SELECT Aprasymas FROM Prekes";
            string sql3 = $"SELECT Kaina FROM Prekes";

            SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection);
            SQLiteCommand command2 = new SQLiteCommand(sql2, m_dbConnection);
            SQLiteCommand command3 = new SQLiteCommand(sql3, m_dbConnection);
            SQLiteDataReader reader1 = command1.ExecuteReader();
            SQLiteDataReader reader2 = command2.ExecuteReader();
            SQLiteDataReader reader3 = command3.ExecuteReader();
            string name = "";
            string aprasymas = "";
            string kaina = "";
            int k = 0;
            int m = 0;
            int l = 0;
           
            
            List<Preke> Sarasas = new List<Preke>();
            
            while (reader1.Read())
            {
                Sarasas.Add(new Preke());
                name = reader1.GetString(0);
                Sarasas[k].setTitle(name);

                k++;
            }
            while (reader2.Read())
            {
                aprasymas = reader2.GetString(0);
                Sarasas[m].setAprasymas(aprasymas);

                m++;
            }
            while (reader3.Read())
            {
                kaina = reader3.GetString(0);
                Sarasas[l].setKaina(kaina);
                l++;
            }
            m_dbConnection.Close();
            return Sarasas;
        }
        
    }
}
