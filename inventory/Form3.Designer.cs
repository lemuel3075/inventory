namespace inventory
{
    partial class Form3
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbitem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbstock = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(617, 84);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 27);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbitem
            // 
            this.tbitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbitem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbitem.Location = new System.Drawing.Point(459, 96);
            this.tbitem.Margin = new System.Windows.Forms.Padding(2);
            this.tbitem.Name = "tbitem";
            this.tbitem.Size = new System.Drawing.Size(139, 27);
            this.tbitem.TabIndex = 1;
            this.tbitem.TextChanged += new System.EventHandler(this.tbitem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add Stock";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbstock
            // 
            this.tbstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbstock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbstock.Location = new System.Drawing.Point(459, 155);
            this.tbstock.Margin = new System.Windows.Forms.Padding(2);
            this.tbstock.Name = "tbstock";
            this.tbstock.Size = new System.Drawing.Size(139, 27);
            this.tbstock.TabIndex = 3;
            this.tbstock.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(617, 132);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 27);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(617, 177);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(14, 13);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.Size = new System.Drawing.Size(323, 234);
            this.dgvStock.TabIndex = 7;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(617, 39);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 27);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbNum1
            // 
            this.tbNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbNum1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum1.Location = new System.Drawing.Point(459, 43);
            this.tbNum1.Margin = new System.Windows.Forms.Padding(2);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(139, 27);
            this.tbNum1.TabIndex = 9;
            this.tbNum1.TextChanged += new System.EventHandler(this.tbNum1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(16, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 51);
            this.label5.TabIndex = 12;
            this.label5.Text = "L";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(21, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Inventory Managment System";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbNum1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.dgvStock);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbstock);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbitem);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(11, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 259);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(624, 8);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 21);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(67, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "EMZ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 389);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbitem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbstock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
    }
}