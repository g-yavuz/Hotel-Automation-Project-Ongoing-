namespace otelloutoV1
{
    partial class FrmOrtakGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrtakGirisi));
            panelTopMenu = new Panel();
            pictureBox2 = new PictureBox();
            Btn_Cikis = new Button();
            label1 = new Label();
            groupOtelKodu = new GroupBox();
            lblOtelVarYok = new Label();
            txtOtelKodu = new TextBox();
            groupOtelAdi = new GroupBox();
            txtOtelAdi = new TextBox();
            groupOnayKodu = new GroupBox();
            txtOnayKodu = new TextBox();
            btnNext = new Button();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupOtelKodu.SuspendLayout();
            groupOtelAdi.SuspendLayout();
            groupOnayKodu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.FromArgb(220, 54, 54);
            panelTopMenu.Controls.Add(pictureBox2);
            panelTopMenu.Controls.Add(Btn_Cikis);
            panelTopMenu.Controls.Add(label1);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Margin = new Padding(4);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(508, 59);
            panelTopMenu.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 56);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Btn_Cikis
            // 
            Btn_Cikis.BackColor = Color.FromArgb(255, 19, 19);
            Btn_Cikis.Cursor = Cursors.Hand;
            Btn_Cikis.Dock = DockStyle.Right;
            Btn_Cikis.FlatAppearance.BorderSize = 0;
            Btn_Cikis.FlatStyle = FlatStyle.Flat;
            Btn_Cikis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_Cikis.ForeColor = Color.White;
            Btn_Cikis.Location = new Point(458, 0);
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
            label1.Size = new Size(239, 31);
            label1.TabIndex = 0;
            label1.Text = "[ORTAK GİRİŞ EKRANI]";
            // 
            // groupOtelKodu
            // 
            groupOtelKodu.Controls.Add(lblOtelVarYok);
            groupOtelKodu.Controls.Add(txtOtelKodu);
            groupOtelKodu.ForeColor = Color.FromArgb(17, 55, 64);
            groupOtelKodu.Location = new Point(52, 84);
            groupOtelKodu.Name = "groupOtelKodu";
            groupOtelKodu.Size = new Size(250, 65);
            groupOtelKodu.TabIndex = 36;
            groupOtelKodu.TabStop = false;
            groupOtelKodu.Text = "OTEL KODU";
            // 
            // lblOtelVarYok
            // 
            lblOtelVarYok.AutoSize = true;
            lblOtelVarYok.Location = new Point(114, 12);
            lblOtelVarYok.Name = "lblOtelVarYok";
            lblOtelVarYok.Size = new Size(133, 20);
            lblOtelVarYok.TabIndex = 41;
            lblOtelVarYok.Text = "lblOtelKoduVarYok";
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
            // groupOtelAdi
            // 
            groupOtelAdi.Controls.Add(txtOtelAdi);
            groupOtelAdi.ForeColor = Color.FromArgb(17, 55, 64);
            groupOtelAdi.Location = new Point(52, 159);
            groupOtelAdi.Name = "groupOtelAdi";
            groupOtelAdi.Size = new Size(250, 65);
            groupOtelAdi.TabIndex = 37;
            groupOtelAdi.TabStop = false;
            groupOtelAdi.Text = "OTEL ADI";
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
            // groupOnayKodu
            // 
            groupOnayKodu.Controls.Add(txtOnayKodu);
            groupOnayKodu.ForeColor = Color.FromArgb(17, 55, 64);
            groupOnayKodu.Location = new Point(52, 242);
            groupOnayKodu.Name = "groupOnayKodu";
            groupOnayKodu.Size = new Size(250, 65);
            groupOnayKodu.TabIndex = 38;
            groupOnayKodu.TabStop = false;
            groupOnayKodu.Text = "ONAY KODU";
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
            // btnNext
            // 
            btnNext.BackColor = Color.Green;
            btnNext.Cursor = Cursors.Hand;
            btnNext.Enabled = false;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(52, 349);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(400, 50);
            btnNext.TabIndex = 39;
            btnNext.Text = "ONAY KODUNA GÖNDER";
            btnNext.TextAlign = ContentAlignment.TopCenter;
            btnNext.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_plus_48;
            pictureBox1.Location = new Point(310, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "OTEL KODUNU SORGULAMA");
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // FrmOrtakGirisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 500);
            Controls.Add(pictureBox1);
            Controls.Add(btnNext);
            Controls.Add(groupOnayKodu);
            Controls.Add(groupOtelAdi);
            Controls.Add(groupOtelKodu);
            Controls.Add(panelTopMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmOrtakGirisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOrtakGirisi";
            Load += FrmOrtakGirisi_Load;
            panelTopMenu.ResumeLayout(false);
            panelTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupOtelKodu.ResumeLayout(false);
            groupOtelKodu.PerformLayout();
            groupOtelAdi.ResumeLayout(false);
            groupOtelAdi.PerformLayout();
            groupOnayKodu.ResumeLayout(false);
            groupOnayKodu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTopMenu;
        private PictureBox pictureBox2;
        private Button Btn_Cikis;
        private Label label1;
        private GroupBox groupOtelKodu;
        private TextBox txtOtelKodu;
        private GroupBox groupOtelAdi;
        private TextBox txtOtelAdi;
        private GroupBox groupOnayKodu;
        private TextBox txtOnayKodu;
        private Button btnNext;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Label lblOtelVarYok;
    }
}