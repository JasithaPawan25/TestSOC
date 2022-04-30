namespace SupplierApplication
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2Update = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textJob = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.txtrichbox = new System.Windows.Forms.RichTextBox();
            this.button3IDSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtaddname = new System.Windows.Forms.TextBox();
            this.txtaddjob = new System.Windows.Forms.TextBox();
            this.button4Add = new System.Windows.Forms.Button();
            this.textBoxDeleteID = new System.Windows.Forms.TextBox();
            this.button2Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2Update
            // 
            this.button2Update.Location = new System.Drawing.Point(547, 42);
            this.button2Update.Name = "button2Update";
            this.button2Update.Size = new System.Drawing.Size(75, 23);
            this.button2Update.TabIndex = 1;
            this.button2Update.Text = "Update";
            this.button2Update.UseVisualStyleBackColor = true;
            this.button2Update.Click += new System.EventHandler(this.button2Update_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(386, 42);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 2;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(386, 68);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 3;
            // 
            // textJob
            // 
            this.textJob.Location = new System.Drawing.Point(386, 94);
            this.textJob.Name = "textJob";
            this.textJob.Size = new System.Drawing.Size(100, 20);
            this.textJob.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(386, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(386, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(566, 243);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(282, 198);
            this.dgvSupplier.TabIndex = 7;
            // 
            // txtrichbox
            // 
            this.txtrichbox.Location = new System.Drawing.Point(26, 226);
            this.txtrichbox.Name = "txtrichbox";
            this.txtrichbox.Size = new System.Drawing.Size(498, 242);
            this.txtrichbox.TabIndex = 8;
            this.txtrichbox.Text = "";
            // 
            // button3IDSearch
            // 
            this.button3IDSearch.Location = new System.Drawing.Point(194, 105);
            this.button3IDSearch.Name = "button3IDSearch";
            this.button3IDSearch.Size = new System.Drawing.Size(75, 23);
            this.button3IDSearch.TabIndex = 9;
            this.button3IDSearch.Text = "Search";
            this.button3IDSearch.UseVisualStyleBackColor = true;
            this.button3IDSearch.Click += new System.EventHandler(this.button3IDSearch_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(179, 79);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtaddname
            // 
            this.txtaddname.Location = new System.Drawing.Point(712, 94);
            this.txtaddname.Name = "txtaddname";
            this.txtaddname.Size = new System.Drawing.Size(100, 20);
            this.txtaddname.TabIndex = 11;
            // 
            // txtaddjob
            // 
            this.txtaddjob.Location = new System.Drawing.Point(712, 131);
            this.txtaddjob.Name = "txtaddjob";
            this.txtaddjob.Size = new System.Drawing.Size(100, 20);
            this.txtaddjob.TabIndex = 12;
            // 
            // button4Add
            // 
            this.button4Add.Location = new System.Drawing.Point(722, 168);
            this.button4Add.Name = "button4Add";
            this.button4Add.Size = new System.Drawing.Size(75, 23);
            this.button4Add.TabIndex = 13;
            this.button4Add.Text = "Add";
            this.button4Add.UseVisualStyleBackColor = true;
            this.button4Add.Click += new System.EventHandler(this.button4Add_Click);
            // 
            // textBoxDeleteID
            // 
            this.textBoxDeleteID.Location = new System.Drawing.Point(547, 146);
            this.textBoxDeleteID.Name = "textBoxDeleteID";
            this.textBoxDeleteID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeleteID.TabIndex = 14;
            // 
            // button2Delete
            // 
            this.button2Delete.Location = new System.Drawing.Point(556, 172);
            this.button2Delete.Name = "button2Delete";
            this.button2Delete.Size = new System.Drawing.Size(75, 23);
            this.button2Delete.TabIndex = 15;
            this.button2Delete.Text = "Delete";
            this.button2Delete.UseVisualStyleBackColor = true;
            this.button2Delete.Click += new System.EventHandler(this.button2Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 480);
            this.Controls.Add(this.button2Delete);
            this.Controls.Add(this.textBoxDeleteID);
            this.Controls.Add(this.button4Add);
            this.Controls.Add(this.txtaddjob);
            this.Controls.Add(this.txtaddname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button3IDSearch);
            this.Controls.Add(this.txtrichbox);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textJob);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.button2Update);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2Update;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textJob;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.RichTextBox txtrichbox;
        private System.Windows.Forms.Button button3IDSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtaddname;
        private System.Windows.Forms.TextBox txtaddjob;
        private System.Windows.Forms.Button button4Add;
        private System.Windows.Forms.TextBox textBoxDeleteID;
        private System.Windows.Forms.Button button2Delete;
    }
}

