namespace Seminarska_Fi
{
    partial class Uporabnik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tip_pocitnice_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tip_pocitnice = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpoc = new System.Windows.Forms.Label();
            this.id_poc_text = new System.Windows.Forms.TextBox();
            this.cena = new System.Windows.Forms.Label();
            this.cena_text = new System.Windows.Forms.TextBox();
            this.termin = new System.Windows.Forms.Label();
            this.termin_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tip_pocitnice_text
            // 
            this.tip_pocitnice_text.Location = new System.Drawing.Point(26, 68);
            this.tip_pocitnice_text.Name = "tip_pocitnice_text";
            this.tip_pocitnice_text.Size = new System.Drawing.Size(123, 20);
            this.tip_pocitnice_text.TabIndex = 0;
            this.tip_pocitnice_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Išči";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tip_pocitnice
            // 
            this.tip_pocitnice.AutoSize = true;
            this.tip_pocitnice.Location = new System.Drawing.Point(23, 43);
            this.tip_pocitnice.Name = "tip_pocitnice";
            this.tip_pocitnice.Size = new System.Drawing.Size(81, 13);
            this.tip_pocitnice.TabIndex = 2;
            this.tip_pocitnice.Text = "Iskanje počitnic";
            this.tip_pocitnice.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 352);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idpoc
            // 
            this.idpoc.AutoSize = true;
            this.idpoc.Location = new System.Drawing.Point(242, 43);
            this.idpoc.Name = "idpoc";
            this.idpoc.Size = new System.Drawing.Size(92, 13);
            this.idpoc.TabIndex = 5;
            this.idpoc.Text = "Iskanje id počitnic";
            this.idpoc.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // id_poc_text
            // 
            this.id_poc_text.Location = new System.Drawing.Point(245, 69);
            this.id_poc_text.Name = "id_poc_text";
            this.id_poc_text.Size = new System.Drawing.Size(123, 20);
            this.id_poc_text.TabIndex = 4;
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Location = new System.Drawing.Point(23, 110);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(108, 13);
            this.cena.TabIndex = 7;
            this.cena.Text = "Iskanje cene počitnic";
            // 
            // cena_text
            // 
            this.cena_text.Location = new System.Drawing.Point(26, 135);
            this.cena_text.Name = "cena_text";
            this.cena_text.Size = new System.Drawing.Size(123, 20);
            this.cena_text.TabIndex = 6;
            // 
            // termin
            // 
            this.termin.AutoSize = true;
            this.termin.Location = new System.Drawing.Point(242, 110);
            this.termin.Name = "termin";
            this.termin.Size = new System.Drawing.Size(118, 13);
            this.termin.TabIndex = 9;
            this.termin.Text = "Iskanje termina počitnic";
            // 
            // termin_text
            // 
            this.termin_text.Location = new System.Drawing.Point(245, 135);
            this.termin_text.Name = "termin_text";
            this.termin_text.Size = new System.Drawing.Size(123, 20);
            this.termin_text.TabIndex = 8;
            // 
            // Uporabnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 645);
            this.Controls.Add(this.termin);
            this.Controls.Add(this.termin_text);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.cena_text);
            this.Controls.Add(this.idpoc);
            this.Controls.Add(this.id_poc_text);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tip_pocitnice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tip_pocitnice_text);
            this.Name = "Uporabnik";
            this.Text = "Pocitnice";
            this.Load += new System.EventHandler(this.Uporabnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tip_pocitnice_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tip_pocitnice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label idpoc;
        private System.Windows.Forms.TextBox id_poc_text;
        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.TextBox cena_text;
        private System.Windows.Forms.Label termin;
        private System.Windows.Forms.TextBox termin_text;
    }
}