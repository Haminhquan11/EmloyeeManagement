using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlNhanVien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text != "admin")
                Application.Exit();
            Form1.UserName = txtUserName.Text;
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form1.UserName == "")
                Application.Exit();
        }
    }
}
