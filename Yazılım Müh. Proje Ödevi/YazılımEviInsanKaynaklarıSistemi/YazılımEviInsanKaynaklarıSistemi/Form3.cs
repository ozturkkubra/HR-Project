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
    public partial class Form3 : Form
    {
        ProjectProvider p = new ProjectProvider();
        public Form3()
        {
            InitializeComponent();
        }
        static string conString = "Server=localhost;Database=Test; Uid=sa; Pwd='12345';";
        SqlConnection baglanti = new SqlConnection(conString);

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.Empty;
            errorProvider1.SetError(textBox5, "");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Empty;
            errorProvider1.SetError(textBox3, "");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox5.Text == "")
            {
                errorProvider1.SetError(textBox3, "Please enter sector.");
                errorProvider1.SetError(textBox5, "Please enter company.");
                textBox3.BackColor = Color.Red;
                textBox5.BackColor = Color.Red;
                MessageBox.Show("Please enter sector and company.");

            }
            else
            {
                Project yeniproje = new Project();
                yeniproje.Name = textBox4.Text;
                yeniproje.Sector = textBox3.Text;
                yeniproje.MinPer = Convert.ToInt32(textBox1.Text);
                yeniproje.MaxPer = Convert.ToInt32(textBox2.Text);
                yeniproje.MngrNo = Convert.ToInt32(domainUpDown1.Text);
                yeniproje.AnlystNo = Convert.ToInt32(domainUpDown2.Text);
                yeniproje.DsgnrNo = Convert.ToInt32(domainUpDown3.Text);
                yeniproje.DvlprNo = Convert.ToInt32(domainUpDown4.Text);
                yeniproje.TstrNo = Convert.ToInt32(domainUpDown5.Text);

                p.addProject(yeniproje);

                MessageBox.Show("Project created.");
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
