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
    public partial class Interogare1 : Form
    {
        public Interogare1()
        {
            InitializeComponent();
        }
        string Conn = ("Data Source=SABRINA;Initial Catalog=Salon_Cosmetica;Integrated Security=true");
        SqlDataAdapter adp;
        DataSet ds;
        DataTable dt;
        DataRow dr;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Conn);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            adp.SelectCommand = new SqlCommand("SELECT C.Nume,C.Prenume FROM Clienti C, Cosmeticieni CD WHERE ID_Client < @a1 AND C.Nume = CD.Nume", con);
            adp.SelectCommand.Parameters.AddWithValue("@a1", textBox1.Text);
            adp.Fill(ds, "Clienti cautati");
            dt = ds.Tables["Clienti cautati"];
            dr = dt.Rows[0];

            dg.DataSource = ds.Tables["Clienti cautati"];

        }
    }
}
