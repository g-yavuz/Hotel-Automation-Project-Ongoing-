namespace otelloutoV1
{
    partial class frmOtelKayitEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtelKayitEkrani));
            panelTopMenu = new Panel();
            pictureBox2 = new PictureBox();
            Btn_Cikis = new Button();
            label1 = new Label();
            groupOtelType = new GroupBox();
            rbBireysel = new RadioButton();
            rbOrtak = new RadioButton();
            groupOtelName = new GroupBox();
            txtOtelName = new TextBox();
            groupBoxOtelExp = new GroupBox();
            label2 = new Label();
            txtOtelExp = new TextBox();
            btnClear = new Button();
            btnNext = new Button();
            lblKisiTc = new Label();
            lblOtelKodu = new Label();
            panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupOtelType.SuspendLayout();
            groupOtelName.SuspendLayout();
            groupBoxOtelExp.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.FromArgb(77, 184, 104);
            panelTopMenu.Controls.Add(pictureBox2);
            panelTopMenu.Controls.Add(Btn_Cikis);
            panelTopMenu.Controls.Add(label1);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Margin = new Padding(4);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(598, 57);
            panelTopMenu.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 48);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Btn_Cikis
            // 
            Btn_Cikis.BackColor = Color.FromArgb(2, 152, 13);
            Btn_Cikis.Cursor = Cursors.Hand;
            Btn_Cikis.Dock = DockStyle.Right;
            Btn_Cikis.FlatAppearance.BorderSize = 0;
            Btn_Cikis.FlatStyle = FlatStyle.Flat;
            Btn_Cikis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_Cikis.ForeColor = Color.White;
            Btn_Cikis.Location = new Point(548, 0);
            Btn_Cikis.Margin = new Padding(4);
            Btn_Cikis.Name = "Btn_Cikis";
            Btn_Cikis.Size = new Size(50, 57);
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
            label1.Location = new Point(66, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 31);
            label1.TabIndex = 0;
            label1.Text = "[OTEL KAYIT EKRANI]";
            // 
            // groupOtelType
            // 
            groupOtelType.Controls.Add(rbBireysel);
            groupOtelType.Controls.Add(rbOrtak);
            groupOtelType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupOtelType.ForeColor = Color.FromArgb(17, 55, 64);
            groupOtelType.Location = new Point(330, 89);
            groupOtelType.Name = "groupOtelType";
            groupOtelType.Size = new Size(250, 65);
            groupOtelType.TabIndex = 5;
            groupOtelType.TabStop = false;
            groupOtelType.Text = "OTEL TÜRÜ";
            // 
            // rbBireysel
            // 
            rbBireysel.AutoSize = true;
            rbBireysel.Checked = true;
            rbBireysel.Cursor = Cursors.Hand;
            rbBireysel.Location = new Point(6, 30);
            rbBireysel.Name = "rbBireysel";
            rbBireysel.Size = new Size(105, 29);
            rbBireysel.TabIndex = 6;
            rbBireysel.TabStop = true;
            rbBireysel.Text = "BİREYSEL";
            rbBireysel.UseVisualStyleBackColor = true;
            // 
            // rbOrtak
            // 
            rbOrtak.AutoSize = true;
            rbOrtak.BackColor = SystemColors.Control;
            rbOrtak.Cursor = Cursors.Hand;
            rbOrtak.Location = new Point(143, 30);
            rbOrtak.Name = "rbOrtak";
            rbOrtak.Size = new Size(87, 29);
            rbOrtak.TabIndex = 5;
            rbOrtak.Text = "ORTAK";
            rbOrtak.UseVisualStyleBackColor = false;
            rbOrtak.CheckedChanged += rbOrtak_CheckedChanged;
            // 
            // groupOtelName
            // 
            groupOtelName.Controls.Add(txtOtelName);
            groupOtelName.ForeColor = Color.FromArgb(17, 55, 64);
            groupOtelName.Location = new Point(12, 89);
            groupOtelName.Name = "groupOtelName";
            groupOtelName.Size = new Size(250, 65);
            groupOtelName.TabIndex = 6;
            groupOtelName.TabStop = false;
            groupOtelName.Text = "OTEL ADI";
            // 
            // txtOtelName
            // 
            txtOtelName.BorderStyle = BorderStyle.None;
            txtOtelName.Dock = DockStyle.Bottom;
            txtOtelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOtelName.ForeColor = Color.FromArgb(17, 55, 64);
            txtOtelName.Location = new Point(3, 35);
            txtOtelName.Name = "txtOtelName";
            txtOtelName.Size = new Size(244, 27);
            txtOtelName.TabIndex = 2;
            txtOtelName.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBoxOtelExp
            // 
            groupBoxOtelExp.Controls.Add(label2);
            groupBoxOtelExp.Controls.Add(txtOtelExp);
            groupBoxOtelExp.ForeColor = Color.FromArgb(17, 55, 64);
            groupBoxOtelExp.Location = new Point(12, 176);
            groupBoxOtelExp.Name = "groupBoxOtelExp";
            groupBoxOtelExp.Size = new Size(568, 189);
            groupBoxOtelExp.TabIndex = 7;
            groupBoxOtelExp.TabStop = false;
            groupBoxOtelExp.Text = "OTEL AÇIKLAMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 3);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 32;
            label2.Text = "Karakter Sayınız:";
            label2.Click += label2_Click;
            // 
            // txtOtelExp
            // 
            txtOtelExp.BorderStyle = BorderStyle.None;
            txtOtelExp.Dock = DockStyle.Bottom;
            txtOtelExp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOtelExp.ForeColor = Color.FromArgb(17, 55, 64);
            txtOtelExp.Location = new Point(3, 26);
            txtOtelExp.Multiline = true;
            txtOtelExp.Name = "txtOtelExp";
            txtOtelExp.Size = new Size(562, 160);
            txtOtelExp.TabIndex = 2;
            txtOtelExp.TextAlign = HorizontalAlignment.Center;
            txtOtelExp.TextChanged += txtOtelExp_TextChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Brown;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(30, 394);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(250, 50);
            btnClear.TabIndex = 31;
            btnClear.Text = "TEMİZLE";
            btnClear.TextAlign = ContentAlignment.TopCenter;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Green;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(306, 394);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(255, 50);
            btnNext.TabIndex = 30;
            btnNext.Text = "KAYDET";
            btnNext.TextAlign = ContentAlignment.TopCenter;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblKisiTc
            // 
            lblKisiTc.AutoSize = true;
            lblKisiTc.Location = new Point(30, 471);
            lblKisiTc.Name = "lblKisiTc";
            lblKisiTc.Size = new Size(50, 20);
            lblKisiTc.TabIndex = 32;
            lblKisiTc.Text = "label3";
            lblKisiTc.Visible = false;
            // 
            // lblOtelKodu
            // 
            lblOtelKodu.AutoSize = true;
            lblOtelKodu.Location = new Point(397, 471);
            lblOtelKodu.Name = "lblOtelKodu";
            lblOtelKodu.Size = new Size(91, 20);
            lblOtelKodu.TabIndex = 33;
            lblOtelKodu.Text = "lbl otelKodu";
            // 
            // frmOtelKayitEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 500);
            Controls.Add(lblOtelKodu);
            Controls.Add(lblKisiTc);
            Controls.Add(btnClear);
            Controls.Add(btnNext);
            Controls.Add(groupBoxOtelExp);
            Controls.Add(groupOtelName);
            Controls.Add(groupOtelType);
            Controls.Add(panelTopMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOtelKayitEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOtelKayitEkrani";
            Load += frmOtelKayitEkrani_Load;
            panelTopMenu.ResumeLayout(false);
            panelTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupOtelType.ResumeLayout(false);
            groupOtelType.PerformLayout();
            groupOtelName.ResumeLayout(false);
            groupOtelName.PerformLayout();
            groupBoxOtelExp.ResumeLayout(false);
            groupBoxOtelExp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTopMenu;
        private PictureBox pictureBox2;
        private Button Btn_Cikis;
        private Label label1;
        private GroupBox groupOtelType;
        private RadioButton rbBireysel;
        private RadioButton rbOrtak;
        private GroupBox groupOtelName;
        private TextBox txtOtelName;
        private GroupBox groupBoxOtelExp;
        private TextBox txtOtelExp;
        private Button btnClear;
        private Button btnNext;
        private Label label2;
        public Label lblKisiTc;
        public Label lblOtelKodu;
    }
}