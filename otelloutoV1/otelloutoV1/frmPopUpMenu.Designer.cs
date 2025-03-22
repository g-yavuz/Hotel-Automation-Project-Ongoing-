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
            panelTopMenu.Margin = new Padding(3, 2, 3, 2);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(372, 28);
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
            Btn_Cikis.Location = new Point(328, 0);
            Btn_Cikis.Margin = new Padding(3, 2, 3, 2);
            Btn_Cikis.Name = "Btn_Cikis";
            Btn_Cikis.Size = new Size(44, 28);
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
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 0;
            label1.Text = "[UYARI!]";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(10, 33);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 129);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 94);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 18);
            label2.Name = "label2";
            label2.Size = new Size(332, 59);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmPopUpMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(372, 175);
            Controls.Add(panel1);
            Controls.Add(panelTopMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPopUpMenu";
            ShowInTaskbar = false;
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