using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Xml.Serialization;
namespace otelloutoV1
{
    public partial class FrmKullanıcıGiris : Form
    {
        bool yetkiVarYok = false;
        public FrmKullanıcıGiris()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UKTEL72;Initial Catalog=otelloutoVT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        int randomInt1, randomInt2;
        private void FrmKullanıcıGiris_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            randomInt1 = rnd.Next(1, 50); // 1 ile 49 arasında rastgele bir sayı
            randomInt2 = rnd.Next(1, 50);
            lbl_Güvenlik.Text = $"{randomInt1} + {randomInt2} =";

        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdı.Text != "" && txtSifre.Text != "")
            {
                if ((randomInt1 + randomInt2) == Convert.ToInt16(textBox1.Text))
                {
                    //Başarılı
                    if (rbYetkili.Checked is true)
                    {
                        yetkiVarYok = true;
                    }
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT * from Tbl_Kisiler WHERE kisiKul=@p1 AND kisiSifre=@p2 AND kisiYetki=@p3", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtKullanıcıAdı.Text);
                    komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                    komut.Parameters.AddWithValue("@p3", yetkiVarYok);
                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        FrmAnaEkran frm = new FrmAnaEkran();
                        frm.lblKullanıcıAdıBilgisi.Text = txtKullanıcıAdı.Text;
                        frm.lblGirisYetkisiBilgisi.Text = yetkiVarYok.ToString();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmPopUpMenu frm = new frmPopUpMenu();
                        frm.label2.Text = "KULLANICI KAYIDI BULUNAMADI!";
                        frm.Show();
                    }
                    baglanti.Close();

                    alanTemizleme();
                }
                else
                {
                    Random rnd = new Random();
                    randomInt1 = rnd.Next(1, 50); // 1 ile 49 arasında rastgele bir sayı
                    randomInt2 = rnd.Next(1, 50);
                    lbl_Güvenlik.Text = $"{randomInt1} + {randomInt2} =";
                    textBox1.Text = "";
                    textBox1.Focus();
                    frmPopUpMenu frm = new frmPopUpMenu();
                    frm.label2.Text = "GÜVENLİK KISMINI GEÇEMEDİNİZ";
                    frm.Show();
                }

            }
            else
            {
                frmPopUpMenu frm = new frmPopUpMenu();
                frm.label2.Text = "LÜTFEN TÜM BOŞLUKLARI DOLDURUNUZ";
                frm.Show();
            }
        }
        void alanTemizleme()
        {
            txtKullanıcıAdı.Text = "";
            txtSifre.Text = "";
            rbYetkili.Checked = true;
            rbPersonel.Checked = false;
            textBox1.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            alanTemizleme();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmYetkiYönlendirme frm = new FrmYetkiYönlendirme();
            frm.Show();
            this.Hide();
        }

        private void Btn_Cikis_MouseEnter(object sender, EventArgs e)
        {
            Btn_Cikis.BackColor = Color.Red;


        }

        private void Btn_Cikis_MouseLeave(object sender, EventArgs e)
        {
            Btn_Cikis.BackColor = Color.FromArgb(17, 55, 64);

        }
    }
}
