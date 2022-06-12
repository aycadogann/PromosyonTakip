using PromosyonTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.BussinessLogicService
{
    public class SistemMagazaServis:BaseService<SistemMagaza>
    {
       
        Database.PromosyonSepeti db;
        public SistemMagazaServis()
        {
            db = new Database.PromosyonSepeti(); 
        }

        public int MagazaKullaniciKontrol(string kullaniciAdi, string sifre)
        {
            cmd = new SqlCommand("select id from SistemMagaza where kullaniciAdi=@kullaniciAdi and sifre=@sifre");
            cmd.Parameters.Add("@kullaniciAdi", SqlDbType.NVarChar).Value = kullaniciAdi;
            cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = sifre;
            obj = db.KolonGetir(cmd);
            return obj == null ? 0 : (int)obj;
        }

    }
}
