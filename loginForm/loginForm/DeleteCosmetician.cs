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
    public partial class DeleteCosmetician : Form
    {
        public DeleteCosmetician()
        {
            InitializeComponent();
        }

        SqlConnection _con;
        SqlCommand _cmd;
        string Conn = ("Data Source=SABRINA;Initial Catalog=Salon_Cosmetica;Integrated Security=true;Pooling=False");

        private void button1_Click(object sender, EventArgs e)
        {
            _con = new SqlConnection(Conn);
            _con.Open();
            _cmd = new SqlCommand("DELETE FROM Cosmeticieni WHERE ID_Cosmetician=@a1", _con);
            _cmd.Parameters.Add("a1", Convert.ToInt32(textBox1.Text));

            _cmd.ExecuteNonQuery();
        }
    }
}
