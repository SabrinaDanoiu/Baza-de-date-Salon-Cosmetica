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
    public partial class InterogatePick : Form
    {
        public InterogatePick()
        {
            InitializeComponent();
        }

        string Conn = ("Data Source=SABRINA;Initial Catalog=Salon_Cosmetica;Integrated Security=true");
        SqlDataAdapter adp;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        SqlConnection con;
        //Interogare1 ob1 = new Interogare1();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ob1.Show();
            SqlConnection con = new SqlConnection(Conn);
            SqlCommand INT1 = new SqlCommand("SELECT C.Nume,C.Prenume,COUNT(p.ID_Programare) AS Nr_Programari FROM Clienti C, Programari p WHERE C.Nr_telefon = @a1 GROUP BY C.ID_Client,p.ID_Client,C.Nume,C.Prenume HAVING C.ID_Client = p.ID_Client", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT1;
            adp.SelectCommand.Parameters.AddWithValue("@a1", textBox1.Text);
            adp.Fill(ds, "Clienti cautati");
            dt = ds.Tables["Clienti cautati"];
            //dr = dt.Rows[0];

            dg.DataSource = ds.Tables["Clienti cautati"];
            con.Close();
        }

        private void InterogatePick_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
                 con = new SqlConnection(Conn);
                 SqlCommand INT2 = new SqlCommand("SELECT C.Nume,C.Prenume,COUNT(p.ID_Programare) AS Nr_Programari FROM Cosmeticieni C, Programari p WHERE C.Nume = @a1 GROUP BY C.ID_Cosmetician,p.ID_Cosmetician,C.Nume,C.Prenume HAVING C.ID_Cosmetician = p.ID_Cosmetician", con);
                adp = new SqlDataAdapter();
                ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT2;
            adp.SelectCommand.Parameters.AddWithValue("@a1", textBox2.Text);
            adp.Fill(ds, "Cosmeticieni cautati");
            dt = ds.Tables["Cosmeticieni cautati"];

            dg.DataSource = ds.Tables["Cosmeticieni cautati"];
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT3 = new SqlCommand("SELECT C.Nume,C.Prenume,p.ID_Programare,Pl.Nume_Procedura AS Nume_Procedura FROM Cosmeticieni C, Programari p, Proceduri_2 Pl WHERE C.Prenume = @a1 GROUP BY C.ID_Cosmetician,p.ID_Cosmetician,C.Nume,C.Prenume,Pl.ID_Procedura,p.ID_Procedura,p.ID_Programare,Pl.Nume_Procedura HAVING C.ID_Cosmetician = p.ID_Cosmetician AND Pl.ID_Procedura = p.ID_Procedura", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT3;
            adp.SelectCommand.Parameters.AddWithValue("@a1", textBox3.Text);
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT distinct c.Nume,c.Prenume,p.ID_Procedura,p.Nume_Procedura FROM Cosmeticieni c, Proceduri_2 p, Programari pr WHERE c.Nivel_experienta = @a1 GROUP BY  c.Nume,c.Prenume,pr.ID_Procedura,p.ID_Procedura,p.Nume_Procedura,pr.ID_Cosmetician,c.ID_Cosmetician HAVING p.ID_Procedura = pr.ID_Procedura AND c.ID_Cosmetician=pr.ID_Cosmetician", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.SelectCommand.Parameters.AddWithValue("@a1", comboBox1.Text);
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT c.Nume,c.Prenume,p.ID_Programare,p.Data,p.Ora FROM Clienti c, Programari p WHERE c.Nume = @a1 GROUP BY  c.ID_Client,c.Nume,c.Prenume,p.ID_Programare,p.Data,p.Ora,p.ID_Client HAVING c.ID_Client = p.ID_Client", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.SelectCommand.Parameters.AddWithValue("@a1", textBox5.Text);
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT c.ID_Cosmetician,c.Nume,c.Prenume FROM Cosmeticieni c, Programari p WHERE c.ID_Cosmetician = p.ID_Cosmetician GROUP BY  c.ID_Cosmetician,c.Nume,c.Prenume,p.ID_Cosmetician HAVING count(p.ID_Programare) = @a1", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.SelectCommand.Parameters.AddWithValue("@a1", textBox6.Text);
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT S.ID_Sala_Procedura AS Nr_Sala,S.Nr_Statii_de_lucru FROM Sali_Proceduri S WHERE S.ID_Sala_Procedura IN (SELECT P.ID_Sala_Procedura FROM Proceduri_2 P GROUP BY P.ID_Sala_Procedura HAVING COUNT(P.ID_Procedura) >= @a1)", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.SelectCommand.Parameters.AddWithValue("@a1", textBox4.Text);
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT p.Data,p.Ora,pr.Nume_Procedura,pr.Durata_Procedura FROM Programari p,Proceduri_2 pr WHERE p.ID_Procedura=pr.ID_Procedura AND p.ID_Cosmetician IN (SELECT c.ID_Cosmetician FROM Cosmeticieni c WHERE c.Nume = @a1)", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.SelectCommand.Parameters.AddWithValue("@a1", textBox7.Text);
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT c.Nume,c.Prenume FROM Programari p,Clienti c WHERE p.ID_Client=c.ID_Client AND p.ID_Cosmetician IN (SELECT cs.ID_Cosmetician FROM Cosmeticieni cs WHERE year(cs.Data_Nasterii) = @a1)", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.SelectCommand.Parameters.AddWithValue("@a1", textBox8.Text);
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT distinct c.Nume,c.Prenume FROM Programari p,Clienti c WHERE p.ID_Client=c.ID_Client AND p.ID_Cosmetician IN (SELECT cs.ID_Cosmetician FROM Cosmeticieni cs WHERE cs.Nivel_experienta = @a1)", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.SelectCommand.Parameters.AddWithValue("@a1", comboBox2.Text);
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT * FROM Clienti", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg1.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT * FROM Cosmeticieni", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg1.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT * FROM Programari", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg1.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT * FROM Proceduri_2", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg1.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Conn);
            SqlCommand INT4 = new SqlCommand("SELECT * FROM Sali_Proceduri", con);
            adp = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            adp.SelectCommand = INT4;
            adp.Fill(ds, "Cosmeticieni2");
            dt = ds.Tables["Cosmeticieni2"];

            dg1.DataSource = ds.Tables["Cosmeticieni2"];
            con.Close();
        }



        //INTEROGARE2: Afiseaza numarul de Proceduri facute de fiecare cosmetician. 
        //adp.SelectCommand = new SqlCommand("SELECT C.Nume, C.Prenume, Count(D.ID_Procedura) AS Nr_Proceduri FROM Cosmeticieni C, Leg_Cosm_Proced D WHERE C.ID_Cosmetician = D.ID_Cosmetician", con);

        //INTEROGARE3: Afiseaza toti Clientii care au avut urmatorul numar de programari: 
        //adp.SelectCommand = new SqlCommand("SELECT C.ID_Client,C.Nume,C.Prenume, Count(p.ID_Programare) AS NR_Programari From Clienti C, Programari p WHERE p.ID_Client = C.ID_Client GROUP BY C.ID_Client HAVING Count(p.ID_Programare) = @a1 ", con);

        //INTEROGARE4: Afiseaza de cate ori a fost folosita fiecare sala de la '1-12-2017'
        //adp.SelectCommand = new SqlCommand("SELECT sp.ID_Sala_Proceduri, Count(p.ID_Programare) From Sali_Proceduri sp, Programare p, Proceduri_2 pd WHERE sp.ID_Sala_Proceduri = pd.ID_Sala_Proceduri AND pd.ID_Procedura = p.ID_Procedura GROUP BY sp.ID_Sala_Proceduri HAVING p.Data >= '1-12-2017' ", con);

        //INTEROGARE5: Afiseaza cosmeticienii care au nivelul de experienta "Avansat",care sunt nascuti in anul 1990 sau dupa si care au avut peste 2 programari in trecut.
        //adp.SelectCommand = new SqlCommand("SELECT c.ID_Cosmetician, C.Nume, C.Prenume FROM Cosmeticieni c, Programari p WHERE c.ID_Cosmetician = p.ID_Cosmetician AND c.Nivel_experienta = "Avansat" AND year(c.Data_Nasterii)>=1990 GROUP BY c.ID_Cosmetician HAVING Count(p.ID_Programare) >2 ", con);

        //INTEROGARE6:  Afiseaza numele clientilor care au avut/au programari la ora 16:00;
        //adp.SelectCommand = new SqlCommand("SELECT c.Nume, c.Prenume FROM CLienti c, Programari p WHERE c.ID_Client = p.ID_Client AND p.Ora = '16:00', con);

        // iNTEROGARE7: Afiseaza id-ul salilor in care se executa cel putin 2 proceduri. 
        // adp.SelectCommand = new SqlCommand("SELECT S.ID_Sala_Proceduri FROM Sali_Proceduri S WHERE S.ID_Sala_Proceduri = (SELECT P.ID_Sala_Proceduri FROM Proceduri_2 P GROUP BY P.ID_Sala_Proceduri HAVING COUNT(P.ID_Procedura) >= 2)", con);

        // INTEROGARE8:   Afiseaza ID-ul programarilor pentru procedurile ce se executa in prima sala de proceduri.
        // adp.SelectCommand = new SqlCommand("SELECT p.ID_Programare FROM Programari p, Proceduri_2 pr WHERE p.ID_Procedura = pr.ID_Procedura AND pr.ID_Sala_Procedura = (SELECT sp.ID_Sala_Procedura FROM Sali_Proceduri sp WHERE sp.Nr_Statii_de_lucru", con);    
    }
}
