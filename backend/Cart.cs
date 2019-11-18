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
        static List<Item> Prekes = new List<Item>();

        static SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=DbAntras.db;");
        
        public static void InsertToCart(int ID, string name, string price)
        {
            Prekes.Add(new Item(ID, price, name));

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
                    break;
                }
            }
        }
    }
}
