using Microsoft.Data.SqlClient;
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
    public partial class FrmOtelDüzenleme : Form
    {
        public FrmOtelDüzenleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UKTEL72;Initial Catalog=otelloutoVT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");


        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string lblTcNo;
        public string otelKodu;
        string otelTipi = "1";
        void otelKaydıSorgulama()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Oteller WHERE otelSahip LIKE '%" + lblTcNo + "%'", baglanti);

            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                txtOtelName.Text = oku["otelAdi"].ToString();
                txtOtelExp.Text = oku["otelAciklama"].ToString();
                if (oku["otelTipi"].ToString() == "True")
                {
                    rbBireysel.Checked = true;
                    rbOrtak.Checked = false;

                }
                else
                {
                    rbOrtak.Checked = true;
                    rbBireysel.Checked = false;

                }
            }
            baglanti.Close();

        }

        private void FrmOtelDüzenleme_Load(object sender, EventArgs e)
        {
            otelKaydıSorgulama();
            if (rbBireysel.Checked == true)
            {
                otelTipi = "1";
            }
            else
            {
                otelTipi = "0";
            }
            label2.Text = $"Karakter Sayısı:{txtOtelExp.Text.Length}";
        }

        private void groupOtelType_Enter(object sender, EventArgs e)
        {

        }
        void güncelleme()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE tbl_Oteller SET otelAdi=@otelAdi, otelTipi=@otelTipi, otelAciklama=@otelAciklama WHERE otelKodu=@otelKodu", baglanti);
            komut.Parameters.AddWithValue("@otelAdi", txtOtelName.Text.ToUpper());
            komut.Parameters.AddWithValue("@otelTipi", otelTipi.ToString());
            komut.Parameters.AddWithValue("@otelAciklama", txtOtelExp.Text.ToString());
            komut.Parameters.AddWithValue("@otelKodu",otelKodu.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void rbBireysel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBireysel.Checked == true)
            {
                otelTipi = "1";
            }
            else
            {
                otelTipi = "0";
            }
        }

        private void rbOrtak_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrtak.Checked == true)
            {
                otelTipi = "0";
            }
            else
            {
                otelTipi = "1";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            güncelleme();
        }

    }
}
