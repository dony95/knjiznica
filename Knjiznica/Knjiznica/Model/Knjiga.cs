using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.Model
{
    public class Knjiga
    {
        public int id { get; set; }
        public string autor { get; set; }
        public string naziv { get; set; }
        public string kategorija { get; set; }
        public string izdavac { get; set; }
        public int godina { get; set; }
        public string isbn { get; set; }
        public int brojStranica { get; set; }
        public double cijena { get; set; }
        public int brojKopija { get; set; }
    }
}
