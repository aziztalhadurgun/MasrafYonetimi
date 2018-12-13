using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Entities;
using Entities.Enums;

namespace MasrafOtomasyonu
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }
        private MasrafIslemleri mi = new MasrafIslemleri();
        private PersonelIslemleri pi = new PersonelIslemleri();

        public Personel GirisYapanPersonel { get; set; }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            lblPersonelAdSoyad.Text = string.Format("{0} {1} ({2})",
                GirisYapanPersonel.Adi, GirisYapanPersonel.Soyadi, PersonelTuruEnumHelper.GetText(GirisYapanPersonel.PersonelTurId));

            MasraflariYenile();
            GetirPersonelSorumluListe();
        }

        private void GetirPersonelSorumluListe()
        {
            List<Personel> masrafSahipleri = new List<Personel>();

            if (GirisYapanPersonel.PersonelTurId != (byte)PersonelTuruEnum.Muhasebe)
            {
                masrafSahipleri.Add(GirisYapanPersonel);
                masrafSahipleri.AddRange(pi.GetirPersonelBySorumluId(GirisYapanPersonel.Id));
            }
            else
            {
                masrafSahipleri.AddRange(pi.GetirTumPersonel());
            }
            
            cmbMasrafSahibi.DataSource = masrafSahipleri;
        }
        private void MasraflariYenile()
        {
            if (cmbMasrafSahibi.SelectedIndex > -1)
            {
                Personel personel = cmbMasrafSahibi.SelectedItem as Personel;
                List<Masraf> masraflar = mi.GetirMasraf(personel.Id);
                lstMasraflar.DataSource = masraflar;
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Masrafları ekleme
            Masraf masraf = new Masraf()
            {
                Baslik = txtBaslik.Text,
                Tarih = dtpTarih.Value,
                Tutar = nudTutar.Value,
                Aciklama = txtAciklama.Text,
                PersonelId = GirisYapanPersonel.Id,
                DurumId = (byte)DurumEnum.OnayBekliyor
            };
            if (GirisYapanPersonel.PersonelTurId == (byte)PersonelTuruEnum.Yonetici)
            {
                masraf.DurumId = (byte)DurumEnum.Onaylandı;
            }
            //mi.MasrafEkle(masraf)
            int sonuc = mi.MasrafEkle(masraf);

            if (sonuc > 0)
            {
                //masraf eklendi, masrafları listele(yenile)
                MasraflariYenile();
            }
            else
            {
                MessageBox.Show("Masraf Eklenemedi");
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir masraf seçiniz!!!");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;

            masraf.Baslik = txtBaslik.Text;
            masraf.Aciklama = txtAciklama.Text;
            masraf.Tarih = dtpTarih.Value;
            masraf.Tutar = nudTutar.Value;
            masraf.DurumId = (byte)DurumEnum.OnayBekliyor;

            if (GirisYapanPersonel.PersonelTurId == (byte)PersonelTuruEnum.Yonetici)
            {
                masraf.DurumId = (byte)DurumEnum.Onaylandı;
            }

            if (mi.MasrafGuncelle(masraf) > 0)
            {
                MasraflariYenile();
            }
            else
            {
                MessageBox.Show("Masraf Güncellenemedi");
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir masraf seçiniz!!!");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;
            if (MessageBox.Show(masraf.Baslik + " adlı masrafı silmek üzeresiniz", "Masraf Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (mi.MasrafSil(masraf) > 0)
                {
                    MasraflariYenile();
                }
                else
                {
                    MessageBox.Show("Masraf Silinemedi");
                }
            }
        }

        private void lstMasraflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hiç tıklanmadıysa bisey yapma
            //if (lstMasraflar.SelectedIndex == -1)
            //    return;

            Masraf masraf = lstMasraflar.SelectedItem as Masraf;

            if (lstMasraflar.SelectedIndex != -1 && masraf != null)
            {
                txtBaslik.Text = masraf.Baslik;
                txtAciklama.Text = masraf.Aciklama;
                dtpTarih.Value = masraf.Tarih;
                nudTutar.Value = masraf.Tutar;
            }
            //odenen ve reddedilen durumların kaydet butonunu pasif yapma
            if (masraf.DurumId == (byte)DurumEnum.Reddedildi || masraf.DurumId == (byte)DurumEnum.Odendi)
            {
                btnKaydet.Enabled = false;
            }
            else
            {
                btnKaydet.Enabled = true;
            }
            //odenenleri silmek için buton pasif yapma
            if (masraf.DurumId == (byte)DurumEnum.Odendi)
            {
                btnSil.Enabled = false;
            }
            else
            {
                btnSil.Enabled = true;
            }

            if (masraf.DurumId == (byte)DurumEnum.Onaylandı)
            {
                cmenuOdendi.Enabled = true;
            }
            else
            {
                cmenuOdendi.Enabled = false;
            }
        }
        private void lstMasraflar_Format(object sender, ListControlConvertEventArgs e)
        {
            Masraf masraf = e.ListItem as Masraf;
            e.Value = string.Format("{0} ({1})", masraf.Baslik, DurumEnumHelper.GetText(masraf.DurumId));
        }

        private void cmbMasrafSahibi_Format(object sender, ListControlConvertEventArgs e)
        {
            Personel personel = e.ListItem as Personel;
            e.Value = string.Format("{0} {1}", personel.Adi, personel.Soyadi);
        }
        private void cmbMasrafSahibi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMasrafSahibi.SelectedIndex > -1)
            {
                Personel personel = cmbMasrafSahibi.SelectedItem as Personel;

                if (personel.Id == GirisYapanPersonel.Id)
                {
                    flpButonlar.Enabled = true;
                    lstMasraflar.ContextMenuStrip = null;
                }
                else
                {
                    flpButonlar.Enabled = false;
                    lstMasraflar.ContextMenuStrip = cmenuMasrafYonet;
                }

                if (GirisYapanPersonel.PersonelTurId == (byte)PersonelTuruEnum.Muhasebe)
                {
                    lstMasraflar.ContextMenuStrip = cmenuMuhasebe;
                }

                List<Masraf> masraflar = mi.GetirMasraf(personel.Id);

                lstMasraflar.DataSource = masraflar;

            }

        }

        private void cmenuOnayla_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir masraf seçiniz!!!");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;

            masraf.DurumId = (byte)DurumEnum.Onaylandı;

            if (mi.MasrafGuncelle(masraf) > 0)
            {
                MasraflariYenile();
            }
            else
            {
                MessageBox.Show("Masraf Onaylanamadı");
            }
        }
        private void cmenuGuncelle_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir masraf seçiniz!!!");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;

            masraf.DurumId = (byte)DurumEnum.Duzeltilecek;

            if (mi.MasrafGuncelle(masraf) > 0)
            {
                MasraflariYenile();
            }
            else
            {
                MessageBox.Show("Masraf Değiştirilemedi");
            }
        }
        private void cmenuReddet_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir masraf seçiniz!!!");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;

            masraf.DurumId = (byte)DurumEnum.Reddedildi;

            if (mi.MasrafGuncelle(masraf) > 0)
            {
                MasraflariYenile();
            }
            else
            {
                MessageBox.Show("Masraf Reddedilemedi!!!!");
            }
        }

        private void cmenuOdendi_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir masraf seçiniz!!!");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;

            masraf.DurumId = (byte)DurumEnum.Odendi;

            if (mi.MasrafGuncelle(masraf) > 0)
            {
                MasraflariYenile();
            }
            else
            {
                MessageBox.Show("Masraf Değiştirilemedi");
            }
        }

        private void lblPersonelAdSoyad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Oturum Kapatma", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                frmAnaForm frmAna = new frmAnaForm();
                frmAna.Close();
                frm_giris frmGiris = new frm_giris();
                frmGiris.Show();
            }
        }
    }
}
