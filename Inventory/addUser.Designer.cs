namespace _Inventory
{
    partial class addUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.ext = new System.Windows.Forms.TextBox();
            this.hostName = new System.Windows.Forms.TextBox();
            this.pcTag = new System.Windows.Forms.TextBox();
            this.ram = new System.Windows.Forms.TextBox();
            this.hdd = new System.Windows.Forms.TextBox();
            this.inventoryID = new System.Windows.Forms.TextBox();
            this.os = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pCManBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iREM_InventoryDataSet1 = new _Inventory._InventoryDataSet1();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pCManTableAdapter = new _Inventory._InventoryDataSet1TableAdapters.PCManTableAdapter();
            this.pCManBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iREM_InventoryDataSet2 = new _Inventory._InventoryDataSet2();
            this.pCManBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pCManTableAdapter1 = new _Inventory._InventoryDataSet2TableAdapters.PCManTableAdapter();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pCManBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iREM_InventoryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCManBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iREM_InventoryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCManBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ext.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "HostName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Service Tag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "RAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "HDD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "OS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "InventoryID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Year";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(75, 6);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(100, 20);
            this.fname.TabIndex = 11;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(75, 34);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(100, 20);
            this.lname.TabIndex = 12;
            // 
            // ext
            // 
            this.ext.Location = new System.Drawing.Point(75, 60);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(100, 20);
            this.ext.TabIndex = 13;
            // 
            // hostName
            // 
            this.hostName.Location = new System.Drawing.Point(75, 85);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(100, 20);
            this.hostName.TabIndex = 14;
            // 
            // pcTag
            // 
            this.pcTag.Location = new System.Drawing.Point(75, 108);
            this.pcTag.Name = "pcTag";
            this.pcTag.Size = new System.Drawing.Size(100, 20);
            this.pcTag.TabIndex = 15;
            // 
            // ram
            // 
            this.ram.Location = new System.Drawing.Point(75, 132);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(100, 20);
            this.ram.TabIndex = 16;
            // 
            // hdd
            // 
            this.hdd.Location = new System.Drawing.Point(249, 6);
            this.hdd.Name = "hdd";
            this.hdd.Size = new System.Drawing.Size(100, 20);
            this.hdd.TabIndex = 17;
            // 
            // inventoryID
            // 
            this.inventoryID.Location = new System.Drawing.Point(249, 78);
            this.inventoryID.Name = "inventoryID";
            this.inventoryID.Size = new System.Drawing.Size(100, 20);
            this.inventoryID.TabIndex = 20;
            // 
            // os
            // 
            this.os.Location = new System.Drawing.Point(249, 30);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(100, 20);
            this.os.TabIndex = 18;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(249, 52);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 20);
            this.type.TabIndex = 19;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(249, 105);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(411, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pCManBindingSource
            // 
            this.pCManBindingSource.DataMember = "PCMan";
            this.pCManBindingSource.DataSource = this.iREM_InventoryDataSet1;
            // 
            // iREM_InventoryDataSet1
            // 
            this.iREM_InventoryDataSet1.DataSetName = "_InventoryDataSet1";
            this.iREM_InventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(411, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(411, 87);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 25;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Brand";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(370, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Model";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(370, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Make";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(538, 28);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 26;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(538, 59);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 27;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(538, 88);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(435, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Manufacture";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(571, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Processor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pCManTableAdapter
            // 
            this.pCManTableAdapter.ClearBeforeFill = true;
            // 
            // pCManBindingSource1
            // 
            this.pCManBindingSource1.DataMember = "PCMan";
            this.pCManBindingSource1.DataSource = this.iREM_InventoryDataSet1;
            // 
            // iREM_InventoryDataSet2
            // 
            this.iREM_InventoryDataSet2.DataSetName = "_InventoryDataSet2";
            this.iREM_InventoryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pCManBindingSource2
            // 
            this.pCManBindingSource2.DataMember = "PCMan";
            this.pCManBindingSource2.DataSource = this.iREM_InventoryDataSet2;
            // 
            // pCManTableAdapter1
            // 
            this.pCManTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "32 bit",
            "64 bit"});
            this.comboBox7.Location = new System.Drawing.Point(249, 131);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(100, 21);
            this.comboBox7.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(181, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Arch.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 158);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Dual Monitors";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 181);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 78;
            this.checkBox2.Text = "Has Printer";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 237);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.type);
            this.Controls.Add(this.os);
            this.Controls.Add(this.inventoryID);
            this.Controls.Add(this.hdd);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.pcTag);
            this.Controls.Add(this.hostName);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addUser";
            this.Text = "addUser";
            this.Load += new System.EventHandler(this.addUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCManBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iREM_InventoryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCManBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iREM_InventoryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCManBindingSource2)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox ext;
        private System.Windows.Forms.TextBox hostName;
        private System.Windows.Forms.TextBox pcTag;
        private System.Windows.Forms.TextBox ram;
        private System.Windows.Forms.TextBox hdd;
        private System.Windows.Forms.TextBox inventoryID;
        private System.Windows.Forms.TextBox os;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private _InventoryDataSet1 iREM_InventoryDataSet1;
        private System.Windows.Forms.BindingSource pCManBindingSource;
        private _InventoryDataSet1TableAdapters.PCManTableAdapter pCManTableAdapter;
        private System.Windows.Forms.BindingSource pCManBindingSource1;
        private _InventoryDataSet2 iREM_InventoryDataSet2;
        private System.Windows.Forms.BindingSource pCManBindingSource2;
        private _InventoryDataSet2TableAdapters.PCManTableAdapter pCManTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}