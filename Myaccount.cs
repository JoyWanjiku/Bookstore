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

namespace DatabasteknikBookStore
{
    public partial class Myaccount : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=desktop-1vtnq7j;Initial Catalog=TEST;Integrated Security=True");        
        DataTable dt;
        SqlDataAdapter adpt;

        public Myaccount()
        {
            InitializeComponent();
            DisplayValue();
        }
        public void DisplayValue()
        {
            cn.Open();
            adpt = new SqlDataAdapter("select title,genre,price,phonenumber from addbook", cn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SearchData(textBox1.Text);
        }
        public void SearchData (string search)
        {
            string query = "select * from addbook where title like '%" + search + "%' or genre like '%" + search + "%' ";
            adpt = new SqlDataAdapter(query, cn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Access login = new Access();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Createaccount signup = new Createaccount();
            signup.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
