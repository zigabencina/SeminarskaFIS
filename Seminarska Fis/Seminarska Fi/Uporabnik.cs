using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminarska_Fi
{
    public partial class Uporabnik : Form
    {
        public List<Pocitnice> pocitnice_ { get; set; }

        public Uporabnik()
        {
            pocitnice_ = GetPocinice();
            InitializeComponent();
        }

        private List<Pocitnice> GetPocinice()
        {
            var list = new List<Pocitnice>();

            list.Add(new Pocitnice() {
                id = 0,
                tip_pocitnic = "Potovanje",
                max_ljudi = 10,
                drzava = "Slovenja",
                cena = 1000,
                termin = "20.4.2022 20.5.2022",

            });
            list.Add(new Pocitnice()
            {
                id = 1,
                tip_pocitnic = "Krizarjenje",
                max_ljudi = 200,
                drzava = "Italija",
                cena = 125000,
                termin = "23.6.2022 5.7.2022",

            });
            list.Add(new Pocitnice()
            {
                id = 2,
                tip_pocitnic = "Kampiranje",
                max_ljudi = 5,
                drzava = "Slovenja",
                cena = 100,
                termin = "4.1.2022 5.1.2022",

            });
            return list;
        }

        private void Uporabnik_Load(object sender, EventArgs e)
        {
            var pocitnice__ = this.pocitnice_;
            dataGridView1.DataSource = pocitnice__;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var izbranePocitnice = dataGridView1.SelectedRows[0].DataBoundItem as Pocitnice;
                textbox
            }
            catch(Exception ex)
            {
                MessageBox.Show("Prislo je do napake: " + ex.Message + " - " + ex.Source);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
