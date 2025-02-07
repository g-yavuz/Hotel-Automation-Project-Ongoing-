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
                Properties.Resources.eye_slash_visible_hide_hidden_show_icon_145987, // Resource içindeki resim
                Properties.Resources.eye_visible_hide_hidden_show_icon_145988,
            };
            currentImageIndex = 0; // İlk resimle başla
            pictureboxSifre.Image = images[currentImageIndex]; // pictureBox3'e ilk resmi yükle
            pictureboxSifreTekrar.Image = images[currentImageIndex]; // pictureBox4'e ilk resmi yükle
            txtSifre.PasswordChar = '*';
            txtSifreTekrar.PasswordChar = '*';
        }
        //Veritabanına ait baplantı cümlesi
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UKTEL72;Initial Catalog=otelloutoVT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

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
        private void btnNext_Click(object sender, EventArgs e)
        {
            //Text'leri boş olup olmadığının kontrolü sağlanacaktır
            if (txtSifre.Text != "" && txtKullanıcıAdı.Text != "" && txtCevap.Text != "" && txtKullanıcıAdı.Text != "" && txtGüvenlik.Text != "" && txtSifreTekrar.Text != "")
            {
                if(txtSifre.Text == txtSifreTekrar.Text)
                {
                    kulAdi = txtKullanıcıAdı.Text;
                    sifre = txtSifre.Text;
                    soru = txtGüvenlik.Text;
                    cevap = txtCevap.Text;

                    MessageBox.Show("Şifreler Aynı");
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
                frm.Show();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Text'leri temizleme işlemi yapılacaktır
            txtSifre.Text = "";
            txtKullanıcıAdı.Text = "";
            txtCevap.Text = "";
            txtKullanıcıAdı.Text = "";
            txtGüvenlik.Text = "";
            txtSifreTekrar.Text = "";
            txtGüvenlik.SelectedIndex = -1;
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
