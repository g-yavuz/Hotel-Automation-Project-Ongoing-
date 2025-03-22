using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelloutoV1
{
    public partial class FrmYetkiYönlendirme : Form
    {
        public FrmYetkiYönlendirme()
        {
            InitializeComponent();
            txtKullanıcıAdı.PasswordChar = '*';
            txtSifre.PasswordChar = '*';
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureUndo_Click(object sender, EventArgs e)
        {
            FrmKullanıcıGiris frm = new FrmKullanıcıGiris();
            frm.Show();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdı.Text == "Admin" && txtSifre.Text == "7791")
            {
                frmKisiKayıt frm = new frmKisiKayıt();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Yanlış Şİfre veya Kullanıcı Adı Yetkililere Uyarı Gönderiliyor...");
            }
        }

    }
}
