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
using System.Data.Common;

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
                SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_kullan�c� where ID=@id and user_password=@password", connection);
                da.SelectCommand.Parameters.AddWithValue("id", textBox_user_code.Text);
                da.SelectCommand.Parameters.AddWithValue("password", textBox_user_password.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0) 
                {
                    admin_user.ID = dt.Rows[0]["ID"].ToString();
                    admin_user.user_password = dt.Rows[0]["user_password"].ToString();
                    admin_user.authority = dt.Rows[0]["authority"].ToString();
                    
                    if (admin_user.authority == "admin")
                    {                      
                        Form_admin form_admin = new Form_admin();
                        form_admin.Show();                        
                    }
                    if(admin_user.authority == "kullan�c�")
                    {
                        Form_user form_user = new Form_user();
                        form_user.Show();
                    }
                    this.Hide();
                }
                else
                {
                    textBox_user_code.Text = "";
                    textBox_user_password.Text = "";
                    MessageBox.Show("HATALI G�R��");
                }
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("HATALI G�R��");
                connection.Close();
            }
            
        }
    }
}