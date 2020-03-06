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
    public partial class InsertClient : Form
    {
        public InsertClient()
        {
            InitializeComponent();
        }

        string Conn = ("Data Source=SABRINA;Initial Catalog=Salon_Cosmetica;Integrated Security=true");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InsertClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields!");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Conn);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Clienti (Nume,Prenume,Email,Nr_telefon) VALUES (@Nume,@Prenume,@Email,@Nr_telefon)", con);
                    cmd.Parameters.Add("@Nume", textBox1.Text);
                    cmd.Parameters.Add("@Prenume", textBox2.Text);
                    cmd.Parameters.Add("@Email", textBox3.Text);
                    cmd.Parameters.Add("@Nr_telefon", textBox4.Text);

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
