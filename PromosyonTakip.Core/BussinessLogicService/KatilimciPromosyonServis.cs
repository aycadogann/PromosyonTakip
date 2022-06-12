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
    public class KatilimciPromosyonServis:BaseService<PromosyonUrun>
    {
        Database.PromosyonSepeti db;
        public KatilimciPromosyonServis()
        {
            db = new Database.PromosyonSepeti();
        }

        public int KayitYeni(KatilimciPromosyon data)
        {
            cmd = new SqlCommand("insert into KatilimciPromosyon values (@potansiyelMusteriId,@promosyonUrunId,@olusturmaTarih,@magazaId)");
            cmd.Parameters.Add("@potansiyelMusteriId", SqlDbType.Int).Value = data.potansiyelMusteriId;
            cmd.Parameters.Add("@promosyonUrunId", SqlDbType.Int).Value = data.promosyonUrunId;
            cmd.Parameters.Add("@olusturmaTarih", SqlDbType.DateTime).Value = data.olusturmaTarih;
            cmd.Parameters.Add("@magazaId", SqlDbType.Int).Value = data.magazaId;
            return db.EkleDuzenleSil(cmd);

        }

    }
}
