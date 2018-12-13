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

namespace MasrafOtomasyonu
{
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisYapanFonk();
        }
        private void GirisYapanFonk()
        {
            if (GirisHataKontrol() == true) return;

            PersonelIslemleri pi = new PersonelIslemleri();
            Personel personel = pi.PersonelLogin(txtKulAdi.Text, txtPassword.Text);

            if (personel != null)
            {
                //Giriş başarılı ise
                this.Hide();
                frmAnaForm frm = new frmAnaForm();
                frm.GirisYapanPersonel = personel;
                frm.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool GirisHataKontrol()
        {
            bool result = false;

            errorProvider1.Clear();

            string kullaniciAdi = txtKulAdi.Text.Trim(); //sağ ve soldaki boş karakteri siler
            string sifre = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi))
            {
                errorProvider1.SetError(txtKulAdi, "Kullanıcı Adı Boş Geçilemez");
                result = true;
            }
            if (string.IsNullOrEmpty(sifre))
            {
                errorProvider1.SetError(txtPassword, "Şifre Boş Geçilemez");
                result = true;
            }

            return result;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                GirisYapanFonk();
            }
        }

    }
}
