namespace Car_rentail
{
    partial class cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cars));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modelcombobox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.txtmodelnm = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.txtActualprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtRentalFee = new System.Windows.Forms.TextBox();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"JPG files (*.jpg)|*.jpg| \"PNG files (*.png)|*.png| \"JPG files (*.jpeg)|*.jpg|All" +
    " files (*.*)|*.*\"";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = global::Car_rentail.Properties.Resources.BACK;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backbtn.Location = new System.Drawing.Point(15, -7);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(67, 58);
            this.backbtn.TabIndex = 26;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.modelcombobox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxBrand);
            this.panel1.Controls.Add(this.txtmodelnm);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.txtActualprice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.img);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPurchaseDate);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.txtRentalFee);
            this.panel1.Controls.Add(this.txtCarNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 645);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 388);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 183);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // modelcombobox
            // 
            this.modelcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelcombobox.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.modelcombobox.FormattingEnabled = true;
            this.modelcombobox.Location = new System.Drawing.Point(322, 194);
            this.modelcombobox.Name = "modelcombobox";
            this.modelcombobox.Size = new System.Drawing.Size(266, 43);
            this.modelcombobox.TabIndex = 55;
            this.modelcombobox.SelectedIndexChanged += new System.EventHandler(this.modelcombobox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "INSERT",
            "UPDATE"});
            this.comboBox1.Location = new System.Drawing.Point(323, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 43);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 35);
            this.label1.TabIndex = 33;
            this.label1.Text = "OPERATIONS";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(323, 139);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(266, 43);
            this.comboBoxBrand.TabIndex = 53;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // txtmodelnm
            // 
            this.txtmodelnm.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.txtmodelnm.Location = new System.Drawing.Point(322, 194);
            this.txtmodelnm.Margin = new System.Windows.Forms.Padding(1);
            this.txtmodelnm.Name = "txtmodelnm";
            this.txtmodelnm.Size = new System.Drawing.Size(266, 44);
            this.txtmodelnm.TabIndex = 51;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Chocolate;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(620, 591);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(1);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(108, 37);
            this.btnupdate.TabIndex = 50;
            this.btnupdate.Text = "&Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(465, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 57);
            this.label6.TabIndex = 48;
            this.label6.Text = "Cars Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 43);
            this.label9.TabIndex = 46;
            this.label9.Text = "Brand Name";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Chocolate;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(756, 591);
            this.Delete.Margin = new System.Windows.Forms.Padding(1);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(109, 37);
            this.Delete.TabIndex = 45;
            this.Delete.Text = "&Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // txtActualprice
            // 
            this.txtActualprice.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.txtActualprice.Location = new System.Drawing.Point(826, 79);
            this.txtActualprice.Margin = new System.Windows.Forms.Padding(1);
            this.txtActualprice.Name = "txtActualprice";
            this.txtActualprice.Size = new System.Drawing.Size(347, 44);
            this.txtActualprice.TabIndex = 43;
            this.txtActualprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActualprice_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(590, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 43);
            this.label8.TabIndex = 44;
            this.label8.Text = "Actual price";
            // 
            // img
            // 
            this.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(826, 189);
            this.img.Margin = new System.Windows.Forms.Padding(2);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(347, 166);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 42;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.img_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(590, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 43);
            this.label7.TabIndex = 41;
            this.label7.Text = "Image";
            // 
            // txtPurchaseDate
            // 
            this.txtPurchaseDate.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.txtPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtPurchaseDate.Location = new System.Drawing.Point(322, 310);
            this.txtPurchaseDate.Margin = new System.Windows.Forms.Padding(1);
            this.txtPurchaseDate.Name = "txtPurchaseDate";
            this.txtPurchaseDate.Size = new System.Drawing.Size(266, 44);
            this.txtPurchaseDate.TabIndex = 40;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Chocolate;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(495, 591);
            this.btnadd.Margin = new System.Windows.Forms.Padding(1);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 37);
            this.btnadd.TabIndex = 39;
            this.btnadd.Text = "&Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // txtRentalFee
            // 
            this.txtRentalFee.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.txtRentalFee.Location = new System.Drawing.Point(826, 134);
            this.txtRentalFee.Margin = new System.Windows.Forms.Padding(1);
            this.txtRentalFee.Name = "txtRentalFee";
            this.txtRentalFee.Size = new System.Drawing.Size(347, 44);
            this.txtRentalFee.TabIndex = 37;
            this.txtRentalFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentalFee_KeyPress);
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.txtCarNumber.Location = new System.Drawing.Point(322, 252);
            this.txtCarNumber.Margin = new System.Windows.Forms.Padding(1);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(266, 44);
            this.txtCarNumber.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(590, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 43);
            this.label5.TabIndex = 35;
            this.label5.Text = "Rental Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 43);
            this.label4.TabIndex = 34;
            this.label4.Text = "Purchase Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 43);
            this.label3.TabIndex = 33;
            this.label3.Text = "Car Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 43);
            this.label2.TabIndex = 32;
            this.label2.Text = "Model Name";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Car_rentail.Properties.Resources.minimize;
            this.button2.Location = new System.Drawing.Point(1193, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 33);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Car_rentail.Properties.Resources.Close;
            this.button3.Location = new System.Drawing.Point(1237, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 33);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlogout.BackColor = System.Drawing.Color.Black;
            this.btnlogout.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(85, 4);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(144, 39);
            this.btnlogout.TabIndex = 70;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Car_rentail.Properties.Resources.wallhaven_eyxxxw_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 756);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backbtn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "cars";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cars_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox txtActualprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtPurchaseDate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtRentalFee;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtmodelnm;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox modelcombobox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlogout;
    }
}