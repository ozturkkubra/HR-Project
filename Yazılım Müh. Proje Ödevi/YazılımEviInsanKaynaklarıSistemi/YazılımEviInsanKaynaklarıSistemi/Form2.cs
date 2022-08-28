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

namespace YazılımEviInsanKaynaklarıSistemi
{
    public partial class Form2 : Form
    {
        PersonnelProvider pp = new PersonnelProvider();
        ProjectProvider p = new ProjectProvider();
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;


        void gridpersoneldoldur()
        {
            con = new SqlConnection("Server=localhost;Database=Test; Uid=sa; Pwd='12345';");
            da = new SqlDataAdapter("Select *From personel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personel");
            dataGridView4.DataSource = ds.Tables["personel"];
            con.Close();
        }
        void gridprojedoldur()
        {
            con = new SqlConnection("Server=localhost;Database=Test; Uid=sa; Pwd='12345';");
            da = new SqlDataAdapter("Select *From projeler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "projeler");
            dataGridView2.DataSource = ds.Tables["projeler"];
            con.Close();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            gridpersoneldoldur();
            gridprojedoldur();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://turmob.org.tr/hesaplamalar/KidemIhbarVeTazminati");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView4.SelectedRows)  //Seçili Satırları Silme
            {
                int TC = Convert.ToInt32(drow.Cells[0].Value);
                pp.deletePersonnel(TC);
            }
            gridpersoneldoldur();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows) 
            {
                int MınPer = Convert.ToInt32(drow.Cells[3].Value);
                p.deleteProject(MınPer);

            }
            gridprojedoldur();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
