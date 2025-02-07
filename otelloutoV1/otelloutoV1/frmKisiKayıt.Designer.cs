namespace otelloutoV1
{
    partial class frmKisiKayıt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKisiKayıt));
            panelTopMenu = new Panel();
            Btn_Cikis = new Button();
            label1 = new Label();
            groupTcIdentity = new GroupBox();
            txtTcIdentity = new TextBox();
            groupName = new GroupBox();
            txtName = new TextBox();
            groupSurname = new GroupBox();
            txtSurname = new TextBox();
            groupGender = new GroupBox();
            rbKadın = new RadioButton();
            rbErkek = new RadioButton();
            maskBirthDate = new MaskedTextBox();
            groupBirthDate = new GroupBox();
            groupCellPhone = new GroupBox();
            maskCellPhone = new MaskedTextBox();
            groupMailAdress = new GroupBox();
            txtMailAdress = new TextBox();
            groupExp = new GroupBox();
            txtExp = new TextBox();
            btnClear = new Button();
            btnNext = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panelTopMenu.SuspendLayout();
            groupTcIdentity.SuspendLayout();
            groupName.SuspendLayout();
            groupSurname.SuspendLayout();
            groupGender.SuspendLayout();
            groupBirthDate.SuspendLayout();
            groupCellPhone.SuspendLayout();
            groupMailAdress.SuspendLayout();
            groupExp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.CadetBlue;
            panelTopMenu.Controls.Add(Btn_Cikis);
            panelTopMenu.Controls.Add(label1);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(792, 50);
            panelTopMenu.TabIndex = 0;
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
            Btn_Cikis.Location = new Point(742, 0);
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "[otelloutoV1]";
            // 
            // groupTcIdentity
            // 
            groupTcIdentity.Controls.Add(txtTcIdentity);
            groupTcIdentity.ForeColor = Color.FromArgb(17, 55, 64);
            groupTcIdentity.Location = new Point(12, 56);
            groupTcIdentity.Name = "groupTcIdentity";
            groupTcIdentity.Size = new Size(250, 65);
            groupTcIdentity.TabIndex = 1;
            groupTcIdentity.TabStop = false;
            groupTcIdentity.Text = "TC KİMLİK NUMARASI";
            // 
            // txtTcIdentity
            // 
            txtTcIdentity.BorderStyle = BorderStyle.None;
            txtTcIdentity.Dock = DockStyle.Bottom;
            txtTcIdentity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTcIdentity.ForeColor = Color.FromArgb(17, 55, 64);
            txtTcIdentity.Location = new Point(3, 40);
            txtTcIdentity.MaxLength = 11;
            txtTcIdentity.Name = "txtTcIdentity";
            txtTcIdentity.Size = new Size(244, 22);
            txtTcIdentity.TabIndex = 2;
            txtTcIdentity.TextAlign = HorizontalAlignment.Center;
            txtTcIdentity.KeyPress += txtTcIdentity_KeyPress;
            // 
            // groupName
            // 
            groupName.Controls.Add(txtName);
            groupName.ForeColor = Color.FromArgb(17, 55, 64);
            groupName.Location = new Point(268, 56);
            groupName.Name = "groupName";
            groupName.Size = new Size(250, 65);
            groupName.TabIndex = 3;
            groupName.TabStop = false;
            groupName.Text = "İSİM";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Dock = DockStyle.Bottom;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtName.ForeColor = Color.FromArgb(17, 55, 64);
            txtName.Location = new Point(3, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(244, 22);
            txtName.TabIndex = 2;
            txtName.TextAlign = HorizontalAlignment.Center;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // groupSurname
            // 
            groupSurname.Controls.Add(txtSurname);
            groupSurname.ForeColor = Color.FromArgb(17, 55, 64);
            groupSurname.Location = new Point(524, 56);
            groupSurname.Name = "groupSurname";
            groupSurname.Size = new Size(250, 65);
            groupSurname.TabIndex = 3;
            groupSurname.TabStop = false;
            groupSurname.Text = "SOYAD";
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.None;
            txtSurname.Dock = DockStyle.Bottom;
            txtSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSurname.ForeColor = Color.FromArgb(17, 55, 64);
            txtSurname.Location = new Point(3, 40);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(244, 22);
            txtSurname.TabIndex = 2;
            txtSurname.TextAlign = HorizontalAlignment.Center;
            txtSurname.KeyPress += txtSurname_KeyPress;
            // 
            // groupGender
            // 
            groupGender.Controls.Add(rbKadın);
            groupGender.Controls.Add(rbErkek);
            groupGender.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupGender.ForeColor = Color.FromArgb(17, 55, 64);
            groupGender.Location = new Point(12, 142);
            groupGender.Name = "groupGender";
            groupGender.Size = new Size(250, 65);
            groupGender.TabIndex = 4;
            groupGender.TabStop = false;
            groupGender.Text = "CİNSİYET";
            // 
            // rbKadın
            // 
            rbKadın.AutoSize = true;
            rbKadın.Cursor = Cursors.Hand;
            rbKadın.Location = new Point(128, 26);
            rbKadın.Name = "rbKadın";
            rbKadın.Size = new Size(72, 24);
            rbKadın.TabIndex = 6;
            rbKadın.Text = "KADIN";
            rbKadın.UseVisualStyleBackColor = true;
            rbKadın.CheckedChanged += rbKadın_CheckedChanged;
            rbKadın.MouseEnter += rbKadın_MouseEnter;
            rbKadın.MouseLeave += rbKadın_MouseLeave;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.BackColor = Color.White;
            rbErkek.Checked = true;
            rbErkek.Cursor = Cursors.Hand;
            rbErkek.Location = new Point(6, 26);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(70, 24);
            rbErkek.TabIndex = 5;
            rbErkek.TabStop = true;
            rbErkek.Text = "ERKEK";
            rbErkek.UseVisualStyleBackColor = false;
            rbErkek.CheckedChanged += rbErkek_CheckedChanged;
            rbErkek.MouseEnter += rbErkek_MouseEnter;
            rbErkek.MouseLeave += rbErkek_MouseLeave;
            // 
            // maskBirthDate
            // 
            maskBirthDate.Dock = DockStyle.Bottom;
            maskBirthDate.Location = new Point(3, 33);
            maskBirthDate.Mask = "00/00/0000";
            maskBirthDate.Name = "maskBirthDate";
            maskBirthDate.Size = new Size(244, 29);
            maskBirthDate.TabIndex = 5;
            maskBirthDate.ValidatingType = typeof(DateTime);
            // 
            // groupBirthDate
            // 
            groupBirthDate.Controls.Add(maskBirthDate);
            groupBirthDate.ForeColor = Color.FromArgb(17, 55, 64);
            groupBirthDate.Location = new Point(268, 142);
            groupBirthDate.Name = "groupBirthDate";
            groupBirthDate.Size = new Size(250, 65);
            groupBirthDate.TabIndex = 4;
            groupBirthDate.TabStop = false;
            groupBirthDate.Text = "DOĞUM TARİHİ";
            // 
            // groupCellPhone
            // 
            groupCellPhone.Controls.Add(maskCellPhone);
            groupCellPhone.ForeColor = Color.FromArgb(17, 55, 64);
            groupCellPhone.Location = new Point(524, 142);
            groupCellPhone.Name = "groupCellPhone";
            groupCellPhone.Size = new Size(250, 65);
            groupCellPhone.TabIndex = 6;
            groupCellPhone.TabStop = false;
            groupCellPhone.Text = "TELEFON NUMARASI";
            // 
            // maskCellPhone
            // 
            maskCellPhone.Dock = DockStyle.Bottom;
            maskCellPhone.Location = new Point(3, 33);
            maskCellPhone.Mask = "(999) 000-0000";
            maskCellPhone.Name = "maskCellPhone";
            maskCellPhone.Size = new Size(244, 29);
            maskCellPhone.TabIndex = 5;
            // 
            // groupMailAdress
            // 
            groupMailAdress.Controls.Add(txtMailAdress);
            groupMailAdress.ForeColor = Color.FromArgb(17, 55, 64);
            groupMailAdress.Location = new Point(12, 236);
            groupMailAdress.Name = "groupMailAdress";
            groupMailAdress.Size = new Size(250, 65);
            groupMailAdress.TabIndex = 4;
            groupMailAdress.TabStop = false;
            groupMailAdress.Text = "MAİL ADRESİ";
            // 
            // txtMailAdress
            // 
            txtMailAdress.BorderStyle = BorderStyle.None;
            txtMailAdress.Dock = DockStyle.Bottom;
            txtMailAdress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtMailAdress.ForeColor = Color.FromArgb(17, 55, 64);
            txtMailAdress.Location = new Point(3, 40);
            txtMailAdress.Name = "txtMailAdress";
            txtMailAdress.Size = new Size(244, 22);
            txtMailAdress.TabIndex = 2;
            txtMailAdress.TextAlign = HorizontalAlignment.Center;
            // 
            // groupExp
            // 
            groupExp.Controls.Add(txtExp);
            groupExp.ForeColor = Color.FromArgb(17, 55, 64);
            groupExp.Location = new Point(268, 236);
            groupExp.Name = "groupExp";
            groupExp.Size = new Size(506, 65);
            groupExp.TabIndex = 5;
            groupExp.TabStop = false;
            groupExp.Text = "AÇIKLAMA";
            // 
            // txtExp
            // 
            txtExp.Dock = DockStyle.Bottom;
            txtExp.Location = new Point(3, 33);
            txtExp.Name = "txtExp";
            txtExp.Size = new Size(500, 29);
            txtExp.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Brown;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(12, 328);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(250, 50);
            btnClear.TabIndex = 2;
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
            btnNext.Location = new Point(268, 328);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(503, 50);
            btnNext.TabIndex = 7;
            btnNext.Text = "SONRAKİ ADIM";
            btnNext.TextAlign = ContentAlignment.TopCenter;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(501, 422);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(649, 426);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(542, 435);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 16;
            label2.Text = "1. ADIM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(178, 0, 64);
            label3.Location = new Point(691, 435);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 17;
            label3.Text = "2. ADIM";
            // 
            // frmKisiKayıt
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(792, 496);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnNext);
            Controls.Add(btnClear);
            Controls.Add(groupExp);
            Controls.Add(groupMailAdress);
            Controls.Add(groupCellPhone);
            Controls.Add(groupBirthDate);
            Controls.Add(groupGender);
            Controls.Add(groupSurname);
            Controls.Add(groupName);
            Controls.Add(groupTcIdentity);
            Controls.Add(panelTopMenu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmKisiKayıt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelTopMenu.ResumeLayout(false);
            panelTopMenu.PerformLayout();
            groupTcIdentity.ResumeLayout(false);
            groupTcIdentity.PerformLayout();
            groupName.ResumeLayout(false);
            groupName.PerformLayout();
            groupSurname.ResumeLayout(false);
            groupSurname.PerformLayout();
            groupGender.ResumeLayout(false);
            groupGender.PerformLayout();
            groupBirthDate.ResumeLayout(false);
            groupBirthDate.PerformLayout();
            groupCellPhone.ResumeLayout(false);
            groupCellPhone.PerformLayout();
            groupMailAdress.ResumeLayout(false);
            groupMailAdress.PerformLayout();
            groupExp.ResumeLayout(false);
            groupExp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTopMenu;
        private Button Btn_Cikis;
        private Label label1;
        private GroupBox groupTcIdentity;
        private TextBox txtTcIdentity;
        private GroupBox groupName;
        private TextBox txtName;
        private GroupBox groupSurname;
        private TextBox txtSurname;
        private GroupBox groupGender;
        private RadioButton rbKadın;
        private RadioButton rbErkek;
        private MaskedTextBox maskBirthDate;
        private GroupBox groupBirthDate;
        private GroupBox groupCellPhone;
        private MaskedTextBox maskCellPhone;
        private GroupBox groupMailAdress;
        private TextBox txtMailAdress;
        private GroupBox groupExp;
        private TextBox txtExp;
        private Button btnClear;
        private Button btnNext;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}
