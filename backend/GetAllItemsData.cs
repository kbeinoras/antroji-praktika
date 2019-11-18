using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace antroji_praktika.backend
{
    public class GetAllItemsData
    {
        private string Directory = Environment.CurrentDirectory;
        private string Kelias;
        SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=DbAntras.db;");
        public List<Preke> GetPavadinimas(string kategorija)
        {
            m_dbConnection.Open();
            string sql1 = $"SELECT Pavadinimas FROM Prekes WHERE Kategorija='{kategorija}'";
            string sql2 = $"SELECT Aprasymas FROM Prekes WHERE Kategorija='{kategorija}'";
            string sql3 = $"SELECT Kaina FROM Prekes WHERE Kategorija='{kategorija}'";
            string sql4 = $"SELECT Paveikslelis FROM Prekes WHERE Kategorija='{kategorija}'";
            SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection);
            SQLiteCommand command2 = new SQLiteCommand(sql2, m_dbConnection);
            SQLiteCommand command3 = new SQLiteCommand(sql3, m_dbConnection);
            SQLiteCommand command4 = new SQLiteCommand(sql4, m_dbConnection);
            SQLiteDataReader reader1 = command1.ExecuteReader();
            SQLiteDataReader reader2 = command2.ExecuteReader();
            SQLiteDataReader reader3 = command3.ExecuteReader();
            SQLiteDataReader reader4 = command4.ExecuteReader();
            string name = "";
            string aprasymas = "";
            string kaina = "";
            string paveikslelis = "";
            int k = 0;
            int m = 0;
            int l = 0;
            int n = 0;
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
            while (reader4.Read())
            {
                paveikslelis = reader4.GetString(0);
                Kelias = $"{Directory}\\Pic\\{paveikslelis}";
                Sarasas[n].SetNuotraukosDirekcija(Kelias);
                n++;
            }
            m_dbConnection.Close();
            return Sarasas;
        }
    }
}
