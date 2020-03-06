using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm
{
    public partial class InsertPick : Form
    {
        public InsertPick()
        {
            InitializeComponent();
        }

        InsertClient ob1 = new InsertClient();
        InsertSalaProceduri ob2 = new InsertSalaProceduri(); 
        InsertProcedura ob3 = new InsertProcedura();
        InsertCosmetician ob4 = new InsertCosmetician();
        InsertProgramare ob5 = new InsertProgramare();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //SALA PROCEDURA
        {
           // this.Hide();
            ob2.Show();
        }


        private void button3_Click(object sender, EventArgs e)  //CLIENT
        {
            //this.Hide();
            ob1.Show();
        }

        private void button4_Click(object sender, EventArgs e) //COSMETICIAN
        {
            //this.Hide();
            ob4.Show();
        }

        private void button2_Click(object sender, EventArgs e)  //PROCEDURA
        {
            //this.Hide();
            ob3.Show();
        }

        private void button5_Click(object sender, EventArgs e) //PROGRAMARE
        {
           // this.Hide();
            ob5.Show();
        }

        private void InsertPick_Load(object sender, EventArgs e)
        {

        }
    }
}
