namespace otelloutoV1
{
    partial class FrmKodOlusturma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKodOlusturma));
            panelTopMenu = new Panel();
            pictureBox2 = new PictureBox();
            Btn_Cikis = new Button();
            label1 = new Label();
            groupOtelAdi = new GroupBox();
            txtOtelKodu = new TextBox();
            groupBox1 = new GroupBox();
            txtOtelAdi = new TextBox();
            groupBox2 = new GroupBox();
            txtTcNo = new TextBox();
            groupBox3 = new GroupBox();
            txtOnayKodu = new TextBox();
            btnOlustur = new Button();
            panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupOtelAdi.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.FromArgb(129, 124, 124);
            panelTopMenu.Controls.Add(pictureBox2);
            panelTopMenu.Controls.Add(Btn_Cikis);
            panelTopMenu.Controls.Add(label1);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Margin = new Padding(4);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(636, 59);
            panelTopMenu.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 56);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Btn_Cikis
            // 
            Btn_Cikis.BackColor = Color.FromArgb(83, 66, 66);
            Btn_Cikis.Cursor = Cursors.Hand;
            Btn_Cikis.Dock = DockStyle.Right;
            Btn_Cikis.FlatAppearance.BorderSize = 0;
            Btn_Cikis.FlatStyle = FlatStyle.Flat;
            Btn_Cikis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_Cikis.ForeColor = Color.White;
            Btn_Cikis.Location = new Point(586, 0);
            Btn_Cikis.Margin = new Padding(4);
            Btn_Cikis.Name = "Btn_Cikis";
            Btn_Cikis.Size = new Size(50, 59);
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
            label1.Location = new Point(52, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 31);
            label1.TabIndex = 0;
            label1.Text = "[KOD OLUŞTURMA EKRANI]";
            // 
            // groupOtelAdi
            // 
            groupOtelAdi.Controls.Add(txtOtelKodu);
            groupOtelAdi.ForeColor = Color.FromArgb(17, 55, 64);
            groupOtelAdi.Location = new Point(41, 87);
            groupOtelAdi.Name = "groupOtelAdi";
            groupOtelAdi.Size = new Size(250, 65);
            groupOtelAdi.TabIndex = 38;
            groupOtelAdi.TabStop = false;
            groupOtelAdi.Text = "OTEL KODU";
            // 
            // txtOtelKodu
            // 
            txtOtelKodu.BorderStyle = BorderStyle.None;
            txtOtelKodu.Dock = DockStyle.Bottom;
            txtOtelKodu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOtelKodu.ForeColor = Color.FromArgb(17, 55, 64);
            txtOtelKodu.Location = new Point(3, 35);
            txtOtelKodu.Name = "txtOtelKodu";
            txtOtelKodu.Size = new Size(244, 27);
            txtOtelKodu.TabIndex = 2;
            txtOtelKodu.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOtelAdi);
            groupBox1.ForeColor = Color.FromArgb(17, 55, 64);
            groupBox1.Location = new Point(340, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 65);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "OTEL ADI";
            // 
            // txtOtelAdi
            // 
            txtOtelAdi.BorderStyle = BorderStyle.None;
            txtOtelAdi.Dock = DockStyle.Bottom;
            txtOtelAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOtelAdi.ForeColor = Color.FromArgb(17, 55, 64);
            txtOtelAdi.Location = new Point(3, 35);
            txtOtelAdi.Name = "txtOtelAdi";
            txtOtelAdi.Size = new Size(244, 27);
            txtOtelAdi.TabIndex = 2;
            txtOtelAdi.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTcNo);
            groupBox2.ForeColor = Color.FromArgb(17, 55, 64);
            groupBox2.Location = new Point(41, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 65);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "KİŞİ TC KİMLİK NO";
            // 
            // txtTcNo
            // 
            txtTcNo.BorderStyle = BorderStyle.None;
            txtTcNo.Dock = DockStyle.Bottom;
            txtTcNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTcNo.ForeColor = Color.FromArgb(17, 55, 64);
            txtTcNo.Location = new Point(3, 35);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(244, 27);
            txtTcNo.TabIndex = 2;
            txtTcNo.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtOnayKodu);
            groupBox3.ForeColor = Color.FromArgb(17, 55, 64);
            groupBox3.Location = new Point(340, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 65);
            groupBox3.TabIndex = 38;
            groupBox3.TabStop = false;
            groupBox3.Text = "ONAY KODU";
            // 
            // txtOnayKodu
            // 
            txtOnayKodu.BorderStyle = BorderStyle.None;
            txtOnayKodu.Dock = DockStyle.Bottom;
            txtOnayKodu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOnayKodu.ForeColor = Color.FromArgb(17, 55, 64);
            txtOnayKodu.Location = new Point(3, 35);
            txtOnayKodu.Name = "txtOnayKodu";
            txtOnayKodu.Size = new Size(244, 27);
            txtOnayKodu.TabIndex = 2;
            txtOnayKodu.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOlustur
            // 
            btnOlustur.BackColor = Color.Green;
            btnOlustur.Cursor = Cursors.Hand;
            btnOlustur.FlatAppearance.BorderSize = 0;
            btnOlustur.FlatStyle = FlatStyle.Flat;
            btnOlustur.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOlustur.ForeColor = Color.White;
            btnOlustur.Location = new Point(114, 287);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(400, 50);
            btnOlustur.TabIndex = 40;
            btnOlustur.Text = "KODU OLUŞTUR";
            btnOlustur.TextAlign = ContentAlignment.TopCenter;
            btnOlustur.UseVisualStyleBackColor = false;
            // 
            // FrmKodOlusturma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 349);
            Controls.Add(btnOlustur);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupOtelAdi);
            Controls.Add(panelTopMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmKodOlusturma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmKodOlusturma";
            panelTopMenu.ResumeLayout(false);
            panelTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupOtelAdi.ResumeLayout(false);
            groupOtelAdi.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopMenu;
        private PictureBox pictureBox2;
        private Button Btn_Cikis;
        private Label label1;
        private GroupBox groupOtelAdi;
        private TextBox txtOtelKodu;
        private GroupBox groupBox1;
        private TextBox txtOtelAdi;
        private GroupBox groupBox2;
        private TextBox txtTcNo;
        private GroupBox groupBox3;
        private TextBox txtOnayKodu;
        private Button btnOlustur;
    }
}