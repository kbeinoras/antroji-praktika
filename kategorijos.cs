﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace antroji_praktika
{
    public class kategorijos
    {
        public void ShowData()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=DbAntras.db;");

            m_dbConnection.Open();
            string sql1 = $"SELECT Kategorija FROM Prekes";
            SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection);
            SQLiteDataReader reader1 = command1.ExecuteReader();
            string name = "";
            int k = 0;
            List<Items> Sarasas = new List<Items>();
            while (reader1.Read())
            {
                name = reader1.GetString(0);
                Sarasas.Add(new Items());
                Sarasas[k].setTitle(name);
                StackPanel1.Children.Add(Sarasas[k]);
                k++;

            }
            m_dbConnection.Close();
        }
    }
}