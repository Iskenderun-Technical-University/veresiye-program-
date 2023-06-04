using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace veresiye_defteri_v1._1
{
    public partial class Form_user_process : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ILININPC;Initial Catalog=veresiye_defteri;Integrated Security=True");

        public void data_viev(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter(data, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_users.DataSource = ds.Tables[0];
        }
        public Form_user_process()
        {
            InitializeComponent();
        }

        private void button_user_add_Click(object sender, EventArgs e)
        {
            Form_user_add form_user_add = new Form_user_add();
            form_user_add.ShowDialog();
        }

        private void Form_user_process_Load(object sender, EventArgs e)
        {
            data_viev("Select * from tbl_kullanıcı");
        }

        private void Form_user_process_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listView_users_DoubleClick(object sender, EventArgs e)
        {


        }

        private void button_user_save_Click(object sender, EventArgs e)
        {

        }

        private void button_f5_Click(object sender, EventArgs e)
        {
            data_viev("Select * from tbl_kullanıcı");
        }

        private void button_user_del_Click(object sender, EventArgs e)
        {
            DialogResult yesno;
            yesno = MessageBox.Show("KULLANICI SİLİNSİN Mİ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (yesno == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("delete from tbl_kullanıcı where ID='" + int.Parse(dataGridView_users.CurrentRow.Cells[0].Value.ToString()) + "'", connection);
                komut.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("KULLANICI SİLİNDİ");
                data_viev("Select * from tbl_kullanıcı");
            }
        }

        private void dataGridView_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_users_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_user_code.Text = dataGridView_users.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_users.CurrentRow.Cells[2].Value.ToString();
            textBox_password.Text = dataGridView_users.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
