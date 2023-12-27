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
    public partial class Form1 : Form
    {
        public static string UserName = "";
        bool bClose = false;
        public Form1()
        {
            Form2 f = new Form2();
            f.ShowDialog();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbName.Text = UserName;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") return;
            ListViewItem item = new ListViewItem(txtName.Text);
            item.SubItems.Add(dtBirthday.Value.ToString("dd/MM/yyyy"));
            item.SubItems.Add(rdNam.Checked ? "Nam" : "Nữ");
            item.ImageIndex = (rdNam.Checked ? 0 : 1);
            listEmployee.Items.Add(item);
            txtName.Text = "";
            txtName.Focus();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listEmployee.SelectedItems)
                listEmployee.Items.Remove(item);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity <= 0)
            {
                bClose = true;
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bClose)
            {
                e.Cancel = true;
                timer1.Enabled = true;
               

            }

        }
    }
}
