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
using System.Data.SqlTypes;

namespace veresiye_defteri_v1._1
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ILININPC;Initial Catalog=veresiye_defteri;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        int user_code;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "Select * From tbl_kullanýcý where ID=@id and user_password=@password";
                SqlParameter prm_id = new SqlParameter("id", textBox_user_code.Text);
                SqlParameter prm_password = new SqlParameter("password", textBox_user_password.Text);
                SqlCommand komut = new SqlCommand(sql, connection);
                komut.Parameters.Add(prm_id);
                komut.Parameters.Add(prm_password);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if(dt.Rows.Count > 0) 
                {
                    if(textBox_user_code.Text == "1001" )
                    {
                        Form_admin form_admin = new Form_admin();
                        form_admin.Show();
                        
                    }
                    else 
                    {
                        user_code = Convert.ToInt32(textBox_user_code);
                        Form_user form_user = new Form_user();
                        form_user.Show();
                    }                  
                }
                this.Hide();
                
            }
            catch (Exception)
            {
                MessageBox.Show("HATALI GÝRÝÞ");
                connection.Close();
            }
            
        }
    }
}