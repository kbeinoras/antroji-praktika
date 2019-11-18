using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace antroji_praktika.backend
{
    public class GetKrepselis
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=DbAntras.db;");
        public List<KrepselioItem> GetCart()
        {
            m_dbConnection.Open();
            string sql1 = $"SELECT Pavadinimas FROM Krepselis";
            string sql3 = $"SELECT Kaina FROM Krepselis";

            SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection);
            SQLiteCommand command3 = new SQLiteCommand(sql3, m_dbConnection);
            SQLiteDataReader reader1 = command1.ExecuteReader();
            SQLiteDataReader reader3 = command3.ExecuteReader();
            string name = "";
            string kaina = "";
            int k = 0;
            int l = 0;
            List<KrepselioItem> Sarasas = new List<KrepselioItem>();
            
            while (reader1.Read())
            {
                Sarasas.Add(new KrepselioItem());
                name = reader1.GetString(0);
                Sarasas[k].setTitle(name);

                k++;
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
