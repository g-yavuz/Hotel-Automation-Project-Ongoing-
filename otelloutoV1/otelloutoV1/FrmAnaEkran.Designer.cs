namespace otelloutoV1
{
    partial class FrmAnaEkran
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaEkran));
            panelTopMenu = new Panel();
            pbPanelAcKapa = new PictureBox();
            Btn_Cikis = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panelYanMenu = new Panel();
            pictureBox1 = new PictureBox();
            menuAc = new System.Windows.Forms.Timer(components);
            menuKapa = new System.Windows.Forms.Timer(components);
            pbOlustur = new PictureBox();
            groupBox1 = new GroupBox();
            lblTcNo = new Label();
            lblGirisYetkisiBilgisi = new Label();
            lblKullanıcıAdıBilgisi = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlSecenekler = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            createOtel = new Button();
            btnClear = new Button();
            toolTip1 = new ToolTip(components);
            label5 = new Label();
            lblOtelKodu = new Label();
            panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPanelAcKapa).BeginInit();
            panelYanMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOlustur).BeginInit();
            groupBox1.SuspendLayout();
            pnlSecenekler.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.CadetBlue;
            panelTopMenu.Controls.Add(pbPanelAcKapa);
            panelTopMenu.Controls.Add(Btn_Cikis);
            panelTopMenu.Controls.Add(label1);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Margin = new Padding(5);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(1229, 67);
            panelTopMenu.TabIndex = 2;
            panelTopMenu.Paint += panelTopMenu_Paint;
            // 
            // pbPanelAcKapa
            // 
            pbPanelAcKapa.Cursor = Cursors.Hand;
            pbPanelAcKapa.Image = Properties.Resources._1486395885_plus_80605;
            pbPanelAcKapa.Location = new Point(3, 5);
            pbPanelAcKapa.Margin = new Padding(3, 4, 3, 4);
            pbPanelAcKapa.Name = "pbPanelAcKapa";
            pbPanelAcKapa.Size = new Size(46, 53);
            pbPanelAcKapa.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPanelAcKapa.TabIndex = 3;
            pbPanelAcKapa.TabStop = false;
            pbPanelAcKapa.Click += pbPanelAcKapa_Click;
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
            Btn_Cikis.Location = new Point(1172, 0);
            Btn_Cikis.Margin = new Padding(5);
            Btn_Cikis.Name = "Btn_Cikis";
            Btn_Cikis.Size = new Size(57, 67);
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
            label1.Location = new Point(57, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 31);
            label1.TabIndex = 0;
            label1.Text = "[PROGRAM ANA EKRANI]";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 621);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1229, 19);
            panel1.TabIndex = 3;
            // 
            // panelYanMenu
            // 
            panelYanMenu.BackColor = Color.FromArgb(17, 55, 64);
            panelYanMenu.Controls.Add(pictureBox1);
            panelYanMenu.Dock = DockStyle.Left;
            panelYanMenu.Location = new Point(0, 67);
            panelYanMenu.Margin = new Padding(3, 4, 3, 4);
            panelYanMenu.Name = "panelYanMenu";
            panelYanMenu.Size = new Size(177, 554);
            panelYanMenu.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Otel Kaydı Düzenleme");
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuAc
            // 
            menuAc.Interval = 1;
            menuAc.Tick += menuAc_Tick;
            // 
            // menuKapa
            // 
            menuKapa.Interval = 1;
            menuKapa.Tick += menuKapa_Tick;
            // 
            // pbOlustur
            // 
            pbOlustur.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbOlustur.Cursor = Cursors.Hand;
            pbOlustur.Image = Properties.Resources.add_one_button_insert_plus_icon_155856;
            pbOlustur.Location = new Point(1169, 566);
            pbOlustur.Margin = new Padding(3, 4, 3, 4);
            pbOlustur.Name = "pbOlustur";
            pbOlustur.Size = new Size(48, 48);
            pbOlustur.SizeMode = PictureBoxSizeMode.AutoSize;
            pbOlustur.TabIndex = 5;
            pbOlustur.TabStop = false;
            pbOlustur.Click += pbOlustur_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblOtelKodu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblTcNo);
            groupBox1.Controls.Add(lblGirisYetkisiBilgisi);
            groupBox1.Controls.Add(lblKullanıcıAdıBilgisi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(251, 92);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(312, 374);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Giriş Bilgileri";
            // 
            // lblTcNo
            // 
            lblTcNo.AutoSize = true;
            lblTcNo.Location = new Point(168, 251);
            lblTcNo.Name = "lblTcNo";
            lblTcNo.Size = new Size(50, 20);
            lblTcNo.TabIndex = 5;
            lblTcNo.Text = "label7";
            // 
            // lblGirisYetkisiBilgisi
            // 
            lblGirisYetkisiBilgisi.AutoSize = true;
            lblGirisYetkisiBilgisi.Location = new Point(168, 155);
            lblGirisYetkisiBilgisi.Name = "lblGirisYetkisiBilgisi";
            lblGirisYetkisiBilgisi.Size = new Size(50, 20);
            lblGirisYetkisiBilgisi.TabIndex = 4;
            lblGirisYetkisiBilgisi.Text = "label6";
            // 
            // lblKullanıcıAdıBilgisi
            // 
            lblKullanıcıAdıBilgisi.AutoSize = true;
            lblKullanıcıAdıBilgisi.Location = new Point(168, 69);
            lblKullanıcıAdıBilgisi.Name = "lblKullanıcıAdıBilgisi";
            lblKullanıcıAdıBilgisi.Size = new Size(50, 20);
            lblKullanıcıAdıBilgisi.TabIndex = 3;
            lblKullanıcıAdıBilgisi.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 251);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "Tc No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 155);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 1;
            label3.Text = "Giriş Yetkisi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı Adı:";
            // 
            // pnlSecenekler
            // 
            pnlSecenekler.Anchor = AnchorStyles.Bottom;
            pnlSecenekler.BackColor = Color.FromArgb(17, 55, 64);
            pnlSecenekler.BackgroundImageLayout = ImageLayout.None;
            pnlSecenekler.Controls.Add(button1);
            pnlSecenekler.Controls.Add(panel3);
            pnlSecenekler.Location = new Point(982, 423);
            pnlSecenekler.Margin = new Padding(3, 4, 3, 4);
            pnlSecenekler.Name = "pnlSecenekler";
            pnlSecenekler.Size = new Size(235, 134);
            pnlSecenekler.TabIndex = 7;
            pnlSecenekler.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 55, 64);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(209, 0);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(26, 134);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(createOtel);
            panel3.Controls.Add(btnClear);
            panel3.Location = new Point(3, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(202, 124);
            panel3.TabIndex = 8;
            // 
            // createOtel
            // 
            createOtel.BackColor = Color.Green;
            createOtel.Cursor = Cursors.Hand;
            createOtel.FlatAppearance.BorderSize = 0;
            createOtel.FlatStyle = FlatStyle.Flat;
            createOtel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            createOtel.ForeColor = Color.White;
            createOtel.Location = new Point(3, 5);
            createOtel.Margin = new Padding(3, 4, 3, 4);
            createOtel.Name = "createOtel";
            createOtel.Size = new Size(194, 53);
            createOtel.TabIndex = 30;
            createOtel.Text = "OTEL OLUŞTUR";
            createOtel.TextAlign = ContentAlignment.TopCenter;
            createOtel.UseVisualStyleBackColor = false;
            createOtel.Click += btnNext_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Brown;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(3, 67);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(194, 53);
            btnClear.TabIndex = 31;
            btnClear.Text = "ORTAK GİRİŞİ";
            btnClear.TextAlign = ContentAlignment.TopCenter;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 331);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 6;
            label5.Text = "OtelKodu:";
            // 
            // lblOtelKodu
            // 
            lblOtelKodu.AutoSize = true;
            lblOtelKodu.Location = new Point(168, 331);
            lblOtelKodu.Name = "lblOtelKodu";
            lblOtelKodu.Size = new Size(50, 20);
            lblOtelKodu.TabIndex = 7;
            lblOtelKodu.Text = "label8";
            // 
            // FrmAnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1229, 640);
            Controls.Add(pnlSecenekler);
            Controls.Add(groupBox1);
            Controls.Add(pbOlustur);
            Controls.Add(panelYanMenu);
            Controls.Add(panel1);
            Controls.Add(panelTopMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAnaEkran";
            WindowState = FormWindowState.Maximized;
            Activated += FrmAnaEkran_Activated;
            Load += FrmAnaEkran_Load;
            MouseClick += FrmAnaEkran_MouseClick;
            panelTopMenu.ResumeLayout(false);
            panelTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPanelAcKapa).EndInit();
            panelYanMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOlustur).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlSecenekler.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTopMenu;
        private Button Btn_Cikis;
        private Label label1;
        private PictureBox pbPanelAcKapa;
        private Panel panel1;
        private Panel panelYanMenu;
        private System.Windows.Forms.Timer menuAc;
        private System.Windows.Forms.Timer menuKapa;
        private PictureBox pbOlustur;
        private GroupBox groupBox1;
        private Label lblTcNo;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        public Label lblKullanıcıAdıBilgisi;
        public Label lblGirisYetkisiBilgisi;
        private Panel pnlSecenekler;
        private Panel panel3;
        private Button createOtel;
        private Button btnClear;
        private Button button1;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Label lblOtelKodu;
        private Label label5;
    }
}