using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace antroji_praktika.backend
{
    public static class GetRegistration
    {

        public static void Registracija(string nick, string pass)
        {
            {
                int id = GetID();
                id++;
                SQLiteConnection conn = new SQLiteConnection(@"Data Source=DbAntras.db;");
                conn.Open();
                string sql1 = $"INSERT INTO Vartotojai values(@ID,@Slapyvardis,@Slaptazodis)";
                SQLiteCommand cmd1 = new SQLiteCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@ID", id);
                cmd1.Parameters.AddWithValue("@Slapyvardis", nick);
                cmd1.Parameters.AddWithValue("@Slaptazodis", pass);
                cmd1.ExecuteNonQuery();
                conn.Close();
            }


        }
        private static int GetID()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=DbAntras.db;");
            conn.Open();
            string sql1 = $"SELECT ID FROM Vartotojai ";
            SQLiteCommand cmd1 = new SQLiteCommand(sql1, conn);
            SQLiteDataReader reader = cmd1.ExecuteReader();
            int id = 0;
            while(reader.Read())
            {
                id = reader.GetInt32(0);
            }
            return id;
        }
        
    }
}
//$"{imageSource}"