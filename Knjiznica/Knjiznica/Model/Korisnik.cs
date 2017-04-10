using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.Model
{
    public class Korisnik
    {
        public int id { get; set; }
        public string adresa { get; set; }
        public DateTime datumIstekaClanarine { get; set; }
        public DateTime datumRodenja { get; set; }
        public string ime { get; set; }
        public string prebivaliste { get; set; }
        public string prezime { get; set; }
        public char spol { get; set; }

    }
}
