namespace otelloutoV1
{
    public partial class frmKisiKay�t : Form
    {
        public frmKisiKay�t()
        {
            InitializeComponent();
        }
        public int genderControl = 0;
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
            Btn_Cikis.BackColor = Color.FromArgb(17, 55, 64);
        }


        private void rbErkek_MouseEnter(object sender, EventArgs e)
        {
            rbErkek.BackColor = Color.LightGray;
        }

        private void rbErkek_MouseLeave(object sender, EventArgs e)
        {

            rbErkek.BackColor = Color.White;

        }

        private void rbKad�n_MouseEnter(object sender, EventArgs e)
        {
            rbKad�n.BackColor = Color.LightGray;
        }

        private void rbKad�n_MouseLeave(object sender, EventArgs e)
        {
            rbKad�n.BackColor = Color.White;

        }
        string tc, ad, soyad, dogumt, tel, mail, aciklam, cinsiyet;
        private void btnNext_Click(object sender, EventArgs e)
        {   // Bo� bir alan b�rak�lmamas� kontrol� yap�lacakt�r
            // Bo� bir alan yoksa de�er atamalar� ger�ekle�tirilecektir
            if (txtTcIdentity.Text != "" && txtSurname.Text != "" && txtName.Text != "" && txtMailAdress.Text != "" && txtExp.Text != "" && maskBirthDate.Text != "" && maskCellPhone.Text != "")
            {
                tc = txtTcIdentity.Text;
                ad = txtName.Text;
                soyad = txtSurname.Text;
                dogumt = maskBirthDate.Text;
                tel = maskCellPhone.Text;
                mail = txtMailAdress.Text;
                aciklam = txtExp.Text;
                if (rbErkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kad�n";
                }

                frmKisiKayit2 frm = new frmKisiKayit2();
                frm.ad = ad;
                frm.soyad = soyad;
                frm.dogumt = dogumt;
                frm.tel = tel;
                frm.mail = mail;
                frm.aciklam = aciklam;
                frm.cinsiyet = cinsiyet;
                frm.Show();
                this.Hide();
            }
            //bo� alan varsa uyar� ��kacakt�r
            else
            {
                frmPopUpMenu frm = new frmPopUpMenu();
                frm.label2.Text = "L�TFEN BO� KALAN KISIMLARI DOLDURUNUZ";
                frm.Show();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Dolu olan text'leri bo�altma i�lemi yap�lacakt�r
            txtTcIdentity.Text = "";
            txtSurname.Text = "";
            txtName.Text = "";
            txtMailAdress.Text = "";
            txtExp.Text = "";
            maskBirthDate.Text = "";
            maskCellPhone.Text = "";

            rbErkek.Checked = true;
            rbKad�n.Checked = false;
            genderControl = 0;
            txtTcIdentity.Focus();
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            genderControl = 0;
        }

        private void rbKad�n_CheckedChanged(object sender, EventArgs e)
        {
            genderControl = 1;
        }

        private void txtTcIdentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // tc k�sm�na 11 say� girilmesi kontrol� yap�lacakt�r
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
