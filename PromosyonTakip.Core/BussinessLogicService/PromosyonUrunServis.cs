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
    public class PromosyonUrunServis : BaseService<PromosyonUrun>
    {
        Database.PromosyonSepeti db;
        public PromosyonUrunServis()
        {
            db = new Database.PromosyonSepeti();
        }
        public List<PromosyonUrun> UrunListeGetir()
        {
            liste = new List<PromosyonUrun>();
            cmd = new SqlCommand("select top 30* from PromosyonUrun where kullanimDurum=1 order by NEWID()");
            reader = db.Liste(cmd);
            while (reader.Read())
            {
                liste.Add(new PromosyonUrun()
                {
                    id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    tanim = reader.IsDBNull(1) ? null : reader.GetString(1),
                    aciklama = reader.IsDBNull(2) ? null : reader.GetString(2),
                    gecerlilikTarih = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                    kullanimDurum = reader.IsDBNull(4) ? false : reader.GetBoolean(4)
                }); ; ;
            }
            reader.Close();
            db.BaglantiDurumuAyarla();
            return liste;
        }

        public PromosyonUrun TekUrunGetir(int id)
        {
            data = new PromosyonUrun();
            cmd = new SqlCommand("select * from PromosyonUrun where id=@id)");
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            reader = db.Liste(cmd);
            while (reader.Read())
            {
                data.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                data.tanim = reader.IsDBNull(1) ? null : reader.GetString(1);
                data.aciklama = reader.IsDBNull(2) ? null : reader.GetString(2);
                data.gecerlilikTarih = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3);
                data.kullanimDurum = reader.IsDBNull(4) ? false : reader.GetBoolean(4);
            }
            reader.Close();
            db.BaglantiDurumuAyarla();
            return data;
        }

        public int urunKullanildiIsaretle(int id)
        {
            cmd = new SqlCommand("update PromosyonUrun set kullanimDurum=@kullanimDurum where id=@id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@kullanimDurum", SqlDbType.Bit).Value = false;
            return db.EkleDuzenleSil(cmd);
        }

    }
}
