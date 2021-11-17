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
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tESTDataSet.addbook' table. You can move, or remove it, as needed.
            this.addbookTableAdapter.Fill(this.tESTDataSet.addbook);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                addbookBindingSource.EndEdit();

            }
            catch (Exception)
            {

                MessageBox.Show("Please fill in mandatory fields");
            }
            addbookTableAdapter.Update(tESTDataSet.addbook);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addbookBindingSource.AddNew();
          
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            addbookBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Myaccount home = new Myaccount();
            home.Show();
        }
    }
}
