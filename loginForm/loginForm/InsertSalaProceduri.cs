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

namespace loginForm
{
    public partial class InsertSalaProceduri : Form
    {
        public InsertSalaProceduri()
        {
            InitializeComponent();
        }

        string Conn = ("Data Source=SABRINA;Initial Catalog=Salon_Cosmetica;Integrated Security=true");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields!");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Conn);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Sali_Proceduri (Nr_Statii_de_lucru) VALUES (@Nr_Statii_de_lucru)", con);
                    cmd.Parameters.Add("@Nr_Statii_de_lucru", textBox1.Text);

                    cmd.ExecuteNonQuery();
                }
 
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
