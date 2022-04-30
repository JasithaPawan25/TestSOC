namespace SupplierCheckerApp
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
            this.btnAllSuppliers = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Searchbutton1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAddSupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddSupAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddSupContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddDrugName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddDrugPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuppAdd = new System.Windows.Forms.Button();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.button2SupSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateContact = new System.Windows.Forms.TextBox();
            this.txtUpdateDrugName = new System.Windows.Forms.TextBox();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.textBoxDeleteID = new System.Windows.Forms.TextBox();
            this.button1Delete = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllSuppliers
            // 
            this.btnAllSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllSuppliers.Location = new System.Drawing.Point(29, 35);
            this.btnAllSuppliers.Name = "btnAllSuppliers";
            this.btnAllSuppliers.Size = new System.Drawing.Size(160, 45);
            this.btnAllSuppliers.TabIndex = 0;
            this.btnAllSuppliers.Text = "All Suppliers";
            this.btnAllSuppliers.UseVisualStyleBackColor = true;
            this.btnAllSuppliers.Click += new System.EventHandler(this.btnAllSuppliers_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(29, 221);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(759, 264);
            this.dgvSupplier.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "SupplierID";
            // 
            // Searchbutton1
            // 
            this.Searchbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton1.Location = new System.Drawing.Point(325, 77);
            this.Searchbutton1.Name = "Searchbutton1";
            this.Searchbutton1.Size = new System.Drawing.Size(95, 34);
            this.Searchbutton1.TabIndex = 3;
            this.Searchbutton1.Text = "Search Suppliers";
            this.Searchbutton1.UseVisualStyleBackColor = true;
            this.Searchbutton1.Click += new System.EventHandler(this.Searchbutton1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(325, 51);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtAddSupName
            // 
            this.txtAddSupName.Location = new System.Drawing.Point(602, 49);
            this.txtAddSupName.Name = "txtAddSupName";
            this.txtAddSupName.Size = new System.Drawing.Size(100, 20);
            this.txtAddSupName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "SupplierName";
            // 
            // txtAddSupAdress
            // 
            this.txtAddSupAdress.Location = new System.Drawing.Point(602, 75);
            this.txtAddSupAdress.Name = "txtAddSupAdress";
            this.txtAddSupAdress.Size = new System.Drawing.Size(100, 20);
            this.txtAddSupAdress.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "SupplierAddress";
            // 
            // txtAddSupContact
            // 
            this.txtAddSupContact.Location = new System.Drawing.Point(602, 101);
            this.txtAddSupContact.Name = "txtAddSupContact";
            this.txtAddSupContact.Size = new System.Drawing.Size(100, 20);
            this.txtAddSupContact.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "SupplierContact";
            // 
            // txtAddDrugName
            // 
            this.txtAddDrugName.Location = new System.Drawing.Point(602, 127);
            this.txtAddDrugName.Name = "txtAddDrugName";
            this.txtAddDrugName.Size = new System.Drawing.Size(100, 20);
            this.txtAddDrugName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "DrugName";
            // 
            // txtAddDrugPrice
            // 
            this.txtAddDrugPrice.Location = new System.Drawing.Point(602, 153);
            this.txtAddDrugPrice.Name = "txtAddDrugPrice";
            this.txtAddDrugPrice.Size = new System.Drawing.Size(100, 20);
            this.txtAddDrugPrice.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price";
            // 
            // SuppAdd
            // 
            this.SuppAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppAdd.Location = new System.Drawing.Point(602, 179);
            this.SuppAdd.Name = "SuppAdd";
            this.SuppAdd.Size = new System.Drawing.Size(95, 34);
            this.SuppAdd.TabIndex = 15;
            this.SuppAdd.Text = "Add";
            this.SuppAdd.UseVisualStyleBackColor = true;
            this.SuppAdd.Click += new System.EventHandler(this.SuppAdd_Click);
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(325, 140);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(100, 20);
            this.txtSupName.TabIndex = 18;
            // 
            // button2SupSearch
            // 
            this.button2SupSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2SupSearch.Location = new System.Drawing.Point(325, 166);
            this.button2SupSearch.Name = "button2SupSearch";
            this.button2SupSearch.Size = new System.Drawing.Size(95, 34);
            this.button2SupSearch.TabIndex = 17;
            this.button2SupSearch.Text = "Search Suppliers";
            this.button2SupSearch.UseVisualStyleBackColor = true;
            this.button2SupSearch.Click += new System.EventHandler(this.button2SupSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "SupplierName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(774, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "NameUpdate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(774, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "AddressUpdate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(774, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "ContactUpdate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(774, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "DrugNameUpdate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(774, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "PriceUpdate";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(905, 79);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateName.TabIndex = 24;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(905, 106);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAddress.TabIndex = 25;
            // 
            // txtUpdateContact
            // 
            this.txtUpdateContact.Location = new System.Drawing.Point(905, 132);
            this.txtUpdateContact.Name = "txtUpdateContact";
            this.txtUpdateContact.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateContact.TabIndex = 26;
            // 
            // txtUpdateDrugName
            // 
            this.txtUpdateDrugName.Location = new System.Drawing.Point(905, 157);
            this.txtUpdateDrugName.Name = "txtUpdateDrugName";
            this.txtUpdateDrugName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateDrugName.TabIndex = 27;
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(905, 182);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePrice.TabIndex = 28;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(905, 208);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 34);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(774, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "ID";
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(905, 51);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateID.TabIndex = 31;
            // 
            // textBoxDeleteID
            // 
            this.textBoxDeleteID.Location = new System.Drawing.Point(905, 278);
            this.textBoxDeleteID.Name = "textBoxDeleteID";
            this.textBoxDeleteID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeleteID.TabIndex = 34;
            // 
            // button1Delete
            // 
            this.button1Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Delete.Location = new System.Drawing.Point(905, 304);
            this.button1Delete.Name = "button1Delete";
            this.button1Delete.Size = new System.Drawing.Size(95, 34);
            this.button1Delete.TabIndex = 33;
            this.button1Delete.Text = "Delete";
            this.button1Delete.UseVisualStyleBackColor = true;
            this.button1Delete.Click += new System.EventHandler(this.button1Delete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(827, 278);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "SupplierID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 497);
            this.Controls.Add(this.textBoxDeleteID);
            this.Controls.Add(this.button1Delete);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtUpdateID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUpdatePrice);
            this.Controls.Add(this.txtUpdateDrugName);
            this.Controls.Add(this.txtUpdateContact);
            this.Controls.Add(this.txtUpdateAddress);
            this.Controls.Add(this.txtUpdateName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.button2SupSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SuppAdd);
            this.Controls.Add(this.txtAddDrugPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddDrugName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddSupContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddSupAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddSupName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Searchbutton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.btnAllSuppliers);
            this.Name = "Form1";
            this.Text = "Supplier Checker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllSuppliers;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Searchbutton1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAddSupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddSupAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddSupContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddDrugName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddDrugPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SuppAdd;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Button button2SupSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.TextBox txtUpdateContact;
        private System.Windows.Forms.TextBox txtUpdateDrugName;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.TextBox textBoxDeleteID;
        private System.Windows.Forms.Button button1Delete;
        private System.Windows.Forms.Label label14;
    }
}

