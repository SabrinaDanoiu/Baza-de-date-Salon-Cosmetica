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
    public partial class DeletePick : Form
    {
        public DeletePick()
        {
            InitializeComponent();
        }

        DeleteClient ob1 = new DeleteClient();
        DeleteCosmetician ob2 = new DeleteCosmetician();

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Hide();
            ob1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ob2.Show();
        }
    }
}
