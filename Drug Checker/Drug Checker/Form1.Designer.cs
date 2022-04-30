namespace Drug_Checker
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
            this.button1Gett = new System.Windows.Forms.Button();
            this.dataGridView1Drug = new System.Windows.Forms.DataGridView();
            this.button2Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchID = new System.Windows.Forms.TextBox();
            this.textBox2AddName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3AddPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4AddSName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5AddDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6Addqty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9AddBName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1Exp = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2Mn = new System.Windows.Forms.DateTimePicker();
            this.button3Add = new System.Windows.Forms.Button();
            this.button4Update = new System.Windows.Forms.Button();
            this.textBoxUpdateID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDeleteID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Drug)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Gett
            // 
            this.button1Gett.Location = new System.Drawing.Point(38, 58);
            this.button1Gett.Name = "button1Gett";
            this.button1Gett.Size = new System.Drawing.Size(109, 38);
            this.button1Gett.TabIndex = 0;
            this.button1Gett.Text = "Get All";
            this.button1Gett.UseVisualStyleBackColor = true;
            this.button1Gett.Click += new System.EventHandler(this.button1Gett_Click);
            // 
            // dataGridView1Drug
            // 
            this.dataGridView1Drug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Drug.Location = new System.Drawing.Point(38, 292);
            this.dataGridView1Drug.Name = "dataGridView1Drug";
            this.dataGridView1Drug.Size = new System.Drawing.Size(712, 242);
            this.dataGridView1Drug.TabIndex = 1;
            // 
            // button2Search
            // 
            this.button2Search.Location = new System.Drawing.Point(235, 94);
            this.button2Search.Name = "button2Search";
            this.button2Search.Size = new System.Drawing.Size(75, 23);
            this.button2Search.TabIndex = 2;
            this.button2Search.Text = "Search";
            this.button2Search.UseVisualStyleBackColor = true;
            this.button2Search.Click += new System.EventHandler(this.button2Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search ID";
            // 
            // textBoxSearchID
            // 
            this.textBoxSearchID.Location = new System.Drawing.Point(235, 68);
            this.textBoxSearchID.Name = "textBoxSearchID";
            this.textBoxSearchID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchID.TabIndex = 4;
            // 
            // textBox2AddName
            // 
            this.textBox2AddName.Location = new System.Drawing.Point(450, 37);
            this.textBox2AddName.Name = "textBox2AddName";
            this.textBox2AddName.Size = new System.Drawing.Size(100, 20);
            this.textBox2AddName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // textBox3AddPrice
            // 
            this.textBox3AddPrice.Location = new System.Drawing.Point(450, 61);
            this.textBox3AddPrice.Name = "textBox3AddPrice";
            this.textBox3AddPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox3AddPrice.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // textBox4AddSName
            // 
            this.textBox4AddSName.Location = new System.Drawing.Point(450, 87);
            this.textBox4AddSName.Name = "textBox4AddSName";
            this.textBox4AddSName.Size = new System.Drawing.Size(100, 20);
            this.textBox4AddSName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "S_Name";
            // 
            // textBox5AddDesc
            // 
            this.textBox5AddDesc.Location = new System.Drawing.Point(450, 113);
            this.textBox5AddDesc.Name = "textBox5AddDesc";
            this.textBox5AddDesc.Size = new System.Drawing.Size(100, 20);
            this.textBox5AddDesc.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // textBox6Addqty
            // 
            this.textBox6Addqty.Location = new System.Drawing.Point(450, 139);
            this.textBox6Addqty.Name = "textBox6Addqty";
            this.textBox6Addqty.Size = new System.Drawing.Size(100, 20);
            this.textBox6Addqty.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Qty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ExpDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ManDate";
            // 
            // textBox9AddBName
            // 
            this.textBox9AddBName.Location = new System.Drawing.Point(450, 218);
            this.textBox9AddBName.Name = "textBox9AddBName";
            this.textBox9AddBName.Size = new System.Drawing.Size(100, 20);
            this.textBox9AddBName.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "BrandName";
            // 
            // dateTimePicker1Exp
            // 
            this.dateTimePicker1Exp.Location = new System.Drawing.Point(450, 166);
            this.dateTimePicker1Exp.Name = "dateTimePicker1Exp";
            this.dateTimePicker1Exp.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1Exp.TabIndex = 21;
            // 
            // dateTimePicker2Mn
            // 
            this.dateTimePicker2Mn.Location = new System.Drawing.Point(450, 192);
            this.dateTimePicker2Mn.Name = "dateTimePicker2Mn";
            this.dateTimePicker2Mn.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2Mn.TabIndex = 22;
            // 
            // button3Add
            // 
            this.button3Add.Location = new System.Drawing.Point(450, 254);
            this.button3Add.Name = "button3Add";
            this.button3Add.Size = new System.Drawing.Size(75, 23);
            this.button3Add.TabIndex = 23;
            this.button3Add.Text = "Add";
            this.button3Add.UseVisualStyleBackColor = true;
            this.button3Add.Click += new System.EventHandler(this.button3Add_Click);
            // 
            // button4Update
            // 
            this.button4Update.Location = new System.Drawing.Point(695, 66);
            this.button4Update.Name = "button4Update";
            this.button4Update.Size = new System.Drawing.Size(75, 23);
            this.button4Update.TabIndex = 24;
            this.button4Update.Text = "Update";
            this.button4Update.UseVisualStyleBackColor = true;
            this.button4Update.Click += new System.EventHandler(this.button4Update_Click);
            // 
            // textBoxUpdateID
            // 
            this.textBoxUpdateID.Location = new System.Drawing.Point(695, 40);
            this.textBoxUpdateID.Name = "textBoxUpdateID";
            this.textBoxUpdateID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateID.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "UpdateID";
            // 
            // textBoxDeleteID
            // 
            this.textBoxDeleteID.Location = new System.Drawing.Point(695, 116);
            this.textBoxDeleteID.Name = "textBoxDeleteID";
            this.textBoxDeleteID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeleteID.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(644, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "DeleteID";
            // 
            // button5Delete
            // 
            this.button5Delete.Location = new System.Drawing.Point(695, 142);
            this.button5Delete.Name = "button5Delete";
            this.button5Delete.Size = new System.Drawing.Size(75, 23);
            this.button5Delete.TabIndex = 29;
            this.button5Delete.Text = "Delete";
            this.button5Delete.UseVisualStyleBackColor = true;
            this.button5Delete.Click += new System.EventHandler(this.button5Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 546);
            this.Controls.Add(this.button5Delete);
            this.Controls.Add(this.textBoxDeleteID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxUpdateID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4Update);
            this.Controls.Add(this.button3Add);
            this.Controls.Add(this.dateTimePicker2Mn);
            this.Controls.Add(this.dateTimePicker1Exp);
            this.Controls.Add(this.textBox9AddBName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6Addqty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5AddDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4AddSName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3AddPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2AddName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearchID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Search);
            this.Controls.Add(this.dataGridView1Drug);
            this.Controls.Add(this.button1Gett);
            this.Name = "Form1";
            this.Text = "Drug Checker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Drug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Gett;
        private System.Windows.Forms.DataGridView dataGridView1Drug;
        private System.Windows.Forms.Button button2Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchID;
        private System.Windows.Forms.TextBox textBox2AddName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3AddPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4AddSName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5AddDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6Addqty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9AddBName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Exp;
        private System.Windows.Forms.DateTimePicker dateTimePicker2Mn;
        private System.Windows.Forms.Button button3Add;
        private System.Windows.Forms.Button button4Update;
        private System.Windows.Forms.TextBox textBoxUpdateID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDeleteID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5Delete;
    }
}

