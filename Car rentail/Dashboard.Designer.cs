namespace Car_rentail
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlmain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.keybtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnbooklist = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "black_porsche_911_st_2023_car_4k_5k_hd_cars.jpg");
            this.imageList1.Images.SetKeyName(1, "wallhaven-0p95xm_1920x1080.png");
            this.imageList1.Images.SetKeyName(2, "wallhaven-4dpz63_1920x1080.png");
            this.imageList1.Images.SetKeyName(3, "wallhaven-4lzrqp_1920x1080.png");
            this.imageList1.Images.SetKeyName(4, "wallhaven-49d68x.jpg");
            this.imageList1.Images.SetKeyName(5, "wallhaven-ney1pw_1920x1080.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // pnlmain
            // 
            this.pnlmain.BackColor = System.Drawing.Color.Black;
            this.pnlmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlmain.Controls.Add(this.button2);
            this.pnlmain.Controls.Add(this.button1);
            this.pnlmain.Controls.Add(this.keybtn);
            this.pnlmain.Controls.Add(this.backbtn);
            this.pnlmain.Controls.Add(this.btnhome);
            this.pnlmain.Controls.Add(this.pictureBox1);
            this.pnlmain.Controls.Add(this.btnminimize);
            this.pnlmain.Controls.Add(this.btnbooklist);
            this.pnlmain.Controls.Add(this.btnbook);
            this.pnlmain.Controls.Add(this.btnclose);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(0, 0);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1615, 837);
            this.pnlmain.TabIndex = 26;
            this.pnlmain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlmain_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Car_rentail.Properties.Resources.Add_User_Male1;
            this.button1.Location = new System.Drawing.Point(318, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 200);
            this.button1.TabIndex = 28;
            this.button1.Text = "CUSTOMER BOOKING";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // keybtn
            // 
            this.keybtn.BackColor = System.Drawing.Color.Transparent;
            this.keybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.keybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keybtn.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keybtn.ForeColor = System.Drawing.Color.White;
            this.keybtn.Image = global::Car_rentail.Properties.Resources.Key;
            this.keybtn.Location = new System.Drawing.Point(445, 637);
            this.keybtn.Name = "keybtn";
            this.keybtn.Size = new System.Drawing.Size(200, 200);
            this.keybtn.TabIndex = 27;
            this.keybtn.Text = "CHANGE PASSWORD";
            this.keybtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.keybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.keybtn.UseVisualStyleBackColor = false;
            this.keybtn.Click += new System.EventHandler(this.keybtn_Click_1);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = global::Car_rentail.Properties.Resources.BACK;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backbtn.Location = new System.Drawing.Point(12, -6);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(82, 72);
            this.backbtn.TabIndex = 25;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Image = global::Car_rentail.Properties.Resources.Gmail_Login;
            this.btnhome.Location = new System.Drawing.Point(193, 182);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(200, 200);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "LOGIN PAGE";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnhome.UseCompatibleTextRendering = true;
            this.btnhome.UseMnemonic = false;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Car_rentail.Properties.Resources.Corvette_CINEMATIC_Car_Commercial_I_Blender_1080p___1_;
            this.pictureBox1.Location = new System.Drawing.Point(718, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnminimize
            // 
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.BackColor = System.Drawing.Color.Transparent;
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Image = global::Car_rentail.Properties.Resources.minimize;
            this.btnminimize.Location = new System.Drawing.Point(1515, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(38, 33);
            this.btnminimize.TabIndex = 22;
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnbooklist
            // 
            this.btnbooklist.BackColor = System.Drawing.Color.Transparent;
            this.btnbooklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnbooklist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbooklist.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooklist.ForeColor = System.Drawing.Color.White;
            this.btnbooklist.Image = global::Car_rentail.Properties.Resources.List2;
            this.btnbooklist.Location = new System.Drawing.Point(445, 182);
            this.btnbooklist.Name = "btnbooklist";
            this.btnbooklist.Size = new System.Drawing.Size(200, 200);
            this.btnbooklist.TabIndex = 4;
            this.btnbooklist.Text = "CUSTOMER DETAIL ";
            this.btnbooklist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbooklist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnbooklist.UseCompatibleTextRendering = true;
            this.btnbooklist.UseMnemonic = false;
            this.btnbooklist.UseVisualStyleBackColor = false;
            this.btnbooklist.Click += new System.EventHandler(this.btnbooklist_Click);
            // 
            // btnbook
            // 
            this.btnbook.BackColor = System.Drawing.Color.Transparent;
            this.btnbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbook.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbook.ForeColor = System.Drawing.Color.White;
            this.btnbook.Image = global::Car_rentail.Properties.Resources.Booking3;
            this.btnbook.Location = new System.Drawing.Point(193, 637);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(200, 200);
            this.btnbook.TabIndex = 3;
            this.btnbook.Text = "CAR BOOKING";
            this.btnbook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnbook.UseVisualStyleBackColor = false;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = global::Car_rentail.Properties.Resources.Close;
            this.btnclose.Location = new System.Drawing.Point(1556, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(38, 33);
            this.btnclose.TabIndex = 21;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(94, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 39);
            this.button2.TabIndex = 72;
            this.button2.Text = "LOGOUT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1615, 837);
            this.Controls.Add(this.pnlmain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnbooklist;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button keybtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}