namespace Order_Checker
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
            this.button1Get = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1SearchID = new System.Windows.Forms.TextBox();
            this.button2Search = new System.Windows.Forms.Button();
            this.textBox2AddDName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3AddQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4AddPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5AddDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6AddPhaName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7AddPhaAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8AddPharCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9AddPhaContact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3Add = new System.Windows.Forms.Button();
            this.button4Update = new System.Windows.Forms.Button();
            this.textBox10UpdateID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button5Delete = new System.Windows.Forms.Button();
            this.textBox11DeleteID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Get
            // 
            this.button1Get.Location = new System.Drawing.Point(30, 53);
            this.button1Get.Name = "button1Get";
            this.button1Get.Size = new System.Drawing.Size(101, 39);
            this.button1Get.TabIndex = 0;
            this.button1Get.Text = "Get All";
            this.button1Get.UseVisualStyleBackColor = true;
            this.button1Get.Click += new System.EventHandler(this.button1Get_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SearchID";
            // 
            // textBox1SearchID
            // 
            this.textBox1SearchID.Location = new System.Drawing.Point(225, 63);
            this.textBox1SearchID.Name = "textBox1SearchID";
            this.textBox1SearchID.Size = new System.Drawing.Size(100, 20);
            this.textBox1SearchID.TabIndex = 2;
            // 
            // button2Search
            // 
            this.button2Search.Location = new System.Drawing.Point(225, 89);
            this.button2Search.Name = "button2Search";
            this.button2Search.Size = new System.Drawing.Size(75, 23);
            this.button2Search.TabIndex = 3;
            this.button2Search.Text = "Search";
            this.button2Search.UseVisualStyleBackColor = true;
            this.button2Search.Click += new System.EventHandler(this.button2Search_Click);
            // 
            // textBox2AddDName
            // 
            this.textBox2AddDName.Location = new System.Drawing.Point(482, 37);
            this.textBox2AddDName.Name = "textBox2AddDName";
            this.textBox2AddDName.Size = new System.Drawing.Size(100, 20);
            this.textBox2AddDName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DName";
            // 
            // textBox3AddQty
            // 
            this.textBox3AddQty.Location = new System.Drawing.Point(482, 62);
            this.textBox3AddQty.Name = "textBox3AddQty";
            this.textBox3AddQty.Size = new System.Drawing.Size(100, 20);
            this.textBox3AddQty.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qty";
            // 
            // textBox4AddPrice
            // 
            this.textBox4AddPrice.Location = new System.Drawing.Point(482, 88);
            this.textBox4AddPrice.Name = "textBox4AddPrice";
            this.textBox4AddPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox4AddPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // textBox5AddDesc
            // 
            this.textBox5AddDesc.Location = new System.Drawing.Point(482, 114);
            this.textBox5AddDesc.Name = "textBox5AddDesc";
            this.textBox5AddDesc.Size = new System.Drawing.Size(100, 20);
            this.textBox5AddDesc.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description";
            // 
            // textBox6AddPhaName
            // 
            this.textBox6AddPhaName.Location = new System.Drawing.Point(482, 140);
            this.textBox6AddPhaName.Name = "textBox6AddPhaName";
            this.textBox6AddPhaName.Size = new System.Drawing.Size(100, 20);
            this.textBox6AddPhaName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "PharmacyName";
            // 
            // textBox7AddPhaAddress
            // 
            this.textBox7AddPhaAddress.Location = new System.Drawing.Point(482, 166);
            this.textBox7AddPhaAddress.Name = "textBox7AddPhaAddress";
            this.textBox7AddPhaAddress.Size = new System.Drawing.Size(100, 20);
            this.textBox7AddPhaAddress.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pham.Address";
            // 
            // textBox8AddPharCity
            // 
            this.textBox8AddPharCity.Location = new System.Drawing.Point(482, 192);
            this.textBox8AddPharCity.Name = "textBox8AddPharCity";
            this.textBox8AddPharCity.Size = new System.Drawing.Size(100, 20);
            this.textBox8AddPharCity.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Pham.City";
            // 
            // textBox9AddPhaContact
            // 
            this.textBox9AddPhaContact.Location = new System.Drawing.Point(482, 218);
            this.textBox9AddPhaContact.Name = "textBox9AddPhaContact";
            this.textBox9AddPhaContact.Size = new System.Drawing.Size(100, 20);
            this.textBox9AddPhaContact.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Pham.Contact";
            // 
            // button3Add
            // 
            this.button3Add.Location = new System.Drawing.Point(482, 258);
            this.button3Add.Name = "button3Add";
            this.button3Add.Size = new System.Drawing.Size(75, 23);
            this.button3Add.TabIndex = 20;
            this.button3Add.Text = "Add";
            this.button3Add.UseVisualStyleBackColor = true;
            this.button3Add.Click += new System.EventHandler(this.button3Add_Click);
            // 
            // button4Update
            // 
            this.button4Update.Location = new System.Drawing.Point(717, 79);
            this.button4Update.Name = "button4Update";
            this.button4Update.Size = new System.Drawing.Size(75, 23);
            this.button4Update.TabIndex = 23;
            this.button4Update.Text = "Update";
            this.button4Update.UseVisualStyleBackColor = true;
            this.button4Update.Click += new System.EventHandler(this.button4Update_Click);
            // 
            // textBox10UpdateID
            // 
            this.textBox10UpdateID.Location = new System.Drawing.Point(717, 53);
            this.textBox10UpdateID.Name = "textBox10UpdateID";
            this.textBox10UpdateID.Size = new System.Drawing.Size(100, 20);
            this.textBox10UpdateID.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "UpdateID";
            // 
            // button5Delete
            // 
            this.button5Delete.Location = new System.Drawing.Point(717, 175);
            this.button5Delete.Name = "button5Delete";
            this.button5Delete.Size = new System.Drawing.Size(75, 23);
            this.button5Delete.TabIndex = 26;
            this.button5Delete.Text = "Delete";
            this.button5Delete.UseVisualStyleBackColor = true;
            this.button5Delete.Click += new System.EventHandler(this.button5Delete_Click);
            // 
            // textBox11DeleteID
            // 
            this.textBox11DeleteID.Location = new System.Drawing.Point(717, 149);
            this.textBox11DeleteID.Name = "textBox11DeleteID";
            this.textBox11DeleteID.Size = new System.Drawing.Size(100, 20);
            this.textBox11DeleteID.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(662, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "DeleteID";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(12, 298);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(858, 165);
            this.dataGridViewOrder.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 465);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.button5Delete);
            this.Controls.Add(this.textBox11DeleteID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4Update);
            this.Controls.Add(this.textBox10UpdateID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3Add);
            this.Controls.Add(this.textBox9AddPhaContact);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8AddPharCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7AddPhaAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6AddPhaName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5AddDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4AddPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3AddQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2AddDName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2Search);
            this.Controls.Add(this.textBox1SearchID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1Get);
            this.Name = "Form1";
            this.Text = "Order Checker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Get;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1SearchID;
        private System.Windows.Forms.Button button2Search;
        private System.Windows.Forms.TextBox textBox2AddDName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3AddQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4AddPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5AddDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6AddPhaName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7AddPhaAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8AddPharCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9AddPhaContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3Add;
        private System.Windows.Forms.Button button4Update;
        private System.Windows.Forms.TextBox textBox10UpdateID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5Delete;
        private System.Windows.Forms.TextBox textBox11DeleteID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
    }
}

