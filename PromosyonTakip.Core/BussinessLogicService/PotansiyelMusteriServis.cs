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
    public class PotansiyelMusteriServis : BaseService<PotansiyelMusteri>
    {
        Database.PromosyonSepeti db;
        public PotansiyelMusteriServis()
        {
            db = new Database.PromosyonSepeti();
        }

        public int KayitYeni(PotansiyelMusteri data)
        {
            cmd = new SqlCommand("insert into PotansiyelMusteri values (@tcKimlikNo, @isim, @soyisim, @dogumTarih, @cinsiyet, @meslek, @emailAdres, @emailBildirimOnay, @telefon, @telefonBildirimOnay," +
                " @olusturmaTarihi, @olusturanMagaza)");
            cmd.Parameters.Add("@tcKimlikNo",SqlDbType.NVarChar).Value=data.tcKimlikNo;
            cmd.Parameters.Add("@isim",SqlDbType.NVarChar).Value=data.isim;
            cmd.Parameters.Add("@soyisim",SqlDbType.NVarChar).Value=data.soyisim;
            cmd.Parameters.Add("@dogumTarih", SqlDbType.DateTime).Value=data.dogumTarih;
            cmd.Parameters.Add("@cinsiyet", SqlDbType.Int).Value=data.cinsiyet;
            cmd.Parameters.Add("@meslek", SqlDbType.NVarChar).Value=data.meslek;
            cmd.Parameters.Add("@emailAdres", SqlDbType.NVarChar).Value=data.emailAdres;
            cmd.Parameters.Add("@emailBildirimOnay", SqlDbType.Bit).Value=data.emailBildirimiOnay;
            cmd.Parameters.Add("@telefon", SqlDbType.NVarChar).Value=data.telefon;
            cmd.Parameters.Add("@telefonBildirimOnay", SqlDbType.Bit).Value=data.telefonBildirimiOnay;
            cmd.Parameters.Add("@olusturmaTarihi", SqlDbType.DateTime).Value=data.olusturmaTarih;
            cmd.Parameters.Add("@olusturanMagaza", SqlDbType.Int).Value=data.olusturanMagaza;
            sonuc=db.EkleDuzenleSil(cmd);
            return sonuc;
        }
        public int TCSorgula(string tcKimlikNo)
        {
            cmd = new SqlCommand("select id from PotansiyelMusteri where tcKimlikNo=@tcKimlikNo");
            cmd.Parameters.Add("@tcKimlikNo", SqlDbType.NVarChar).Value = tcKimlikNo;
            obj = db.KolonGetir(cmd);
            return obj == null ? 0 : (int)obj;
        }

    }
}