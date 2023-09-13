using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.MongoDBs;
using MongoDB.Driver;

namespace Vista.HOME
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            MongoClient conexion = MongoDBs.GetConnection();
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
