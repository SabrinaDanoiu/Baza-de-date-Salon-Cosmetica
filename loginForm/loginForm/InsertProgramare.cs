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
    public partial class InsertProgramare : Form
    {
        public InsertProgramare()
        {
            InitializeComponent();
        }

        string Conn = ("Data Source=SABRINA;Initial Catalog=Salon_Cosmetica;Integrated Security=true");

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
                    SqlCommand cmd = new SqlCommand("INSERT INTO Programari (ID_Client,ID_Procedura,ID_Cosmetician,Data,Ora) VALUES (@ID_Client,@ID_Procedura,@ID_Cosmetician,@Data,@Ora)", con);
                    cmd.Parameters.Add("@ID_Client", textBox1.Text);
                    cmd.Parameters.Add("@ID_Procedura", textBox2.Text);
                    cmd.Parameters.Add("@Data", dateTimePicker1.Value.Date);
                    cmd.Parameters.Add("@Ora", textBox4.Text);
                    cmd.Parameters.Add("@ID_Cosmetician", textBox3.Text);

                    cmd.ExecuteNonQuery();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void InsertProgramare_Load(object sender, EventArgs e)
        {

        }
    }
}
