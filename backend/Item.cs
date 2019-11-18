using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antroji_praktika.backend
{
    public class Item
    {
        private int ID;
        private string Kaina;
        private string Pavadinimas;

        public Item(int Id, string price, string name)
        {
            ID = Id;
            Kaina = price;
            Pavadinimas = name;
        }
        public void SetID(int id)
        {
            ID = id;
        }
        public int GetID()
        {
            return ID;
        }

        public void SetKaina(string price)
        {
            Kaina = price;
        }
        public string GetKaina()
        {
            return Kaina;
        }

        public void SetPavadinimas(string pav)
        {
            Pavadinimas = pav;
        }
        public string GetPavadinimas()
        {
            return Pavadinimas;
        }

    }
}
