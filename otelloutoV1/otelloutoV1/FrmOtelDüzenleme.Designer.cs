namespace otelloutoV1
{
    partial class FrmOtelDüzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOtelDüzenleme));
            panelTopMenu = new Panel();
            pictureBox2 = new PictureBox();
            Btn_Cikis = new Button();
            label1 = new Label();
            btnNext = new Button();
            groupBoxOtelExp = new GroupBox();
            label2 = new Label();
            txtOtelExp = new TextBox();
            groupOtelName = new GroupBox();
            txtOtelName = new TextBox();
            groupOtelType = new GroupBox();
            rbBireysel = new RadioButton();
            rbOrtak = new RadioButton();
            panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBoxOtelExp.SuspendLayout();
            groupOtelName.SuspendLayout();
            groupOtelType.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.FromArgb(244, 217, 80);
            panelTopMenu.Controls.Add(pictureBox2);
            panelTopMenu.Controls.Add(Btn_Cikis);
            panelTopMenu.Controls.Add(label1);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Margin = new Padding(4);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(600, 57);
            panelTopMenu.TabIndex = 3;
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
            Btn_Cikis.BackColor = Color.FromArgb(244, 194, 80);
            Btn_Cikis.Cursor = Cursors.Hand;
            Btn_Cikis.Dock = DockStyle.Right;
            Btn_Cikis.FlatAppearance.BorderSize = 0;
            Btn_Cikis.FlatStyle = FlatStyle.Flat;
            Btn_Cikis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_Cikis.ForeColor = Color.White;
            Btn_Cikis.Location = new Point(550, 0);
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
            label1.Size = new Size(365, 31);
            label1.TabIndex = 0;
            label1.Text = "[OTEL KAYDI DÜZENLEME EKRANI]";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Green;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(100, 400);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(400, 50);
            btnNext.TabIndex = 37;
            btnNext.Text = "GÜNCELLE";
            btnNext.TextAlign = ContentAlignment.TopCenter;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // groupBoxOtelExp
            // 
            groupBoxOtelExp.Controls.Add(label2);
            groupBoxOtelExp.Controls.Add(txtOtelExp);
            groupBoxOtelExp.ForeColor = Color.FromArgb(17, 55, 64);
            groupBoxOtelExp.Location = new Point(12, 177);
            groupBoxOtelExp.Name = "groupBoxOtelExp";
            groupBoxOtelExp.Size = new Size(568, 189);
            groupBoxOtelExp.TabIndex = 36;
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
            // 
            // groupOtelName
            // 
            groupOtelName.Controls.Add(txtOtelName);
            groupOtelName.ForeColor = Color.FromArgb(17, 55, 64);
            groupOtelName.Location = new Point(12, 90);
            groupOtelName.Name = "groupOtelName";
            groupOtelName.Size = new Size(250, 65);
            groupOtelName.TabIndex = 35;
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
            // groupOtelType
            // 
            groupOtelType.Controls.Add(rbBireysel);
            groupOtelType.Controls.Add(rbOrtak);
            groupOtelType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupOtelType.ForeColor = Color.FromArgb(17, 55, 64);
            groupOtelType.Location = new Point(330, 90);
            groupOtelType.Name = "groupOtelType";
            groupOtelType.Size = new Size(250, 65);
            groupOtelType.TabIndex = 34;
            groupOtelType.TabStop = false;
            groupOtelType.Text = "OTEL TÜRÜ";
            groupOtelType.Enter += groupOtelType_Enter;
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
            rbBireysel.CheckedChanged += rbBireysel_CheckedChanged;
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
            // FrmOtelDüzenleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(600, 500);
            Controls.Add(btnNext);
            Controls.Add(groupBoxOtelExp);
            Controls.Add(groupOtelName);
            Controls.Add(groupOtelType);
            Controls.Add(panelTopMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmOtelDüzenleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOtelDüzenleme";
            Load += FrmOtelDüzenleme_Load;
            panelTopMenu.ResumeLayout(false);
            panelTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBoxOtelExp.ResumeLayout(false);
            groupBoxOtelExp.PerformLayout();
            groupOtelName.ResumeLayout(false);
            groupOtelName.PerformLayout();
            groupOtelType.ResumeLayout(false);
            groupOtelType.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopMenu;
        private PictureBox pictureBox2;
        private Button Btn_Cikis;
        private Label label1;
        private Button btnNext;
        private GroupBox groupBoxOtelExp;
        private Label label2;
        private TextBox txtOtelExp;
        private GroupBox groupOtelName;
        private TextBox txtOtelName;
        private GroupBox groupOtelType;
        private RadioButton rbBireysel;
        private RadioButton rbOrtak;
    }
}