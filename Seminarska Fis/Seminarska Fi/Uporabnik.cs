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
        //public List<Pocitnice> pocitnice_ { get; set; }
        public DataTable pocitnice_ { get; set; }

        public Uporabnik()
        {
            //pocitnice_ = GetPocinice();
            pocitnice_ = narediTable();

            InitializeComponent();
        }
        
        private List<Pocitnice> GetPocinice()
        {
            var list = new List<Pocitnice>();

            list.Add(new Pocitnice() {
                id = 0,
                tip_pocitnic = "Potovanje",
                max_ljudi = 10,
                drzava = "Slovenija",
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
                drzava = "Slovenija",
                cena = 100,
                termin = "4.1.2022 5.1.2022",

            });
            return list;
        }
        


        public static DataTable narediTable()
        {
            DataTable dataTable = new DataTable("Customers");
            DataColumn dtColumn;
            DataRow myDataRow;

            // Create id column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "id";
            dtColumn.Caption = "ID";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = true;
            // Add column to the DataColumnCollection.
            dataTable.Columns.Add(dtColumn);

            // Create Name column.
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Tip";
            dtColumn.Caption = "Tip pocitnic";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.
            dataTable.Columns.Add(dtColumn);

            // Create Address column.
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Max";
            dtColumn.Caption = "Max ljudi";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add column to the DataColumnCollection.
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Drzava";
            dtColumn.Caption = "Drzava";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.
            /// 
            dataTable.Columns.Add(dtColumn);
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Cena";
            dtColumn.Caption = "Cena pocitnic";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.
            dataTable.Columns.Add(dtColumn);
            
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Termin_od";
            dtColumn.Caption = "Termin pocitnic";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;

            /// Add column to the DataColumnCollection. doda stolpec v tabelo
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Termin_do";
            dtColumn.Caption = "Termin pocitnic";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;

            /// Add column to the DataColumnCollection. doda stolpec v tabelo
            dataTable.Columns.Add(dtColumn);

            // Make id column the primary key column. naredi primarni kljuc
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = dataTable.Columns["id"];
            dataTable.PrimaryKey = PrimaryKeyColumns;

            // Create a new DataSet
            DataSet dtSet = new DataSet();

            myDataRow = dataTable.NewRow();
            myDataRow["id"] = 0;
            myDataRow["Tip"] = "Potovanje";
            myDataRow["Cena"] = "10000";
            myDataRow["Drzava"] = "Slovenija";
            myDataRow["Max"] = "5";
            myDataRow["Termin_od"] = "4.1.2022 ";
            myDataRow["Termin_do"] = "5.1.2022";
            dataTable.Rows.Add(myDataRow);
            
            myDataRow = dataTable.NewRow();
            myDataRow["id"] = 1;
            myDataRow["Tip"] = "Križarjenje";
            myDataRow["Cena"] = "20000";
            myDataRow["Drzava"] = "Slovenija";
            myDataRow["Max"] = "6";
            myDataRow["Termin_od"] = "2.2.2022 ";
            myDataRow["Termin_do"] = "3.4.2022";
            dataTable.Rows.Add(myDataRow);
            
            myDataRow = dataTable.NewRow();
            myDataRow["id"] = 2;
            myDataRow["Tip"] = "Kamping";
            myDataRow["Cena"] = "30000";
            myDataRow["Drzava"] = "Slovenija";
            myDataRow["Max"] = "7";
            myDataRow["Termin_od"] = "5.6.2022";
            myDataRow["Termin_do"] = " 2.7.2022";
            dataTable.Rows.Add(myDataRow);


            myDataRow = dataTable.NewRow();
            myDataRow["id"] = 3;
            myDataRow["Tip"] = "Pohod";
            myDataRow["Cena"] = "30000";
            myDataRow["Drzava"] = "Slovenija";
            myDataRow["Max"] = "8";
            myDataRow["Termin_od"] = "9.1.2023";
            myDataRow["Termin_do"] = "21.1.2023";
            dataTable.Rows.Add(myDataRow);

            return dataTable;
        }

        private void Uporabnik_Load(object sender, EventArgs e)
        {
            var pocitnice__ = this.pocitnice_;
            //dataGridView1.DataSource = pocitnice__;
            dataGridView1.DataSource = pocitnice__;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Tip LIKE '{0}%'", tip_pocitnice_text.Text);
=======
            string searchValue = tip_pocitnice_text.Text;
            int rowIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(searchValue))
                    {
                        rowIndex = row.Index;
                        dataGridView1.ClearSelection();
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                        dataGridView1.Focus();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No solutions with that name.");
            }
           
>>>>>>> Stashed changes
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
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Prislo je do napake: " + ex.Message + " - " + ex.Source);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void id_poc_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cena_text_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Cena LIKE '{0}%'", cena_text.Text);
        }

        private void termin_text_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Termin_od LIKE '{0}%'", termin_text.Text);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void drzava_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Drzava LIKE '{0}%'", drzava.Text);
        }
    }
}
