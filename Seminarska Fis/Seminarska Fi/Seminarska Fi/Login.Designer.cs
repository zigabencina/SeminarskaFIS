
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
            this.button1_arr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_username
            // 
            this.label1_username.AutoSize = true;
            this.label1_username.Location = new System.Drawing.Point(290, 35);
            this.label1_username.Name = "label1_username";
            this.label1_username.Size = new System.Drawing.Size(61, 13);
            this.label1_username.TabIndex = 1;
            this.label1_username.Text = "Username: ";
            this.label1_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(543, 123);
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
            this.label2_password.Location = new System.Drawing.Point(290, 72);
            this.label2_password.Name = "label2_password";
            this.label2_password.Size = new System.Drawing.Size(59, 13);
            this.label2_password.TabIndex = 2;
            this.label2_password.Text = "Password: ";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(348, 32);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(270, 20);
            this.Username.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(348, 69);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(270, 20);
            this.Password.TabIndex = 4;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(462, 123);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1_arr
            // 
            this.button1_arr.Location = new System.Drawing.Point(689, 236);
            this.button1_arr.Name = "button1_arr";
            this.button1_arr.Size = new System.Drawing.Size(75, 23);
            this.button1_arr.TabIndex = 6;
            this.button1_arr.Text = "Add to arr";
            this.button1_arr.UseVisualStyleBackColor = true;
            this.button1_arr.Click += new System.EventHandler(this.button1_arr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.button1_arr);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2_password);
            this.Controls.Add(this.label1_username);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button button1_arr;
    }
}

