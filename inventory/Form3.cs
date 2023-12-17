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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventory
{
    public partial class Form3 : Form
    {
     
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
                                                                                                                                                                                                                                                                                                                                                                                                                
            string conn = "Data Source=DESKTOP-DVFATBU\\SQLEXPRESS;Initial Catalog=Datab;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = "Select * From Item1";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            dgvStock.DataSource = table;
            con.Close();
        }
      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DVFATBU\\SQLEXPRESS;Initial Catalog=Datab;Integrated Security=True");
            con.Open();
           string query = "UPDATE Item1 SET Item ='"+tbitem.Text+"', Stock ='"+tbstock.Text+"' where id="+int.Parse(tbNum1.Text);
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated!");
            clear();
            Form3_Load(sender, e);
        }
        public void clear()
        {
            tbNum1.Clear();
            tbstock.Clear();
            tbitem.Clear();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbitem.Text != "" || tbNum1.Text != "" || tbstock.Text != "")
            {
                string id = tbNum1.Text;
                string item = tbitem.Text;
                int stock = Convert.ToInt32(tbstock.Text);
                string conn = "Data Source=DESKTOP-DVFATBU\\SQLEXPRESS;Initial Catalog=Datab;Integrated Security=True";
                SqlConnection con = new SqlConnection(conn);
                con.Open();

                string query = "INSERT INTO Item1 (id,Item,Stock) VALUES ('" + id + "','" + item + "','" + stock + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");
                clear();
                Form3_Load(sender, e);
            }
            else 
            {

                MessageBox.Show("Please Fill the Information");

            }

        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNum1.Text = dgvStock[0, e.RowIndex].Value.ToString();
            tbitem.Text = dgvStock[1, e.RowIndex].Value.ToString();
            tbstock.Text = dgvStock[2, e.RowIndex].Value.ToString();
         
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbstock.Clear();
            tbitem.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = tbNum1.Text;
            string item = tbitem.Text;
            int stock = Convert.ToInt32(tbstock.Text);
            string conn = "Data Source=DESKTOP-KTF1IK9\\SQLEXPRESS;Initial Catalog=inventoryDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            string query = "Delete from Item1 where id = " + id +" ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted!");
            clear();
            Form3_Load(sender, e);
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbitem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
