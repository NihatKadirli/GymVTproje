namespace GymVTProje
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.textBoxMemberSurname = new System.Windows.Forms.TextBox();
            this.textMemberPhone = new System.Windows.Forms.TextBox();
            this.textMemberEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1ADDMEMBER = new System.Windows.Forms.Button();
            this.button2DELETEMEMBER = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textMemberID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1List = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxSTAFFMEMBER = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.BackColor = System.Drawing.Color.LightGray;
            this.textBoxMemberName.Location = new System.Drawing.Point(167, 270);
            this.textBoxMemberName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(120, 23);
            this.textBoxMemberName.TabIndex = 0;
            // 
            // textBoxMemberSurname
            // 
            this.textBoxMemberSurname.BackColor = System.Drawing.Color.LightGray;
            this.textBoxMemberSurname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxMemberSurname.Location = new System.Drawing.Point(167, 315);
            this.textBoxMemberSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMemberSurname.Name = "textBoxMemberSurname";
            this.textBoxMemberSurname.Size = new System.Drawing.Size(120, 23);
            this.textBoxMemberSurname.TabIndex = 1;
            // 
            // textMemberPhone
            // 
            this.textMemberPhone.BackColor = System.Drawing.Color.LightGray;
            this.textMemberPhone.Location = new System.Drawing.Point(167, 359);
            this.textMemberPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textMemberPhone.Name = "textMemberPhone";
            this.textMemberPhone.Size = new System.Drawing.Size(120, 23);
            this.textMemberPhone.TabIndex = 5;
            // 
            // textMemberEmail
            // 
            this.textMemberEmail.BackColor = System.Drawing.Color.LightGray;
            this.textMemberEmail.Location = new System.Drawing.Point(167, 399);
            this.textMemberEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textMemberEmail.Name = "textMemberEmail";
            this.textMemberEmail.Size = new System.Drawing.Size(120, 23);
            this.textMemberEmail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(80, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Surname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 399);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "E-mail";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1ADDMEMBER
            // 
            this.button1ADDMEMBER.BackColor = System.Drawing.Color.SeaGreen;
            this.button1ADDMEMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1ADDMEMBER.ForeColor = System.Drawing.Color.Transparent;
            this.button1ADDMEMBER.Location = new System.Drawing.Point(43, 497);
            this.button1ADDMEMBER.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1ADDMEMBER.Name = "button1ADDMEMBER";
            this.button1ADDMEMBER.Size = new System.Drawing.Size(89, 37);
            this.button1ADDMEMBER.TabIndex = 23;
            this.button1ADDMEMBER.Text = "Add";
            this.button1ADDMEMBER.UseVisualStyleBackColor = false;
            this.button1ADDMEMBER.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2DELETEMEMBER
            // 
            this.button2DELETEMEMBER.BackColor = System.Drawing.Color.SeaGreen;
            this.button2DELETEMEMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2DELETEMEMBER.ForeColor = System.Drawing.Color.Transparent;
            this.button2DELETEMEMBER.Location = new System.Drawing.Point(41, 564);
            this.button2DELETEMEMBER.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2DELETEMEMBER.Name = "button2DELETEMEMBER";
            this.button2DELETEMEMBER.Size = new System.Drawing.Size(98, 37);
            this.button2DELETEMEMBER.TabIndex = 24;
            this.button2DELETEMEMBER.Text = "Delete";
            this.button2DELETEMEMBER.UseVisualStyleBackColor = false;
            this.button2DELETEMEMBER.Click += new System.EventHandler(this.button2RESETMEMBER_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("ROG Fonts", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(413, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(425, 133);
            this.label11.TabIndex = 25;
            this.label11.Text = "Member Managment";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(41, 223);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 27);
            this.label12.TabIndex = 27;
            this.label12.Text = "MemberID";
            // 
            // textMemberID
            // 
            this.textMemberID.BackColor = System.Drawing.Color.LightGray;
            this.textMemberID.Location = new System.Drawing.Point(167, 228);
            this.textMemberID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textMemberID.Name = "textMemberID";
            this.textMemberID.Size = new System.Drawing.Size(120, 23);
            this.textMemberID.TabIndex = 26;
            this.textMemberID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(322, 152);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 382);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1List
            // 
            this.button1List.BackColor = System.Drawing.Color.SeaGreen;
            this.button1List.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1List.ForeColor = System.Drawing.Color.Transparent;
            this.button1List.Location = new System.Drawing.Point(189, 497);
            this.button1List.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1List.Name = "button1List";
            this.button1List.Size = new System.Drawing.Size(98, 37);
            this.button1List.TabIndex = 29;
            this.button1List.Text = "List";
            this.button1List.UseVisualStyleBackColor = false;
            this.button1List.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(189, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 31;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(668, 606);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 37);
            this.button2.TabIndex = 32;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSearch.Location = new System.Drawing.Point(734, 566);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(120, 23);
            this.textBoxSearch.TabIndex = 33;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(548, 562);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "Search for in table";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(925, 152);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(278, 382);
            this.dataGridView2.TabIndex = 35;
            // 
            // textBoxSTAFFMEMBER
            // 
            this.textBoxSTAFFMEMBER.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSTAFFMEMBER.Location = new System.Drawing.Point(167, 441);
            this.textBoxSTAFFMEMBER.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSTAFFMEMBER.Name = "textBoxSTAFFMEMBER";
            this.textBoxSTAFFMEMBER.Size = new System.Drawing.Size(120, 23);
            this.textBoxSTAFFMEMBER.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 441);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 27);
            this.label4.TabIndex = 37;
            this.label4.Text = "Staff";
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 672);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSTAFFMEMBER);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1List);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textMemberID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2DELETEMEMBER);
            this.Controls.Add(this.button1ADDMEMBER);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMemberEmail);
            this.Controls.Add(this.textMemberPhone);
            this.Controls.Add(this.textBoxMemberSurname);
            this.Controls.Add(this.textBoxMemberName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Member";
            this.Text = "NewMember";
            this.Load += new System.EventHandler(this.NewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.TextBox textBoxMemberSurname;
        private System.Windows.Forms.TextBox textMemberPhone;
        private System.Windows.Forms.TextBox textMemberEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1ADDMEMBER;
        private System.Windows.Forms.Button button2DELETEMEMBER;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textMemberID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1List;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxSTAFFMEMBER;
        private System.Windows.Forms.Label label4;
    }
}