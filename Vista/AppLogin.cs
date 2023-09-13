using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.HOME;

namespace Vista
{
    public partial class frmAppLogin : Form
    {
        public frmAppLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Mejorar esta validación bien
            if (txtUser.Texts != "StephTeno19" || txtPassword.Texts != "NieTeno")
                lblErrorLogin.Visible = true;
            else
            {
                frmHome home = new frmHome();
                home.Show();
                this.Hide();
            }
        }

        private void txtPassword__TextChanged(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;
        }

        private void txtUser__TextChanged(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtPassword.Focus();
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnLogin_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.RoyalBlue;
        }

        private void btnMinus_MouseEnter(object sender, EventArgs e)
        {
            btnMinus.BackColor = Color.RoyalBlue;
        }

        private void btnMinus_MouseLeave(object sender, EventArgs e)
        {
            btnMinus.BackColor = Color.MidnightBlue;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.MidnightBlue;
        }
    }
}
