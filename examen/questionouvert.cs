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

namespace examen
{
    public partial class questionouvert : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RG3QUVA\MSSQLSERVER01;Initial Catalog=exam;Integrated Security=True");
        public questionouvert()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand(" insert into Questionouvert(numquestion,proposistion) values" +
                "('" + textBox1.Text + "','" + textBox2.Text + "')", cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Questionouvert  bien enregistré ");
            cnx.Close();
        }

        private void modifier_Click(object sender, EventArgs e)
        {

            cnx.Open();
            SqlCommand cmd = new SqlCommand("update Questionouvert (numquestion, proposition) where numquestion ('" + textBox1.Text + "')", cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("questionouvert bien modifier ");
            cnx.Close();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("delete from questiondirect (numquestion, proposition) where numquestion ('" + textBox1.Text + "')", cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("questionouvert bien supprimé ");
            cnx.Close();
        }
    }
}
