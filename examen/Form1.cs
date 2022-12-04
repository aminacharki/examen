using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace examen
{
    public partial class examen : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RG3QUVA\MSSQLSERVER01;Initial Catalog=exam;Integrated Security=True");
        public examen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cnx.Open();
            SqlCommand cmd = new SqlCommand("insert into exam (idexam, durée ,matière) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Examen bien enregistré ");
            cnx.Close();
        }

        private void question_Click(object sender, EventArgs e)
        {
            question QUES = new question();
            QUES.Show();
        }

        private void examen_Load(object sender, EventArgs e)
        {

        }
    }
}
