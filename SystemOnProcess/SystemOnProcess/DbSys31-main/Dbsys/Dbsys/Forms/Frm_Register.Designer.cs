namespace Dbsys.Forms
{
    partial class Frm_Register
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
            this.components = new System.ComponentModel.Container();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbBoxRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(24, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(22, 42);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 20);
            this.txtUsername.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Linen;
            this.btnRegister.ForeColor = System.Drawing.Color.IndianRed;
            this.btnRegister.Location = new System.Drawing.Point(24, 206);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(203, 23);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbBoxRole
            // 
            this.cbBoxRole.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbBoxRole.ForeColor = System.Drawing.Color.Black;
            this.cbBoxRole.FormattingEnabled = true;
            this.cbBoxRole.Location = new System.Drawing.Point(24, 165);
            this.cbBoxRole.Name = "cbBoxRole";
            this.cbBoxRole.Size = new System.Drawing.Size(201, 21);
            this.cbBoxRole.TabIndex = 17;
            this.cbBoxRole.SelectedIndexChanged += new System.EventHandler(this.cbBoxRole_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Role";
            // 
            // txtRepassword
            // 
            this.txtRepassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRepassword.ForeColor = System.Drawing.Color.Black;
            this.txtRepassword.Location = new System.Drawing.Point(24, 124);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(203, 20);
            this.txtRepassword.TabIndex = 20;
            this.txtRepassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(21, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Confirm Password";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.errorProvider1.SetIconAlignment(this.pictureBox1, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.pictureBox1.Image = global::Dbsys.Properties.Resources.pic1;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 249);
            this.Controls.Add(this.txtRepassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBoxRole);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Register";
            this.Text = "Frm_Register";
            this.Load += new System.EventHandler(this.Frm_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbBoxRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}