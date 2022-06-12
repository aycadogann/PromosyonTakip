using PromosyonTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Helper
{
    public static class StaticFieldList
    {
        public static int magazaID { get; set; }
        public static List<Cinsiyet> cinsiyetYukle()
        {
            List<Cinsiyet> CinsiyetListe = new List<Cinsiyet>();
            CinsiyetListe.Add(new Cinsiyet() { id = 1, tanim = "Bay" });
            CinsiyetListe.Add(new Cinsiyet() { id = 2, tanim = "Bayan" });
            return CinsiyetListe;
        }
    }
}
