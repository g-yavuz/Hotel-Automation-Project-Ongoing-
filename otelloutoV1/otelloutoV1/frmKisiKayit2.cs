using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace otelloutoV1
{
    public partial class frmKisiKayit2 : Form
    {
        private int currentImageIndex;
        private List<Image> images;
        public frmKisiKayit2()
        {
            InitializeComponent();
            // Resimleri listeye ekle
            images = new List<Image>
            {
                Properties.Resources.eye_slash_visible_hide_hidden_show_icon_145988, // Resource içindeki resim
                Properties.Resources.eye_visible_hide_hidden_show_icon_1459881,
            };
            currentImageIndex = 0; // İlk resimle başla
            pictureboxSifre.Image = images[currentImageIndex]; // pictureBox3'e ilk resmi yükle
            pictureboxSifreTekrar.Image = images[currentImageIndex]; // pictureBox4'e ilk resmi yükle
            txtSifre.PasswordChar = '*';
            txtSifreTekrar.PasswordChar = '*';
        }
        //Veritabanına ait baglantı cümlesi
        // veritabanını bağlarken DESKTOP-UKTEL72 yerine "." kullanımı tüm bilgisayarlarda kullanım olanağına götürecek bir durmdur.
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=otelloutoVT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureUndo_Click(object sender, EventArgs e)
        {
            //Önceki sayfaya geri dönme komutları yazılacaktır
            frmKisiKayıt frm = new frmKisiKayıt();
            frm.Show();
            this.Close();
        }

        private void Btn_Cikis_MouseEnter(object sender, EventArgs e)
        {
            Btn_Cikis.BackColor = Color.Red;

        }

        private void Btn_Cikis_MouseLeave(object sender, EventArgs e)
        {
            Btn_Cikis.BackColor = Color.FromArgb(17, 55, 64);

        }

        private void pictureUndo_MouseEnter(object sender, EventArgs e)
        {
            pictureUndo.BackColor = Color.Teal;
        }

        private void pictureUndo_MouseLeave(object sender, EventArgs e)
        {
            pictureUndo.BackColor = Color.CadetBlue;
        }
        public string tc, ad, soyad, dogumt, tel, mail, aciklam, cinsiyet;
        string kulAdi, sifre, soru, cevap;

        bool kulAdiKontrol;

        void kuladiKontrolMetodu()
        {
            if (string.IsNullOrEmpty(kulAdi))
            {
                kulAdiKontrol = false;
                return;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kisiler WHERE kisiKul = @kisiKul", baglanti);
            komut.Parameters.AddWithValue("@kisiKul", kulAdi);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                kulAdiKontrol = true;
            }
            else
            {
                kulAdiKontrol = false;
            }

            baglanti.Close();
        }

        bool tcKontrol;

        void tcKontrolMetodu()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kisiler WHERE kisiTc = @kisiTc", baglanti);
            komut.Parameters.AddWithValue("@kisiTc", tc);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                tcKontrol = true; // kayıt varsa
            }
            else
            {
                tcKontrol = false; // kayıt yoksa
            }

            baglanti.Close();
        }
        bool kullanıcıGirisDegeri = false;
        private void btnNext_Click(object sender, EventArgs e)
        {
            //Text'leri boş olup olmadığının kontrolü sağlanacaktır
            if (txtSifre.Text != "" && txtKullanıcıAdı.Text != "" && txtCevap.Text != "" && txtKullanıcıAdı.Text != "" && txtGüvenlik.Text != "" && txtSifreTekrar.Text != "")
            {
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    kulAdi = txtKullanıcıAdı.Text.ToString();
                    sifre = txtSifre.Text.ToString();
                    soru = txtGüvenlik.Text.ToString();
                    cevap = txtCevap.Text.ToString();
                    kuladiKontrolMetodu();
                    tcKontrolMetodu();
                    if (kulAdiKontrol == false && tcKontrol == false)
                    {

                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kisiler (kisiTc,kisiAd,kisiSoyad,kisiCinsiyet,kisiDogumT,kisiTel,kisiMail,kisiAciklama,kisiKul,kisiSifre,kisiCevap,kisiYetki) VALUES (@kisiTc,@kisiAd,@kisiSoyad,@kisiCinsiyet,@kisiDogumT,@kisiTel,@kisiMail,@kisiAciklama,@kisiKul,@kisiSifre,@kisiCevap,@kisiYetki)", baglanti);
                        komut.Parameters.AddWithValue("@kisiTc", tc);
                        komut.Parameters.AddWithValue("@kisiAd", ad);
                        komut.Parameters.AddWithValue("@kisiSoyad", soyad);
                        komut.Parameters.AddWithValue("@kisiCinsiyet", cinsiyet);
                        komut.Parameters.AddWithValue("@kisiDogumT", dogumt);
                        komut.Parameters.AddWithValue("@kisiTel", tel);
                        komut.Parameters.AddWithValue("@kisiMail", mail);
                        komut.Parameters.AddWithValue("@kisiAciklama", aciklam);
                        komut.Parameters.AddWithValue("@kisiKul", kulAdi);
                        komut.Parameters.AddWithValue("@kisiSifre", sifre);
                        komut.Parameters.AddWithValue("@kisiCevap", cevap);
                        komut.Parameters.AddWithValue("@kisiYetki", "1");
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        Temizle();
                        kullanıcıGirisDegeri = true;
                        frmPopUpMenu frm = new frmPopUpMenu();
                        frm.kullanıcıGirisDegeri = kullanıcıGirisDegeri;
                        frm.label2.Text = "KAYIT İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLMİŞTİR!" +
                            "LÜTFEN BEKLEYİNİZ!!!";
                        frm.ShowDialog();
                        this.Close();

                    }
                    else if (tcKontrol == true)
                    {
                        frmPopUpMenu frm = new frmPopUpMenu();
                        frm.label2.Text = "TC KİMLİK NUMARANIZ İLE KAYDINIZ BULUNMAKTADIR!";
                        frm.Show();
                    }
                    else if (kulAdiKontrol == true)
                    {
                        frmPopUpMenu frm = new frmPopUpMenu();
                        frm.label2.Text = "KULLANICI İSMİ DAHA ÖNCE KULLANILMIŞTIR!";
                        frm.Show();
                    }
                }
                else 
                {
                    frmPopUpMenu frm = new frmPopUpMenu();
                    frm.label2.Text = "ŞİFRELER UYUŞMUYOR!";
                    frm.Show();
                }
                //MessageBox.Show(tc+" "+ ad+ " " + soyad + " " + dogumt + " " + tel + " " + mail + " " + aciklam + " " + cinsiyet);
            }
            // Boş olan varsa uyarı formu açılacaktır
            else
            {
                frmPopUpMenu frm = new frmPopUpMenu();
                frm.label2.Text = "TÜM ALANLARI DOLDURUNUZ!";
                frm.Show();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            //Text'leri temizleme işlemi yapılacaktır
            Temizle();

        }

        void Temizle()
        {
            txtSifre.Text = "";
            txtKullanıcıAdı.Text = "";
            txtCevap.Text = "";
            txtGüvenlik.Text = "";
            txtSifreTekrar.Text = "";
            txtGüvenlik.SelectedIndex = -1;
            txtKullanıcıAdı.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Şifre kısmına sayı girilmesi kontrolü yapılacaktır
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Şifre tekrar kısmına sayı girilmesi kontrolü yapılacaktır
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private bool visibelty1 = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % images.Count;
            pictureboxSifre.Image = images[currentImageIndex];
            if (visibelty1)
            {
                // Şifreyi gizle
                txtSifre.PasswordChar = '*';
                visibelty1 = false;
            }
            else
            {
                // Şifreyi göster
                txtSifre.PasswordChar = '\0'; // Şifreyi göster
                visibelty1 = true;
            }
        }
        private bool visibelty2 = false;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % images.Count;
            pictureboxSifreTekrar.Image = images[currentImageIndex];
            if (visibelty2)
            {
                // Şifreyi gizle
                txtSifreTekrar.PasswordChar = '*';
                visibelty2 = false;
            }
            else
            {
                // Şifreyi göster
                txtSifreTekrar.PasswordChar = '\0'; // Şifreyi göster
                visibelty2 = true;
            }
        }


    }
}
