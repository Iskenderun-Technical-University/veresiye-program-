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
    public partial class Form_add_process : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ILININPC;Initial Catalog=veresiye_defteri;Integrated Security=True");

        static public string musteri;
        public Form_add_process()
        {
            InitializeComponent();
        }

        private void button_process_save_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_process(musteri_ıd,explanation,debt)values(@musteri_ıd,@explanation,@debt)", connection);
            komut.Parameters.AddWithValue("@musteri_ıd", musteri);
            komut.Parameters.AddWithValue("@explanation", richTextBox_explanation.Text);
            komut.Parameters.AddWithValue("@debt", textBox_fiyat.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("BAŞARI İLE KAYDEDİLMİŞTİR");
            this.Close();
            connection.Close();
        }
    }
}
