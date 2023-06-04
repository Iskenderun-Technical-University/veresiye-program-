using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veresiye_defteri_v1._1
{
    public partial class Form_user : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ILININPC;Initial Catalog=veresiye_defteri;Integrated Security=True");

        public Form_user()
        {
            InitializeComponent();
        }

        private void Form_user_Load(object sender, EventArgs e)
        {
            musteriTablo();
        }

        public void musteriTablo()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_musteri", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_musteri.DataSource = dt;
            connection.Close();

        }
        public void processTablo()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_process", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_process.DataSource = dt;
            connection.Close();
        }

        private void Form_user_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_musteri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_process where musteri_ıd='" + dataGridView_musteri.CurrentRow.Cells[0].Value.ToString() + "'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_process.DataSource = dt;
        }

        private void button_process_add_Click(object sender, EventArgs e)
        {
            Form_add_process.musteri = dataGridView_musteri.CurrentRow.Cells[0].Value.ToString();

            Form_add_process form_add_process = new Form_add_process();
            form_add_process.ShowDialog();


        }

        private void button_f5_Click(object sender, EventArgs e)
        {
            processTablo();
        }

        private void textBox_searh_TextChanged(object sender, EventArgs e)
        {            
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_musteri where musteri_ad like '" + textBox_searh.Text + "%'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_musteri.DataSource = dt;
            connection.Close();
        }

        private void button_process_del_Click(object sender, EventArgs e)
        {
            
            
            if (textBox_process_del.Text == "")
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("delete from tbl_process where process_ıd='" + int.Parse(dataGridView_process.CurrentRow.Cells[0].Value.ToString()) + "'", connection);
                komut.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("BORÇ SİLİNDİ");
                musteriTablo();
                processTablo();
            }
            else
            {
                string borc = dataGridView_process.CurrentRow.Cells[3].Value.ToString();
                int int_borc = Convert.ToInt32(borc);
                int odenen_borc = Convert.ToInt32(textBox_process_del.Text);
                connection.Open();
                SqlCommand komut = new SqlCommand("update tbl_process set debt = @debt where process_ıd = @process_ıd",connection);
                komut.Parameters.AddWithValue("@debt", int_borc - odenen_borc);
                komut.Parameters.AddWithValue("@process_ıd", dataGridView_process.CurrentRow.Cells[0].Value);
                komut.ExecuteNonQuery();              
                connection.Close();
                processTablo();
                textBox_process_del.Text = "";

            }
        }
    }
}
