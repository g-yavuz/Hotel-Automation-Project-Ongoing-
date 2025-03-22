using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace otelloutoV1
{
    public partial class frmOtelKayitEkrani : Form
    {
        public frmOtelKayitEkrani()
        {
            InitializeComponent();
            label2.Text = "Karakter Sayısı:";

        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=otelloutoVT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            temizle();
            txtOtelName.Focus();

        }
        void temizle()
        {
            txtOtelName.Text = "";
            txtOtelExp.Text = "";
            rbOrtak.Checked = false;
            rbBireysel.Checked = true;
            createOtelCode();
            otelTipi = "0";
            txtOtelName.Focus();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOtelExp_TextChanged(object sender, EventArgs e)
        {
            int currentLength = txtOtelExp.Text.Length;
            label2.Text = $"Karakter Sayısı: {currentLength}";

        }
        void createOtelCode()
        {
            Random rastgele = new Random();

            string semboller = "ABCDEFGHIJKLMNPQRSTUVWXYZ123456789ABCDEFGHIJKLMNPQRSTUVWXYZ123456789ABCDEFGHIJKLMNPQRSTUVWXYZ123456789ABCDEFGHIJKLMNPQRSTUVWXYZ123456789";
            string olusanKod = "";
            for (int i = 1; i < 11; i++)
            {
                olusanKod += semboller[rastgele.Next(semboller.Length)];
            }
            lblOtelKodu.Text = olusanKod;
        }
        bool otelKodKontrolü = true;
        string otelTipi;
        private void frmOtelKayitEkrani_Load(object sender, EventArgs e)
        {
            createOtelCode();
            if (rbBireysel.Checked)
            {
                otelTipi = "1";
            }
            else
            {
                otelTipi = "0";
            }
        }

        void otelCodeControlMethod()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_Oteller WHERE otelKodu = @otelKodu", baglanti);
            komut.Parameters.AddWithValue("@otelKodu", lblOtelKodu.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                otelKodKontrolü = true;


            }
            else
            {
                otelKodKontrolü = false;

            }
            baglanti.Close();


        }
        void kayıtEtme()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO tbl_Oteller (otelKodu, otelAdi, otelTipi, otelSahip, otelAciklama) VALUES (@otelKodu, @otelAdi, @otelTipi, @otelSahip, @otelAciklama)", baglanti);
            komut.Parameters.AddWithValue("@otelKodu", lblOtelKodu.Text.ToString());
            komut.Parameters.AddWithValue("@otelAdi", txtOtelName.Text.ToUpper());
            komut.Parameters.AddWithValue("@otelTipi", otelTipi.ToString());
            komut.Parameters.AddWithValue("@otelSahip", lblKisiTc.Text.ToString());
            komut.Parameters.AddWithValue("@otelAciklama", txtOtelExp.Text.ToString());
            komut.ExecuteNonQuery();
            temizle();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtOtelName.Text != "" && txtOtelExp.Text != "" && lblKisiTc.Text != "" && lblOtelKodu.Text != "")
            {
                otelCodeControlMethod();

                if (otelKodKontrolü is true)
                {
                    frmPopUpMenu frm = new frmPopUpMenu();
                    frm.label2.Text = "SİZE VERİLEN OTEL KODU KULLANILMIŞTIR YENİSİ OLUŞTURULUP KAYDINIZ YAPILIYOR";
                    frm.Show();
                    createOtelCode();
                    kayıtEtme();
                    this.Close();

                }
                else
                {
                    kayıtEtme();
                    this.Close();

                }
            }
            else
            {
                frmPopUpMenu frm = new frmPopUpMenu();
                frm.label2.Text = "LÜTFEN TÜM ALANLARI DOLDURUNUZ!!";
                frm.Show();

            }
        }

        private void rbOrtak_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBireysel.Checked)
            {
                otelTipi = "1";
            }
            else
            {
                otelTipi = "0";
            }
        }
    }
}
