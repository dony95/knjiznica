using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.Model
{
    public class Posudba
    {
        public Korisnik korisnik { get; set; }
        public List<Knjiga> knjige { get; set; }
        public DateTime datumPosudbe { get; set; }
        public DateTime datumIstekaPosudbe { get; set; }
    }
}
