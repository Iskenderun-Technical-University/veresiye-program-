using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veresiye_defteri_v1._1
{
    public partial class Form_admin : Form
    {
        public Form_admin()
        {
            InitializeComponent();
        }

        private void button_user_Click(object sender, EventArgs e)
        {
            panel_screen.Controls.Clear();
            Form_user_process form_user_process = new Form_user_process();
            form_user_process.TopLevel = false;
            panel_screen.Controls.Add(form_user_process);
            form_user_process.Show();
            form_user_process.Dock = DockStyle.Fill;
        }

        private void Form_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
