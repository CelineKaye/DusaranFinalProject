namespace DusaranFinalProject
{
    partial class Masterfiles
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet Masterfile Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pet Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Location = new System.Drawing.Point(115, 80);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(121, 21);
            this.txtType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Upload Photo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Breed:";
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(304, 81);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(100, 20);
            this.txtBreed.TabIndex = 8;
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Location = new System.Drawing.Point(115, 107);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(121, 21);
            this.txtStatus.TabIndex = 9;
            this.txtStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(221, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Update";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(327, 230);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Delete";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(115, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 90);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPets
            // 
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Location = new System.Drawing.Point(34, 256);
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPets.Size = new System.Drawing.Size(393, 175);
            this.dgvPets.TabIndex = 14;
            this.dgvPets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPets_CellClick);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(34, 228);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(115, 228);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 23);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(304, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID:";
            // 
            // Masterfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 453);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dgvPets);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Masterfiles";
            this.Text = "Masterfiles";
            this.Load += new System.EventHandler(this.Masterfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
    }
}