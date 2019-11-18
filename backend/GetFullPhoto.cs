using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antroji_praktika.backend
{
    public class GetFullPhoto
    {
        private string Directory = Environment.CurrentDirectory;
        private string Kelias;
        public string GetFullPath(string Nuotrauka)
        {
            Kelias = $"{Directory}\\Pic\\{Nuotrauka}";
            return Kelias;
        }

    }
}
