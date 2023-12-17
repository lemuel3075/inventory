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
using System.Data.SqlClient;
namespace inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      


        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DVFATBU\\SQLEXPRESS;Initial Catalog=MyDb;Integrated Security=True");
            con.Open();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string conn = "Data Source=DESKTOP-KTF1IK9\\SQLEXPRESS;Initial Catalog=inventoryDatabase;Integrated Security=True";
                string user = tbuser.Text;
                string pass = tbpass.Text;
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "INSERT INTO teacher (ID,pass) VALUES ('" + user + "','" + pass + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved");
          

            
            

        }

        public void clearfield()
        {
            tbuser.Clear();
            tbpass.Clear();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbs_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
        }

        
    }
}
