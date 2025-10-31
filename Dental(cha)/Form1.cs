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

namespace Dental_cha_
{
    public partial class Form1 : Form
    {

        public string ConnectionString = "Data Source=LAPTOP-JU8PB4S6\\SQLEXPRESS;Initial Catalog=dental_clinic;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand comm = new SqlCommand("SELECT * FROM tbl_Profile where username = @username and Password = @password and Role = @Role", conn);
            comm.Parameters.AddWithValue("@UserName", textBox1.Text);
            comm.Parameters.AddWithValue("@Password", textBox2.Text);
            comm.Parameters.AddWithValue("@Role", textBox3.Text);

            SqlDataReader reader = comm.ExecuteReader();

            if (reader.Read())
            {
                string username = reader["UserName"].ToString();
                string password = reader["Password"].ToString();
                string role = reader["Role"].ToString();

                if (textBox1.Text == username && textBox2.Text == password)
                {
                    MessageBox.Show("login Success");
                    Home Home = new Home();
                    Home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
