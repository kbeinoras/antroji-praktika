using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace antroji_praktika.backend
{
    public class GetRegistration
    {
       
        public void Registracija(string nick, string pass)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(@"Data Source=DbAntras.db;");
                conn.Open();
                string sql1 = $"INSERT INTO Slapyvardis FROM Vartotojai" 
                SQLiteCommand cmd = new SQLiteCommand("insert into Vartotojai values($"{nick}","pass");", conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Inserting Data Successfully");
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occre while creating table:" + e.Message + "\t" + e.GetType());
            }
            Console.ReadKey();

        }
    }
}
//$"{imageSource}"