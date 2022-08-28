using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace YazılımEviInsanKaynaklarıSistemi
{
    public partial class Form5 : Form
    {
        PersonnelProvider pp = new PersonnelProvider();
        public Form5()
        {
            InitializeComponent();
        }
        //Bu veritabanına bağlanmak için gerekli olan bağlantı 
        static string conString = "Server=localhost;Database=Test; Uid=sa; Pwd='12345';";
        SqlConnection baglanti = new SqlConnection(conString);
        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("developer");
            comboBox2.Items.Add("designer");
            comboBox2.Items.Add("tester");
            comboBox2.Items.Add("analyst");
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.BackColor = Color.Empty;
            errorProvider1.SetError(comboBox2, "");
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.BackColor = Color.Empty;
            errorProvider1.SetError(comboBox3, "");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" || comboBox3.Text == "")
            {
                errorProvider1.SetError(comboBox2, "Please enter role .");
                errorProvider1.SetError(comboBox3, "Please enter accounting program.");
                comboBox2.BackColor = Color.Red;
                comboBox3.BackColor = Color.Red;
                MessageBox.Show("Please enter role and accounting program.");

            }
            else
            {
                Personnel yenipersonel = new Personnel();
                yenipersonel.TC = Convert.ToInt32(textBox4.Text);
                yenipersonel.Name = textBox1.Text;
                yenipersonel.Surname = textBox2.Text;
                yenipersonel.Email = textBox3.Text;
                yenipersonel.Role = comboBox2.Text;
                pp.addPersonnel(yenipersonel);

                MessageBox.Show("Login successful");
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
        }
    }
}
