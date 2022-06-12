using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Entities
{
    public class PotansiyelMusteri
    {
        public int id { get; set; }
        public string tcKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarih { get; set; }
        public int cinsiyet { get; set; }
        public string meslek { get; set; }
        public string emailAdres { get; set; }
        public bool emailBildirimiOnay { get; set; }
        public string telefon { get; set; }
        public bool telefonBildirimiOnay { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public int olusturanMagaza { get; set; }

    }
}
