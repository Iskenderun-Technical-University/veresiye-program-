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
    public partial class Form_user_add : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ILININPC;Initial Catalog=veresiye_defteri;Integrated Security=True");

        public Form_user_add()
        {
            InitializeComponent();
        }

        private void button_user_add_Click(object sender, EventArgs e)
        {
            if (textBox_password.Text == textBox_again_password.Text)
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_kullanıcı(name,user_password)values(@name,@password)", connection);
                komut.Parameters.AddWithValue("@name", textBox_name.Text);
                komut.Parameters.AddWithValue("@password", textBox_password.Text);
                komut.ExecuteNonQuery();
                textBox_name.Clear();
                textBox_password.Clear();
                textBox_again_password.Clear();
                MessageBox.Show("BAŞARI İLE KAYDEDİLMİŞTİR");
                connection.Close();
            }
            else
                MessageBox.Show("GİRİLEN ŞİFRELER EŞLEŞMİYOR");
        }
        
    }
}
