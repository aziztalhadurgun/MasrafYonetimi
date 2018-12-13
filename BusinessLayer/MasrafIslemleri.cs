using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;

namespace BusinessLayer
{
    public class MasrafIslemleri
    {
        SqlDataProvider provider = new SqlDataProvider(Constants.ConnectionString);
        public int MasrafEkle(Masraf masraf)
        {
            provider.Command.Parameters.Clear();

            provider.Command.CommandText = "Execute masrafEkle @Id,@Baslik,@Tarih,@Tutar,@Aciklama,@PersonelId,@DurumId";
            provider.Command.Parameters.Add("@Id", SqlDbType.Int).Value = masraf.Id;
            provider.Command.Parameters.Add("@Baslik", SqlDbType.NVarChar,50).Value = masraf.Baslik;
            provider.Command.Parameters.Add("@Tarih", SqlDbType.Date).Value = masraf.Tarih;
            provider.Command.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = masraf.Tutar;
            provider.Command.Parameters.Add("@Aciklama", SqlDbType.NVarChar,150).Value = masraf.Aciklama;
            provider.Command.Parameters.Add("@PersonelId", SqlDbType.Int).Value = masraf.PersonelId;
            provider.Command.Parameters.Add("@DurumId", SqlDbType.TinyInt).Value = masraf.DurumId  ;

            return provider.spFunk();
        }
        public List<Masraf> GetirMasraf(int personelId)
        {
            List<Masraf> masraflar = new List<Masraf>();

            string sorgu = "Select Id, Baslik, Tarih, Tutar, Aciklama, PersonelId, DurumId From Masraf Where PersonelId = @PersonelId";

            provider.Command.Parameters.Clear();
            provider.Command.Parameters.AddWithValue("@PersonelId", personelId);

            DataTable dt = provider.GetDataTable(sorgu);

            if (dt.Rows.Count>0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Masraf masraf = new Masraf()
                    {
                        Id = (int)dr["Id"],
                        Baslik = dr["Baslik"].ToString(),
                        Aciklama = dr["Aciklama"].ToString(),
                        Tarih = (DateTime)dr["Tarih"],
                        Tutar = (decimal)dr["Tutar"],
                        PersonelId = (int)dr["PersonelId"],
                        DurumId = (byte)dr["DurumId"]
                    };
                    masraflar.Add(masraf);
                }
            }
            return masraflar;
        }
        public int MasrafGuncelle(Masraf masraf)
        {
            string sorgu = "Update Masraf Set Baslik=@Baslik, Tarih=@Tarih, Tutar=@Tutar, Aciklama=@Aciklama, DurumId=@DurumId Where Id=@Id";

            provider.Command.Parameters.Clear();
            //provider.Command.Parameters.AddWithValue("@Id", Guid.NewGuid());
            provider.Command.Parameters.AddWithValue("@Id", masraf.Id);
            provider.Command.Parameters.AddWithValue("@Baslik", masraf.Baslik);
            provider.Command.Parameters.AddWithValue("@Tarih", masraf.Tarih.Date);
            provider.Command.Parameters.AddWithValue("@Tutar", masraf.Tutar);
            provider.Command.Parameters.AddWithValue("@Aciklama", masraf.Aciklama);
            provider.Command.Parameters.AddWithValue("@DurumId", masraf.DurumId);

            return provider.RunQuery(sorgu);
        }
        public int MasrafSil(Masraf masraf)
        {
            string sorgu = "Delete From Masraf Where Id=@Id";

            provider.Command.Parameters.Clear();
            //provider.Command.Parameters.AddWithValue("@Id", Guid.NewGuid());
            provider.Command.Parameters.AddWithValue("@Id", masraf.Id);
            provider.Command.Parameters.AddWithValue("@Baslik", masraf.Baslik);
            provider.Command.Parameters.AddWithValue("@Tarih", masraf.Tarih.Date);
            provider.Command.Parameters.AddWithValue("@Tutar", masraf.Tutar);
            provider.Command.Parameters.AddWithValue("@Aciklama", masraf.Aciklama);
            provider.Command.Parameters.AddWithValue("@PersonelId", masraf.PersonelId);
            provider.Command.Parameters.AddWithValue("@DurumId", masraf.DurumId);

            return provider.RunQuery(sorgu);
        }
    }
}
