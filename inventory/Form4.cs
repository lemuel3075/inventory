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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Xml.Linq;

namespace inventory
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private int ASpacing = 50;
        private int BSpacing = 50;
        private int CSpacing = 50;

        private int A = 250;
        private int B = 250;
        private int C = 250;
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNum1.Text = dgvStock[0, e.RowIndex].Value.ToString();
            tbitem.Text = dgvStock[1, e.RowIndex].Value.ToString();
            tbstock.Text = dgvStock[2, e.RowIndex].Value.ToString();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            User.Text = Form2.sendtext;

            string conn = "Data Source=DESKTOP-KTF1IK9\\SQLEXPRESS;Initial Catalog=inventoryDatabase;Integrated Security=True";
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(tbstock.Text);
            tbstock.Text = (num2 - num1).ToString() ;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KTF1IK9\\SQLEXPRESS;Initial Catalog=inventoryDatabase;Integrated Security=True");
            con.Open();
            string query = "UPDATE Item1 SET Item ='" + tbitem.Text + "', Stock ='" + tbstock.Text + "' where id=" + int.Parse(tbNum1.Text);
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("Updated!");
            dgvItems.Rows.Add(tbNum1.Text, tbitem.Text, tbstock.Text);
            clearfield();
            Form4_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var order = MessageBox.Show("Thank you ", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (order == DialogResult.OK)
            {
                printPreviewDialog1.Document = printDocument1;
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("My Name", 800, 1000);
                printPreviewDialog1.ShowDialog();
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();



            }
        }
            public void clearfield()
        {
            tbstock.Clear();
            tbNum1.Clear();
            tbitem.Clear();
        
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try

            {

               
                e.Graphics.DrawString("Stock-Reciept", new Font("Arial", 24, FontStyle.Italic), Brushes.Black, new Point(250, 10));
                e.Graphics.DrawString("Consolacion", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(170, 50));
                e.Graphics.DrawString("6014,Cebu City", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 85));

                e.Graphics.DrawString("#09568907756", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(285, 115));

                e.Graphics.DrawString("Satus", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(100, 185));
                e.Graphics.DrawString("Book Name", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 185));

                e.Graphics.DrawString("--------------------------------------------------", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(100, 200));


                e.Graphics.DrawString("-------------------------------------------------", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(100, 800));
                e.Graphics.DrawString("Location", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(100, 850));



                for (int i = 0; i <= dgvItems.RowCount - 1; i++)
                {

                    e.Graphics.DrawString(" " + Convert.ToString(dgvItems.Rows[i].Cells[0].Value), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(100, A));
                    e.Graphics.DrawString(" " + Convert.ToString(dgvItems.Rows[i].Cells[1].Value), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(400, B));


                    A += ASpacing;
                    B += BSpacing;
                    C += CSpacing;

                }







            }
            catch
            {
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
