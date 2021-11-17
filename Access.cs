using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabasteknikBookStore
{
    public partial class Access : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        SqlDataAdapter adpt;
        
        public Access()
        {
            InitializeComponent();
        }
        private void Access_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=desktop-1vtnq7j;Initial Catalog=TEST;Integrated Security=True");
            cn.Open();
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Createaccount signup = new Createaccount();
            signup.Show();
        }

        private void LoginBtn2_Click(object sender, EventArgs e)
        {

            if (passwordTxt.Text != string.Empty || usernameTxt.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from login1 where username='" + usernameTxt.Text + "' and password='" + passwordTxt.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Welcome to BookStore!");
                    
                    this.Hide();
                    Form1 home = new Form1();
                    home.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username or password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Myaccount home = new Myaccount();
            home.Show();
        }
    }
}
