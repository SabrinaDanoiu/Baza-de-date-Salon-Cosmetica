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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Conn = ("Data Source=SABRINA;Initial Catalog=Salon_Cosmetica;Integrated Security=true");
        Form2 ob = new Form2();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUame.Text == "" && txtPass.Text == "")
                {
                    MessageBox.Show("Please enter your Username and Password");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Conn);
                    SqlCommand cmd = new SqlCommand("select * from Login where Username=@UserName and Password=@UserPass",con);
                    cmd.Parameters.AddWithValue("@UserName", txtUame.Text);
                    cmd.Parameters.AddWithValue("@UserPass", txtPass.Text);

                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    con.Close();

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        MessageBox.Show("Succesfully Login.");
                        this.Hide();
                        ob.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUame_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
