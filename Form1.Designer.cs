
namespace project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tfn = new System.Windows.Forms.TextBox();
            this.Tln = new System.Windows.Forms.TextBox();
            this.Tbd = new System.Windows.Forms.TextBox();
            this.Tgen = new System.Windows.Forms.TextBox();
            this.Tml = new System.Windows.Forms.TextBox();
            this.Tphno = new System.Windows.Forms.TextBox();
            this.CreBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.Tage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ph. No.";
            // 
            // Tfn
            // 
            this.Tfn.Location = new System.Drawing.Point(115, 11);
            this.Tfn.Name = "Tfn";
            this.Tfn.Size = new System.Drawing.Size(100, 20);
            this.Tfn.TabIndex = 6;
            // 
            // Tln
            // 
            this.Tln.Location = new System.Drawing.Point(115, 45);
            this.Tln.Name = "Tln";
            this.Tln.Size = new System.Drawing.Size(100, 20);
            this.Tln.TabIndex = 7;
            // 
            // Tbd
            // 
            this.Tbd.Location = new System.Drawing.Point(115, 79);
            this.Tbd.Name = "Tbd";
            this.Tbd.Size = new System.Drawing.Size(100, 20);
            this.Tbd.TabIndex = 8;
            this.Tbd.Leave += new System.EventHandler(this.Tbd_Leave);
            // 
            // Tgen
            // 
            this.Tgen.Location = new System.Drawing.Point(115, 114);
            this.Tgen.Name = "Tgen";
            this.Tgen.Size = new System.Drawing.Size(100, 20);
            this.Tgen.TabIndex = 9;
            // 
            // Tml
            // 
            this.Tml.Location = new System.Drawing.Point(115, 149);
            this.Tml.Name = "Tml";
            this.Tml.Size = new System.Drawing.Size(100, 20);
            this.Tml.TabIndex = 10;
            this.Tml.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Tphno
            // 
            this.Tphno.Location = new System.Drawing.Point(115, 185);
            this.Tphno.Name = "Tphno";
            this.Tphno.Size = new System.Drawing.Size(100, 20);
            this.Tphno.TabIndex = 11;
            // 
            // CreBtn
            // 
            this.CreBtn.Location = new System.Drawing.Point(112, 312);
            this.CreBtn.Name = "CreBtn";
            this.CreBtn.Size = new System.Drawing.Size(115, 45);
            this.CreBtn.TabIndex = 12;
            this.CreBtn.Text = "Create";
            this.CreBtn.UseVisualStyleBackColor = true;
            this.CreBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 45);
            this.button3.TabIndex = 14;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(233, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 45);
            this.button4.TabIndex = 15;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(233, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(603, 266);
            this.dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DOB";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Phone No.";
            this.Column6.Name = "Column6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Age";
            // 
            // Tage
            // 
            this.Tage.Location = new System.Drawing.Point(115, 220);
            this.Tage.Name = "Tage";
            this.Tage.Size = new System.Drawing.Size(100, 20);
            this.Tage.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 532);
            this.Controls.Add(this.Tage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CreBtn);
            this.Controls.Add(this.Tphno);
            this.Controls.Add(this.Tml);
            this.Controls.Add(this.Tgen);
            this.Controls.Add(this.Tbd);
            this.Controls.Add(this.Tln);
            this.Controls.Add(this.Tfn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tfn;
        private System.Windows.Forms.TextBox Tln;
        private System.Windows.Forms.TextBox Tbd;
        private System.Windows.Forms.TextBox Tgen;
        private System.Windows.Forms.TextBox Tml;
        private System.Windows.Forms.TextBox Tphno;
        private System.Windows.Forms.Button CreBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tage;
    }
}

