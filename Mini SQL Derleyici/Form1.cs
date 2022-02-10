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

namespace Mini_SQL_Derleyici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-FG36IKJ\SQLEXPRESS;Initial Catalog=NotKayitSistemi;Integrated Security=True"); private void button1_Click(object sender, EventArgs e)

        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            string sorgu = richTextBox1.Text;
            try
            {
               
                baglantı.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TBLDERSLER", baglantı);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Sorgunuzu Kontrol Edin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
       
            try
            {
                string sorgu = richTextBox1.Text;
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglantı);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu Kontrol Edin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

