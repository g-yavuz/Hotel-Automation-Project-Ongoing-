namespace otelloutoV1
{
    partial class FrmKullanıcıGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanıcıGiris));
            panelTopMenu = new Panel();
            pictureBox2 = new PictureBox();
            Btn_Cikis = new Button();
            label1 = new Label();
            groupPassWord = new GroupBox();
            txtSifre = new TextBox();
            groupUserName = new GroupBox();
            txtKullanıcıAdı = new TextBox();
            groupEntryType = new GroupBox();
            rbPersonel = new RadioButton();
            rbYetkili = new RadioButton();
            groupSecurityControl = new GroupBox();
            textBox1 = new TextBox();
            lbl_Güvenlik = new Label();
            btnNext = new Button();
            btnClear = new Button();
            pictureBox1 = new PictureBox();
            panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupPassWord.SuspendLayout();
            groupUserName.SuspendLayout();
            groupEntryType.SuspendLayout();
            groupSecurityControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.CadetBlue;
            panelTopMenu.Controls.Add(pictureBox2);
            panelTopMenu.Controls.Add(Btn_Cikis);
            panelTopMenu.Controls.Add(label1);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Margin = new Padding(4);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(702, 50);
            panelTopMenu.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 38);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
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
            Btn_Cikis.Location = new Point(652, 0);
            Btn_Cikis.Margin = new Padding(4);
            Btn_Cikis.Name = "Btn_Cikis";
            Btn_Cikis.Size = new Size(50, 50);
            Btn_Cikis.TabIndex = 1;
            Btn_Cikis.Text = "X";
            Btn_Cikis.TextAlign = ContentAlignment.TopCenter;
            Btn_Cikis.UseVisualStyleBackColor = false;
            Btn_Cikis.Click += Btn_Cikis_Click;
            Btn_Cikis.MouseEnter += Btn_Cikis_MouseEnter;
            Btn_Cikis.MouseLeave += Btn_Cikis_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(52, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(281, 31);
            label1.TabIndex = 0;
            label1.Text = "[KULLANICI GİRİŞ EKRANI]";
            // 
            // groupPassWord
            // 
            groupPassWord.Controls.Add(txtSifre);
            groupPassWord.ForeColor = Color.FromArgb(17, 55, 64);
            groupPassWord.Location = new Point(403, 128);
            groupPassWord.Name = "groupPassWord";
            groupPassWord.Size = new Size(255, 70);
            groupPassWord.TabIndex = 25;
            groupPassWord.TabStop = false;
            groupPassWord.Text = "ŞİFRE";
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Dock = DockStyle.Bottom;
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.ForeColor = Color.FromArgb(17, 55, 64);
            txtSifre.Location = new Point(3, 40);
            txtSifre.MaxLength = 6;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(249, 27);
            txtSifre.TabIndex = 2;
            txtSifre.Text = "779111";
            txtSifre.TextAlign = HorizontalAlignment.Center;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // groupUserName
            // 
            groupUserName.Controls.Add(txtKullanıcıAdı);
            groupUserName.ForeColor = Color.FromArgb(17, 55, 64);
            groupUserName.Location = new Point(122, 128);
            groupUserName.Name = "groupUserName";
            groupUserName.Size = new Size(255, 70);
            groupUserName.TabIndex = 24;
            groupUserName.TabStop = false;
            groupUserName.Text = "KULLANICI ADI";
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.BorderStyle = BorderStyle.None;
            txtKullanıcıAdı.Dock = DockStyle.Bottom;
            txtKullanıcıAdı.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullanıcıAdı.ForeColor = Color.FromArgb(17, 55, 64);
            txtKullanıcıAdı.Location = new Point(3, 40);
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.Size = new Size(249, 27);
            txtKullanıcıAdı.TabIndex = 2;
            txtKullanıcıAdı.Text = "Kvothe";
            txtKullanıcıAdı.TextAlign = HorizontalAlignment.Center;
            // 
            // groupEntryType
            // 
            groupEntryType.Controls.Add(rbPersonel);
            groupEntryType.Controls.Add(rbYetkili);
            groupEntryType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupEntryType.ForeColor = Color.FromArgb(17, 55, 64);
            groupEntryType.Location = new Point(122, 57);
            groupEntryType.Name = "groupEntryType";
            groupEntryType.Size = new Size(255, 65);
            groupEntryType.TabIndex = 26;
            groupEntryType.TabStop = false;
            groupEntryType.Text = "GİRİŞ TÜRÜ";
            // 
            // rbPersonel
            // 
            rbPersonel.AutoSize = true;
            rbPersonel.Cursor = Cursors.Hand;
            rbPersonel.Location = new Point(128, 26);
            rbPersonel.Name = "rbPersonel";
            rbPersonel.Size = new Size(117, 29);
            rbPersonel.TabIndex = 6;
            rbPersonel.Text = "PERSONEL";
            rbPersonel.UseVisualStyleBackColor = true;
            // 
            // rbYetkili
            // 
            rbYetkili.AutoSize = true;
            rbYetkili.BackColor = Color.White;
            rbYetkili.Checked = true;
            rbYetkili.Cursor = Cursors.Hand;
            rbYetkili.Location = new Point(6, 26);
            rbYetkili.Name = "rbYetkili";
            rbYetkili.Size = new Size(89, 29);
            rbYetkili.TabIndex = 5;
            rbYetkili.TabStop = true;
            rbYetkili.Text = "YETKİLİ";
            rbYetkili.UseVisualStyleBackColor = false;
            // 
            // groupSecurityControl
            // 
            groupSecurityControl.Controls.Add(textBox1);
            groupSecurityControl.Controls.Add(lbl_Güvenlik);
            groupSecurityControl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupSecurityControl.ForeColor = Color.FromArgb(17, 55, 64);
            groupSecurityControl.Location = new Point(403, 57);
            groupSecurityControl.Name = "groupSecurityControl";
            groupSecurityControl.Size = new Size(255, 65);
            groupSecurityControl.TabIndex = 27;
            groupSecurityControl.TabStop = false;
            groupSecurityControl.Text = "GÜVENLİK KONTROL";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 30);
            textBox1.MaxLength = 2;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 31);
            textBox1.TabIndex = 32;
            // 
            // lbl_Güvenlik
            // 
            lbl_Güvenlik.AutoSize = true;
            lbl_Güvenlik.Location = new Point(6, 30);
            lbl_Güvenlik.Name = "lbl_Güvenlik";
            lbl_Güvenlik.Size = new Size(59, 25);
            lbl_Güvenlik.TabIndex = 30;
            lbl_Güvenlik.Text = "label2";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Green;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(403, 218);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(255, 50);
            btnNext.TabIndex = 28;
            btnNext.Text = "TAMAMLA";
            btnNext.TextAlign = ContentAlignment.TopCenter;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Brown;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(127, 218);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(250, 50);
            btnClear.TabIndex = 29;
            btnClear.Text = "TEMİZLE";
            btnClear.TextAlign = ContentAlignment.TopCenter;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // FrmKullanıcıGiris
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(702, 402);
            Controls.Add(pictureBox1);
            Controls.Add(btnClear);
            Controls.Add(btnNext);
            Controls.Add(groupSecurityControl);
            Controls.Add(groupEntryType);
            Controls.Add(groupPassWord);
            Controls.Add(groupUserName);
            Controls.Add(panelTopMenu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmKullanıcıGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmKullanıcıGiris";
            Load += FrmKullanıcıGiris_Load;
            panelTopMenu.ResumeLayout(false);
            panelTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupPassWord.ResumeLayout(false);
            groupPassWord.PerformLayout();
            groupUserName.ResumeLayout(false);
            groupUserName.PerformLayout();
            groupEntryType.ResumeLayout(false);
            groupEntryType.PerformLayout();
            groupSecurityControl.ResumeLayout(false);
            groupSecurityControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTopMenu;
        private Button Btn_Cikis;
        private Label label1;
        private GroupBox groupPassWord;
        private TextBox txtSifre;
        private GroupBox groupUserName;
        private TextBox txtKullanıcıAdı;
        private GroupBox groupEntryType;
        private RadioButton rbPersonel;
        private RadioButton rbYetkili;
        private GroupBox groupSecurityControl;
        private Button btnNext;
        private Button btnClear;
        private Label lbl_Güvenlik;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}