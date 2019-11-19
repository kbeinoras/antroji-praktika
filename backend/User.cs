using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace antroji_praktika.backend
{
    public static class User
    {
        static int UserID;

        public static void setUserId(string nick, string pass)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=DbAntras.db;");
            m_dbConnection.Open();
            string query1 = $"SELECT ID FROM Vartotojai WHERE Slapyvardis='{nick}' AND Slaptazodis='{pass}'";
            SQLiteCommand sql2 = new SQLiteCommand(query1, m_dbConnection);
            SQLiteDataReader reader1 = sql2.ExecuteReader();
            while (reader1.Read())
            {
                UserID = reader1.GetInt32(0);
            }
            m_dbConnection.Close();
        }
        public static int GetUserID()
        {
            return UserID;
        }
    }
}
