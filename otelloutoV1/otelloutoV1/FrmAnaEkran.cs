using otelloutoV1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace otelloutoV1
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
            otelKaydıSorgulama();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UKTEL72;Initial Catalog=otelloutoVT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Cikis_MouseEnter(object sender, EventArgs e)
        {
            Btn_Cikis.BackColor = Color.Red;
        }

        private void Btn_Cikis_MouseLeave(object sender, EventArgs e)
        {
            Color panelRengi = panelTopMenu.BackColor;
            if (panelRengi == Color.CadetBlue)
            {
                Btn_Cikis.BackColor = Color.FromArgb(17, 55, 64);
            }
            else
            {
                Btn_Cikis.BackColor = Color.CadetBlue;
            }
        }

        private void pbPanelAcKapa_Click(object sender, EventArgs e)
        {
            if (panelYanMenu.Width == 0)
            {
                panelTopMenu.BackColor = Color.FromArgb(17, 55, 64);
                Btn_Cikis.BackColor = Color.CadetBlue;
                pbPanelAcKapa.Image = Properties.Resources._1486395885_plus_80605;
                menuKapa.Stop();
                menuAc.Start();
            }
            else
            {
                panelTopMenu.BackColor = Color.CadetBlue;
                Btn_Cikis.BackColor = Color.FromArgb(17, 55, 64);
                pbPanelAcKapa.Image = Properties.Resources.plus_icon_icons_com_69476;
                menuAc.Stop();
                menuKapa.Start();
            }
        }

        private void menuAc_Tick(object sender, EventArgs e)
        {
            panelYanMenu.Width += 10;
            if (panelYanMenu.Width == 200)
            {
                menuAc.Stop();
            }
        }

        private void menuKapa_Tick(object sender, EventArgs e)
        {
            panelYanMenu.Width -= 10;
            if (panelYanMenu.Width == 0)
            {
                menuKapa.Stop();
            }
        }


        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
            tcNoGetır();
            tcNoVeOtelKoduGetır();
            otelKaydıSorgulama();
            
            int x = this.Width - 50;
            int y = this.Height - 70;
            pbOlustur.Location = new Point(x, y);
            pnlSecenekler.Location = new Point(x - 220, y - 130);

            if (pbOlustur.Visible == true)
            {
                pbPanelAcKapa.Enabled = false;
                panelYanMenu.Visible = false;
            }
            else
            {
                pbPanelAcKapa.Enabled = true;
                panelYanMenu.Visible = true;
                
            }
        }
        int a = 0;
        private void pbOlustur_Click(object sender, EventArgs e)
        {
            //panelYanMenu.Width = 0;
            //pbPanelAcKapa.Enabled = true;
            //pbOlustur.Visible = false;
            if (a == 0)
            {
                pnlSecenekler.Visible = true;
                pbOlustur.Image = Properties.Resources.check_one_icon_155665;
                a += 1;
            }
            else
            {
                pnlSecenekler.Visible = false;
                pbOlustur.Enabled = true;
                pbOlustur.Image = Properties.Resources.add_one_button_insert_plus_icon_155856;
                a -= 1;
            }

        }
        void tcNoVeOtelKoduGetır()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select k.*, o.otelKodu from Tbl_Kisiler k, Tbl_Oteller o  WHERE k.kisiKul=@p1 AND k.kisiYetki=@p2 AND k.kisiTc = o.otelSahip", baglanti);
            komut.Parameters.AddWithValue("@p1", lblKullanıcıAdıBilgisi.Text);
            komut.Parameters.AddWithValue("@p2", lblGirisYetkisiBilgisi.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblOtelKodu.Text = oku["otelKodu"].ToString();
            }

            baglanti.Close();   

        }
        void otelKaydıSorgulama()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Oteller WHERE otelSahip LIKE '%" + lblTcNo.Text + "%'", baglanti);

            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                pbOlustur.Visible = false;
                pnlSecenekler.Visible = false;
                lblOtelKodu.Visible = true;
                label5.Visible = true;
            }
            else
            {
                pbOlustur.Visible = true;

            }
            baglanti.Close();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(165, 165, 165);
            FrmOrtakGirisi frm = new FrmOrtakGirisi();
            frm.ShowDialog();
        }

        private void FrmAnaEkran_MouseClick(object sender, MouseEventArgs e)
        {
            if (pnlSecenekler.Visible == true)
            {
                pnlSecenekler.Visible = false;
                pbOlustur.Enabled = true;
                pbOlustur.Image = Properties.Resources.add_one_button_insert_plus_icon_155856;
                a -= 1;
            }
            FrmOrtakGirisi frm = new FrmOrtakGirisi();
            frm.Show();


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(165, 165, 165);
            frmOtelKayitEkrani otelkayit = new frmOtelKayitEkrani();
            otelkayit.lblKisiTc.Text = lblTcNo.Text;
            otelkayit.ShowDialog();

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(17, 55, 64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlSecenekler.Visible = false;
            pbOlustur.Enabled = true;
            pbOlustur.Image = Properties.Resources.add_one_button_insert_plus_icon_155856;
            a -= 1;
        }

        private void panelTopMenu_Paint(object sender, PaintEventArgs e)
        {

        } 

        private void FrmAnaEkran_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            otelKaydıSorgulama();
            if (pbOlustur.Visible == true)
            {
                pbPanelAcKapa.Enabled = false;
                panelYanMenu.Visible = false;
            }
            else
            {
                pbPanelAcKapa.Enabled = true;
                panelYanMenu.Visible = true;

            }
            pictureBox1.BackColor = Color.FromArgb(192, 255, 192);
        }
        int otelButton = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (otelButton == 0)
            {
                pictureBox1.BackColor = Color.FromArgb(244, 217, 80);                
            }
            this.BackColor = Color.FromArgb(165, 165, 165);
            FrmOtelDüzenleme frm = new FrmOtelDüzenleme();
            frm.lblTcNo = lblTcNo.Text;
            frm.otelKodu = lblOtelKodu.Text;
            frm.ShowDialog();

           
        }
        void tcNoGetır()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Kisiler WHERE kisiKul=@p1 AND kisiYetki=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", lblKullanıcıAdıBilgisi.Text);
            komut.Parameters.AddWithValue("@p2", lblGirisYetkisiBilgisi.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblTcNo.Text = oku["kisiTc"].ToString();
            }

            baglanti.Close();

        }

    }
}
