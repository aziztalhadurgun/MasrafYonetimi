using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PersonelIslemleri
    {
        private SqlDataProvider provider = new SqlDataProvider(Constants.ConnectionString);

        public Personel PersonelLogin(string kullaniciAdi, string sifre)
        {
            //provider oluştugunda connection ve command ı hazır olacak sekilde kodladık

            string sorgu = "SELECT Id, Adi, Soyadi, EPosta, KullaniciAdi, SorumlusuId, PersonelTurId FROM Personel AS p WHERE p.KullaniciAdi = @kullaniciAdi AND p.Sifre = @sifre AND p.AktifMi = 1";

            provider.Command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
            provider.Command.Parameters.AddWithValue("@Sifre", sifre);
            DataTable sonuc = provider.GetDataTable(sorgu);

            Personel personel = null;

            if (sonuc.Rows.Count > 0)
            {
                DataRow dr = sonuc.Rows[0];

                personel = new Personel();
                personel.Id = (int)dr["Id"];
                personel.Adi = dr["Adi"].ToString();
                personel.Soyadi = dr["Soyadi"].ToString();
                personel.EPosta = dr["EPosta"].ToString();
                personel.KullaniciAdi = dr["KullaniciAdi"].ToString();
                personel.SorumlusuId =
                    (dr.IsNull("SorumlusuId") == true ? null : (int?)dr["SorumlusuId"]);
                personel.PersonelTurId = (byte)dr["PersonelTurId"];
            }

            return personel;
        }

        public List<Personel> GetirPersonelBySorumluId(int sorumluId)
        {
            string sorgu = "SELECT Id, Adi, Soyadi, EPosta, KullaniciAdi, SorumlusuId, PersonelTurId FROM Personel WHERE SorumlusuId=@SorumlusuId AND AktifMi = 1";

            provider.Command.Parameters.Clear();
            provider.Command.Parameters.AddWithValue("@SorumlusuId", sorumluId);

            DataTable sonuc = provider.GetDataTable(sorgu);
            List<Personel> personeller = new List<Personel>();

            if (sonuc.Rows.Count > 0)
            {
                foreach (DataRow dr in sonuc.Rows)
                {
                    Personel personel = new Personel();
                    personel.Id = (int)dr["Id"];
                    personel.Adi = dr["Adi"].ToString();
                    personel.Soyadi = dr["Soyadi"].ToString();
                    personel.EPosta = dr["EPosta"].ToString();
                    personel.KullaniciAdi = dr["KullaniciAdi"].ToString();
                    personel.SorumlusuId =
                        (dr.IsNull("SorumlusuId") == true ? null : (int?)dr["SorumlusuId"]);
                    personel.PersonelTurId = (byte)dr["PersonelTurId"];

                    personeller.Add(personel);
                }
            }
            return personeller;
        }

        //muhasebe işlemleri için
        public List<Personel> GetirTumPersonel()
        {
            string sorgu = "SELECT Id, Adi, Soyadi, EPosta, KullaniciAdi, SorumlusuId, PersonelTurId FROM Personel WHERE AktifMi = 1";

            provider.Command.Parameters.Clear();;

            DataTable sonuc = provider.GetDataTable(sorgu);
            List<Personel> personeller = new List<Personel>();

            if (sonuc.Rows.Count > 0)
            {
                foreach (DataRow dr in sonuc.Rows)
                {
                    Personel personel = new Personel();
                    personel.Id = (int)dr["Id"];
                    personel.Adi = dr["Adi"].ToString();
                    personel.Soyadi = dr["Soyadi"].ToString();
                    personel.EPosta = dr["EPosta"].ToString();
                    personel.KullaniciAdi = dr["KullaniciAdi"].ToString();
                    personel.SorumlusuId =
                        (dr.IsNull("SorumlusuId") == true ? null : (int?)dr["SorumlusuId"]);
                    personel.PersonelTurId = (byte)dr["PersonelTurId"];

                    personeller.Add(personel);
                }
            }
            return personeller;
        }
    }
}
