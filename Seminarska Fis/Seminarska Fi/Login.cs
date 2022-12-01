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
using Seminarska_Fi;


namespace Seminarska_Fi
{
    public partial class Form1 : Form
    {
        UporabniskiVmesnik uv = new UporabniskiVmesnik();
        Form f = new Form();

        public Form1()
        {
            InitializeComponent();
            uv.podatki();
            Password.PasswordChar = '*';
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uporabnik u = new Uporabnik();

            string username = Username.Text;
            string password = Password.Text;


            if(uv.vpisUporabnika(username,password))
            {
                u.Show();
                MessageBox.Show("Vspešno vpisani");

            }
            

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string username = Username.Text;
            string password = Password.Text;

            uv.registracijaUporabnika(username,password);

            

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_arr_Click(object sender, EventArgs e)
        {


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {

            if (Password.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Login.Focus();
                    Login.PerformClick();
                }
            }
        }
    }
}
