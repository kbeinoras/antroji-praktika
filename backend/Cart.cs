using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace antroji_praktika.backend
{
    public static class Cart
    {
        static int VisaKaina =0;
        static string VisaKainaNotConverted;
        static int VisaKainaConverted;
        static List<Item> Prekes = new List<Item>();

        static SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=DbAntras.db;");
        
        public static void InsertToCart(int ID, string name, string price)
        {
            Prekes.Add(new Item(ID, price, name));
            VisaKainaNotConverted = price;
            VisaKainaConverted =Convert.ToInt32(VisaKainaNotConverted);
            VisaKaina = VisaKaina + VisaKainaConverted;
            
        }
        public static int GetCount()
        {
            return Prekes.Count;
        }
        
        public static List<Item> GetItems()
        {
            return Prekes;
        }
        public static void DeleteItem(int ID, string name, string price)
        {
            
            Item Itemas = new Item(ID, price, name);
            int id;
            for (int x = 0; x < Prekes.Count; x++)
            {
                id = Prekes[x].GetID();
                if (ID == id)
                {
                    Prekes.RemoveAt(x);
                    VisaKainaNotConverted = price;
                    VisaKainaConverted = Convert.ToInt32(VisaKainaNotConverted);
                    VisaKaina = VisaKaina - VisaKainaConverted;
                    break;
                }
            }
            
        }
        public static int GetSuma()
        {
            return VisaKaina;
        }
        private static int GetUnikaluID()
        {


            string SQL = $"SELECT ID FROM KrepselioPasirinkimai";
            SQLiteCommand command1 = new SQLiteCommand(SQL, m_dbConnection);
            SQLiteDataReader reader = command1.ExecuteReader();
            int PasirinkimoID = 0;
            while (reader.Read())
            {
                PasirinkimoID = reader.GetInt32(0);
            }

            return PasirinkimoID;
        }
        public static void FormCheck()
        {

            m_dbConnection.Open();
            int ID=GetUnikaluID();
            ID++;
            int User = backend.User.GetUserID();
            string sql1 = $"insert into KrepselioPasirinkimai values(@ID, @PrekesID, @Kaina)";
            SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection);
            for (int j = 0; j < Prekes.Count; j++)
            {
                command1.Parameters.AddWithValue("@ID", ID);
                command1.Parameters.AddWithValue("@PrekesID", Prekes[j].GetID());
                command1.Parameters.AddWithValue("@Kaina", Prekes[j].GetKaina());
                command1.ExecuteNonQuery();
            }
            var time = DateTime.Now;
            sql1 = $"insert into Uzsakymas values(@ID,@VartotojoID,@Data,@ImonesPavadinimas)";
            SQLiteCommand command = new SQLiteCommand(sql1, m_dbConnection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@VartotojoID", User);
            command.Parameters.AddWithValue("@Data", Convert.ToString(time));
            command.Parameters.AddWithValue("@ImonesPavadinimas", "Elektronikos parduotuvė: Gisul");
            command.ExecuteNonQuery();
            m_dbConnection.Close();

        }
        public static void ClearItems()
        {
            Prekes.Clear();
            VisaKaina = 0;
        }
    }
}
