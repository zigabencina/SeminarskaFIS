
namespace Seminarska_Fi
{
    partial class Form1
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
            this.label1_username = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.label2_password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_username
            // 
            this.label1_username.AutoSize = true;
            this.label1_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1_username.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_username.Location = new System.Drawing.Point(294, 161);
            this.label1_username.Name = "label1_username";
            this.label1_username.Size = new System.Drawing.Size(79, 16);
            this.label1_username.TabIndex = 1;
            this.label1_username.Text = "Username: ";
            this.label1_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(524, 249);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2_password
            // 
            this.label2_password.AutoSize = true;
            this.label2_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2_password.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2_password.Location = new System.Drawing.Point(294, 198);
            this.label2_password.Name = "label2_password";
            this.label2_password.Size = new System.Drawing.Size(79, 16);
            this.label2_password.TabIndex = 2;
            this.label2_password.Text = "Password: ";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(362, 158);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(270, 20);
            this.Username.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(362, 195);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(270, 20);
            this.Password.TabIndex = 4;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(393, 249);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Dijak\\Documents\\GitHub\\SeminarskaFIS\\OIP.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(443, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1010, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2_password);
            this.Controls.Add(this.label1_username);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1_username;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label2_password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

