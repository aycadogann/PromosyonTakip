using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Entities
{
    public class KatilimciPromosyon
    {
        public int id { get; set; }
        public int potansiyelMusteriId { get; set; }
        public int promosyonUrunId { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public int magazaId { get; set; }

    }
}
