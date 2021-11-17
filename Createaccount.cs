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
using System.Configuration;

namespace DatabasteknikBookStore
{

    public partial class Createaccount : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Createaccount()
        {
            InitializeComponent();
        }
        private void Createaccount_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=desktop-1vtnq7j;Initial Catalog=TEST;Integrated Security=True");
            cn.Open();
        }
        private void LoginBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Access login = new Access();
            login.Show();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty || textBox3.Text != string.Empty || textBox2.Text != string.Empty)
            {
                if (textBox3.Text == textBox4.Text)
                {
                    cmd = new SqlCommand("select * from login1 where username='" + textBox2.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username already exists, please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into login1 values(@username,@password, @confirmpassword)", cn);
                        cmd.Parameters.AddWithValue("username", textBox2.Text);
                        cmd.Parameters.AddWithValue("password", textBox3.Text);
                        cmd.Parameters.AddWithValue("confirmpassword", textBox4.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            Access login = new Access();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Access login = new Access();
            login.Show();
        }
    }
}
