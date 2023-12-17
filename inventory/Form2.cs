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


namespace inventory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string sendtext = "";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbuser.Text != "Lemuel" && tbpass.Text != "Salazar")
            {
                string user = tbuser.Text;
                string pass = tbpass.Text;
                string conn = "Data Source=DESKTOP-KTF1IK9\\SQLEXPRESS;Initial Catalog=inventoryDatabase;Integrated Security=True";
                SqlConnection con = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand("Select * From teacher Where ID = @user and pass = @pass", con);
                cmd.Parameters.AddWithValue("@User", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome To my System" +tbuser.Text );
                    sendtext = tbuser.Text; 
                    Form4 f4 = new Form4();
                    f4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Account!");
                    clearfield();


                }
                con.Open();
            }
           else if (tbuser.Text == "Lemuel" && tbpass.Text == "Salazar")
            {
                MessageBox.Show("Welcome Mrs." + tbuser.Text);
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();

            }

            else
            {

                MessageBox.Show("Incorrect Account!");

            }

        }

        public void clearfield()
        {
            tbuser.Clear();
            tbpass.Clear();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
              Application.Exit();
           }
        }
        
    }
}
