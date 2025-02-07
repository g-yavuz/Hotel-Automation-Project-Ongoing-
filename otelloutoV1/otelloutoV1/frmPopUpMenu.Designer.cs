namespace otelloutoV1
{
    partial class frmPopUpMenu
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
            panelTopMenu = new Panel();
            Btn_Cikis = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelTopMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.Crimson;
            panelTopMenu.Controls.Add(Btn_Cikis);
            panelTopMenu.Controls.Add(label1);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(425, 38);
            panelTopMenu.TabIndex = 1;
            // 
            // Btn_Cikis
            // 
            Btn_Cikis.BackColor = Color.DarkSlateGray;
            Btn_Cikis.Cursor = Cursors.Hand;
            Btn_Cikis.Dock = DockStyle.Right;
            Btn_Cikis.FlatAppearance.BorderSize = 0;
            Btn_Cikis.FlatStyle = FlatStyle.Flat;
            Btn_Cikis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_Cikis.ForeColor = Color.White;
            Btn_Cikis.Location = new Point(375, 0);
            Btn_Cikis.Name = "Btn_Cikis";
            Btn_Cikis.Size = new Size(50, 38);
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
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 31);
            label1.TabIndex = 0;
            label1.Text = "[UYARI!]";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 172);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 125);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Stencil", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 24);
            label2.Name = "label2";
            label2.Size = new Size(380, 79);
            label2.TabIndex = 0;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmPopUpMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(425, 233);
            Controls.Add(panel1);
            Controls.Add(panelTopMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPopUpMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPopUpMenu";
            panelTopMenu.ResumeLayout(false);
            panelTopMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopMenu;
        private Button Btn_Cikis;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        public Label label2;
    }
}