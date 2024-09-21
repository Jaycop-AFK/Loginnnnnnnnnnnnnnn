namespace Loginnnnnnnnnnnnnnn
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
            this.tUser = new System.Windows.Forms.TextBox();
            this.tPwd = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.c_password = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tUser
            // 
            this.tUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.tUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUser.ForeColor = System.Drawing.SystemColors.Window;
            this.tUser.Location = new System.Drawing.Point(60, 105);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(250, 47);
            this.tUser.TabIndex = 0;
            this.tUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tPwd
            // 
            this.tPwd.BackColor = System.Drawing.Color.RoyalBlue;
            this.tPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPwd.ForeColor = System.Drawing.SystemColors.Window;
            this.tPwd.Location = new System.Drawing.Point(60, 187);
            this.tPwd.Name = "tPwd";
            this.tPwd.Size = new System.Drawing.Size(250, 47);
            this.tPwd.TabIndex = 1;
            this.tPwd.UseSystemPasswordChar = true;
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.Blue;
            this.b_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login.ForeColor = System.Drawing.SystemColors.Window;
            this.b_login.Location = new System.Drawing.Point(60, 318);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(250, 43);
            this.b_login.TabIndex = 2;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(94, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "BookFace";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // c_password
            // 
            this.c_password.AutoSize = true;
            this.c_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_password.Location = new System.Drawing.Point(60, 240);
            this.c_password.Name = "c_password";
            this.c_password.Size = new System.Drawing.Size(327, 29);
            this.c_password.TabIndex = 4;
            this.c_password.Text = "SEEEEEEEEEEE PASSWORD";
            this.c_password.UseVisualStyleBackColor = true;
            this.c_password.CheckedChanged += new System.EventHandler(this.c_password_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(384, 451);
            this.Controls.Add(this.c_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.tPwd);
            this.Controls.Add(this.tUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tPwd;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox c_password;
    }
}

