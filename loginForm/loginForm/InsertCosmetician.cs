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
    public partial class InsertCosmetician : Form
    {
        public InsertCosmetician()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        string Conn = ("Data Source=SABRINA;Initial Catalog=Salon_Cosmetica;Integrated Security=true");

        private void InsertCosmetician_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields!");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Conn);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Cosmeticieni (Nume,Prenume,Data_Nasterii,cnp,Sex,Nr_telefon,Email,Adresa,Nivel_experienta) VALUES (@Nume,@Prenume,@Data_Nasterii,@cnp,@Sex,@Nr_telefon,@Email,@Adresa,@Nivel_experienta)", con);
                    cmd.Parameters.Add("@Nume", textBox1.Text);
                    cmd.Parameters.Add("@Prenume", textBox2.Text);
                    cmd.Parameters.Add("@Data_Nasterii", dateTimePicker1.Value.Date);
                    cmd.Parameters.Add("@cnp", textBox4.Text);
                    cmd.Parameters.Add("@Sex", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.Add("@Nr_telefon", textBox6.Text);
                    cmd.Parameters.Add("@Email", textBox7.Text);
                    cmd.Parameters.Add("@Adresa", textBox8.Text);
                    cmd.Parameters.Add("@Nivel_experienta", comboBox2.SelectedItem.ToString());

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
