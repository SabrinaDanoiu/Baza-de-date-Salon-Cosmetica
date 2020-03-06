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
    public partial class InsertProcedura : Form
    {
        public InsertProcedura()
        {
            InitializeComponent();
        }

        string Conn = ("Data Source=SABRINA;Initial Catalog=Salon_Cosmetica;Integrated Security=true");

        private void InsertProcedura_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields!");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Conn);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Proceduri_2 (Nume_Procedura,Durata_Procedura,ID_Sala_Procedura) VALUES (@Nume_Procedura,@Durata_Procedura,@ID_Sala_Procedura)", con);
                    cmd.Parameters.Add("@Nume_Procedura", textBox1.Text);
                    cmd.Parameters.Add("@Durata_Procedura", textBox2.Text);
                    cmd.Parameters.Add("@ID_Sala_Procedura", textBox3.Text);

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
