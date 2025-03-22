namespace otelloutoV1
{
    partial class FrmYetkiYönlendirme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYetkiYönlendirme));
            panelTopMenu = new Panel();
            pictureUndo = new PictureBox();
            Btn_Cikis = new Button();
            label1 = new Label();
            groupPassWord = new GroupBox();
            txtSifre = new TextBox();
            groupUserName = new GroupBox();
            txtKullanıcıAdı = new TextBox();
            label2 = new Label();
            btnNext = new Button();
            panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUndo).BeginInit();
            groupPassWord.SuspendLayout();
            groupUserName.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.Goldenrod;
            panelTopMenu.Controls.Add(pictureUndo);
            panelTopMenu.Controls.Add(Btn_Cikis);
            panelTopMenu.Controls.Add(label1);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(557, 50);
            panelTopMenu.TabIndex = 1;
            // 
            // pictureUndo
            // 
            pictureUndo.Cursor = Cursors.Hand;
            pictureUndo.Dock = DockStyle.Left;
            pictureUndo.Image = (Image)resources.GetObject("pictureUndo.Image");
            pictureUndo.Location = new Point(0, 0);
            pictureUndo.Name = "pictureUndo";
            pictureUndo.Size = new Size(48, 50);
            pictureUndo.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureUndo.TabIndex = 4;
            pictureUndo.TabStop = false;
            pictureUndo.Click += pictureUndo_Click;
            // 
            // Btn_Cikis
            // 
            Btn_Cikis.BackColor = Color.FromArgb(17, 55, 64);
            Btn_Cikis.Cursor = Cursors.Hand;
            Btn_Cikis.Dock = DockStyle.Right;
            Btn_Cikis.FlatAppearance.BorderSize = 0;
            Btn_Cikis.FlatStyle = FlatStyle.Flat;
            Btn_Cikis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_Cikis.ForeColor = Color.White;
            Btn_Cikis.Location = new Point(507, 0);
            Btn_Cikis.Name = "Btn_Cikis";
            Btn_Cikis.Size = new Size(50, 50);
            Btn_Cikis.TabIndex = 1;
            Btn_Cikis.Text = "X";
            Btn_Cikis.TextAlign = ContentAlignment.TopCenter;
            Btn_Cikis.UseVisualStyleBackColor = false;
            Btn_Cikis.Click += Btn_Cikis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(54, 11);
            label1.Name = "label1";
            label1.Size = new Size(358, 25);
            label1.TabIndex = 0;
            label1.Text = "[Dikkat Yetki Yönlendirme Ekranındasınız]";
            // 
            // groupPassWord
            // 
            groupPassWord.Controls.Add(txtSifre);
            groupPassWord.ForeColor = Color.FromArgb(17, 55, 64);
            groupPassWord.Location = new Point(285, 153);
            groupPassWord.Name = "groupPassWord";
            groupPassWord.Size = new Size(255, 70);
            groupPassWord.TabIndex = 27;
            groupPassWord.TabStop = false;
            groupPassWord.Text = "ŞİFRE";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.Gainsboro;
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Dock = DockStyle.Bottom;
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.ForeColor = Color.FromArgb(17, 55, 64);
            txtSifre.Location = new Point(3, 45);
            txtSifre.MaxLength = 6;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(249, 22);
            txtSifre.TabIndex = 2;
            txtSifre.TextAlign = HorizontalAlignment.Center;
            // 
            // groupUserName
            // 
            groupUserName.Controls.Add(txtKullanıcıAdı);
            groupUserName.ForeColor = Color.FromArgb(17, 55, 64);
            groupUserName.Location = new Point(24, 153);
            groupUserName.Name = "groupUserName";
            groupUserName.Size = new Size(255, 70);
            groupUserName.TabIndex = 26;
            groupUserName.TabStop = false;
            groupUserName.Text = "KULLANICI ADI";
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.BackColor = Color.Gainsboro;
            txtKullanıcıAdı.BorderStyle = BorderStyle.None;
            txtKullanıcıAdı.Dock = DockStyle.Bottom;
            txtKullanıcıAdı.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullanıcıAdı.ForeColor = Color.FromArgb(17, 55, 64);
            txtKullanıcıAdı.Location = new Point(3, 45);
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.Size = new Size(249, 22);
            txtKullanıcıAdı.TabIndex = 2;
            txtKullanıcıAdı.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Cross;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(63, 75);
            label2.Name = "label2";
            label2.Size = new Size(432, 54);
            label2.TabIndex = 28;
            label2.Text = "SAHİP OLDUĞUNUZ ŞİFRE VE KULLANICI ADINI PERSONELLERİNİZ İLE PAYLAŞMAYINIZ!..";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Green;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(24, 250);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(503, 41);
            btnNext.TabIndex = 29;
            btnNext.Text = "İŞLEME DEVAM ET >";
            btnNext.TextAlign = ContentAlignment.TopCenter;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // FrmYetkiYönlendirme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(557, 320);
            Controls.Add(btnNext);
            Controls.Add(label2);
            Controls.Add(groupPassWord);
            Controls.Add(groupUserName);
            Controls.Add(panelTopMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmYetkiYönlendirme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmYetkiYönlendirme";
            panelTopMenu.ResumeLayout(false);
            panelTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUndo).EndInit();
            groupPassWord.ResumeLayout(false);
            groupPassWord.PerformLayout();
            groupUserName.ResumeLayout(false);
            groupUserName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopMenu;
        private Button Btn_Cikis;
        private Label label1;
        private GroupBox groupPassWord;
        private TextBox txtSifre;
        private GroupBox groupUserName;
        private TextBox txtKullanıcıAdı;
        private Label label2;
        private PictureBox pictureUndo;
        private Button btnNext;
    }
}