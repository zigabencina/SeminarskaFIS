using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            if(uv.vpisUporabnika(username,password))
            {
                MessageBox.Show("Vspešno vpisani");
            }
            else
            {
                MessageBox.Show("Poskusite ponovno");
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


            uv.append();

        }
    }
}
