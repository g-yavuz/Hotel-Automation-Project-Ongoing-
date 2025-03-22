using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace otelloutoV1
{
    public partial class FrmOrtakGirisi : Form
    {
        public FrmOrtakGirisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UKTEL72;Initial Catalog=otelloutoVT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void FrmOrtakGirisi_Load(object sender, EventArgs e)
        {
            txtOtelAdi.ReadOnly = true;
            txtOnayKodu.ReadOnly = true;
            txtOnayKodu.BackColor = Color.White;
            txtOtelAdi.BackColor = Color.White;
            btnNext.Enabled = false;

        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.icons8_plus_48__1_;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.icons8_plus_48;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Oteller WHERE otelKodu=@p1 and otelTipi='False'",baglanti);
            komut.Parameters.AddWithValue("@p1", txtOtelKodu.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblOtelVarYok.Text = "Otel Bulundu";
                txtOtelAdi.Text = oku["otelAdi"].ToString();
                txtOnayKodu.ReadOnly = false;
                txtOnayKodu.Enabled = true;
                btnNext.Enabled = true;

            }
            else
            {
                lblOtelVarYok.Text = "Otel Bulunamadı";
                txtOtelAdi.ReadOnly = true;
                txtOnayKodu.ReadOnly = true;
                txtOnayKodu.BackColor = Color.White;
                txtOtelAdi.BackColor = Color.White;
                btnNext.Enabled = false;
                txtOnayKodu.Text = "";
                txtOtelAdi.Text = "";

            }
            baglanti.Close();

        }
    }
}
