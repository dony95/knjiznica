using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.Model
{
    public class Posudba
    {
        public int ID { get; set; } //ID bi bio userid + broj posudjenih knjiga jer moramo imat nacin pracenja 1 posudbe za vise knjiga
        public Korisnik korisnik { get; set; }
        public List<Knjiga> listaKnjiga { get; set; }
        public DateTime datumPosudbe { get; set; }
        public DateTime datumIstekaPosudbe { get; set; }
    }
}
