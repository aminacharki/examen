using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    
    public partial class qcm : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RG3QUVA\MSSQLSERVER01;Initial Catalog=exam;Integrated Security=True");
        public qcm()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand(" insert into Qcm (numquestion,proposistion1,proposistion2) values" +
                "('" + textBox1.Text + "','" + textBox2.Text + "','"+textBox3.Text+"')", cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Qcm bien enregistré ");
            cnx.Close();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("update Qcm (numquestion, proposition1,proposition2) where numquestion ('" + textBox1.Text + "')", cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Qcm bien modifier ");
            cnx.Close();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("delete from Qcm (numquestion, proposition1,proposition2) where numquestion ('" + textBox1.Text + "')", cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Qcm  bien supprimé ");
             cnx.Close();

        }
    }
}
