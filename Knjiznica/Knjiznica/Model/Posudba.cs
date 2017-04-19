using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.Model
{
    public class Posudba
    {
        public Posudba(Korisnik kor, List<Knjiga> lista, DateTime datPos)
        {
            this.korisnik = kor;
            this.listaKnjiga = lista;
            this.datumPosudbe = datPos;
            this.datumIstekaPosudbe = datPos.AddDays(14);
        }
        public int IDposudba { get; set; } //ID bi bio userid + broj posudjenih knjiga jer moramo imat nacin pracenja 1 posudbe za vise knjiga
        public Korisnik korisnik { get; set; }
        public List<Knjiga> listaKnjiga { get; set; }
        public DateTime datumPosudbe { get; set; }
        public DateTime datumIstekaPosudbe { get; set; }
    }
}
