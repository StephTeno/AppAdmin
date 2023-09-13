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
            BarraLateral = new Panel();
            panel1 = new Panel();
            btnMinus = new PictureBox();
            btnExit = new PictureBox();
            rjButton1 = new CustomControls.RJControls.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // BarraLateral
            // 
            BarraLateral.BackColor = Color.RoyalBlue;
            BarraLateral.Location = new Point(0, 0);
            BarraLateral.Name = "BarraLateral";
            BarraLateral.Size = new Size(62, 650);
            BarraLateral.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnMinus);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(60, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 25);
            panel1.TabIndex = 1;
            // 
            // btnMinus
            // 
            btnMinus.Image = Properties.Resources.Minimizar;
            btnMinus.Location = new Point(891, 2);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(20, 20);
            btnMinus.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinus.TabIndex = 21;
            btnMinus.TabStop = false;
            btnMinus.Click += btnMinus_Click;
            btnMinus.MouseEnter += btnMinus_MouseEnter;
            btnMinus.MouseLeave += btnMinus_MouseLeave;
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.Close;
            btnExit.Location = new Point(917, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(20, 20);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 20;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.BackgroundColor = Color.MediumSlateBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(379, 206);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 2;
            rjButton1.Text = "rjButton1";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 80);
            ClientSize = new Size(1000, 650);
            Controls.Add(rjButton1);
            Controls.Add(panel1);
            Controls.Add(BarraLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            Text = "frmHome";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinus).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraLateral;
        private Panel panel1;
        private CustomControls.RJControls.RJButton rjButton1;
        private PictureBox btnMinus;
        private PictureBox btnExit;
    }
}