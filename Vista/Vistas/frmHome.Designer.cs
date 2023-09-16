namespace Vista.HOME
{
    partial class frmHome
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
            panel1 = new Panel();
            btnExit = new PictureBox();
            btnMinus = new PictureBox();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnHome = new CustomControls.RJControls.RJButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            btnUser = new FontAwesome.Sharp.IconButton();
            btnShop = new FontAwesome.Sharp.IconButton();
            btnReport = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinus).BeginInit();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnMinus);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 30);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Right;
            btnExit.Image = Properties.Resources.Close;
            btnExit.Location = new Point(977, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(20, 20);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 20;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // btnMinus
            // 
            btnMinus.Anchor = AnchorStyles.Right;
            btnMinus.Image = Properties.Resources.Minimizar;
            btnMinus.Location = new Point(934, 3);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(20, 20);
            btnMinus.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinus.TabIndex = 21;
            btnMinus.TabStop = false;
            btnMinus.Click += btnMinus_Click;
            btnMinus.MouseEnter += btnMinus_MouseEnter;
            btnMinus.MouseLeave += btnMinus_MouseLeave;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 620);
            panel3.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.MidnightBlue;
            flowLayoutPanel1.Controls.Add(btnHome);
            flowLayoutPanel1.Controls.Add(btnInicio);
            flowLayoutPanel1.Controls.Add(btnUser);
            flowLayoutPanel1.Controls.Add(btnShop);
            flowLayoutPanel1.Controls.Add(btnReport);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(150, 620);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top;
            btnHome.BackColor = Color.MidnightBlue;
            btnHome.BackgroundColor = Color.MidnightBlue;
            btnHome.BorderColor = Color.PaleVioletRed;
            btnHome.BorderRadius = 0;
            btnHome.BorderSize = 0;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(0, 0, 0, 10);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(150, 100);
            btnHome.TabIndex = 0;
            btnHome.TextColor = Color.White;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.MidnightBlue;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.White;
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnInicio.IconColor = Color.White;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnInicio.IconSize = 30;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 110);
            btnInicio.Margin = new Padding(0, 0, 0, 10);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(150, 50);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.MidnightBlue;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = Color.White;
            btnUser.IconChar = FontAwesome.Sharp.IconChar.User;
            btnUser.IconColor = Color.White;
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnUser.IconSize = 30;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 170);
            btnUser.Margin = new Padding(0, 0, 0, 10);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(150, 50);
            btnUser.TabIndex = 3;
            btnUser.Text = "Usuario";
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnShop
            // 
            btnShop.BackColor = Color.MidnightBlue;
            btnShop.FlatAppearance.BorderSize = 0;
            btnShop.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnShop.FlatStyle = FlatStyle.Flat;
            btnShop.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnShop.ForeColor = Color.White;
            btnShop.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btnShop.IconColor = Color.White;
            btnShop.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnShop.IconSize = 30;
            btnShop.ImageAlign = ContentAlignment.MiddleLeft;
            btnShop.Location = new Point(0, 230);
            btnShop.Margin = new Padding(0, 0, 0, 10);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(150, 50);
            btnShop.TabIndex = 4;
            btnShop.Text = "Tiendas";
            btnShop.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.MidnightBlue;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.White;
            btnReport.IconChar = FontAwesome.Sharp.IconChar.Bell;
            btnReport.IconColor = Color.White;
            btnReport.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnReport.IconSize = 30;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 290);
            btnReport.Margin = new Padding(0, 0, 0, 10);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(150, 50);
            btnReport.TabIndex = 5;
            btnReport.Text = "Reportes";
            btnReport.UseVisualStyleBackColor = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 80);
            ClientSize = new Size(1000, 650);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHome";
            Load += frmHome_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinus).EndInit();
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox btnMinus;
        private PictureBox btnExit;
        private Panel panel2;
        private Panel panel3;
        private CustomControls.RJControls.RJButton btnHome;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnShop;
        private FontAwesome.Sharp.IconButton btnReport;
    }
}