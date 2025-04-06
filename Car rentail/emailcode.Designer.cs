
namespace Car_rentail
{
    partial class emailcode
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
            this.conpasstext = new System.Windows.Forms.Label();
            this.btnverify = new System.Windows.Forms.Button();
            this.nptext = new System.Windows.Forms.Label();
            this.btnconform = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.showcheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttop = new System.Windows.Forms.TextBox();
            this.btnotp = new System.Windows.Forms.Button();
            this.txtemailbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnminimize = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conpasstext
            // 
            this.conpasstext.AutoSize = true;
            this.conpasstext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conpasstext.ForeColor = System.Drawing.Color.White;
            this.conpasstext.Location = new System.Drawing.Point(456, 359);
            this.conpasstext.Name = "conpasstext";
            this.conpasstext.Size = new System.Drawing.Size(187, 25);
            this.conpasstext.TabIndex = 11;
            this.conpasstext.Text = "Confirm Password";
            // 
            // btnverify
            // 
            this.btnverify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnverify.FlatAppearance.BorderSize = 0;
            this.btnverify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnverify.ForeColor = System.Drawing.Color.Black;
            this.btnverify.Location = new System.Drawing.Point(800, 558);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(199, 52);
            this.btnverify.TabIndex = 28;
            this.btnverify.Text = "CONFIRM";
            this.btnverify.UseVisualStyleBackColor = true;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click_1);
            // 
            // nptext
            // 
            this.nptext.AutoSize = true;
            this.nptext.BackColor = System.Drawing.Color.Transparent;
            this.nptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nptext.ForeColor = System.Drawing.Color.White;
            this.nptext.Location = new System.Drawing.Point(456, 149);
            this.nptext.Name = "nptext";
            this.nptext.Size = new System.Drawing.Size(65, 25);
            this.nptext.TabIndex = 9;
            this.nptext.Text = "Email";
            // 
            // btnconform
            // 
            this.btnconform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnconform.FlatAppearance.BorderSize = 0;
            this.btnconform.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnconform.ForeColor = System.Drawing.Color.Black;
            this.btnconform.Location = new System.Drawing.Point(282, 558);
            this.btnconform.Name = "btnconform";
            this.btnconform.Size = new System.Drawing.Size(213, 52);
            this.btnconform.TabIndex = 8;
            this.btnconform.Text = "SEND CODE";
            this.btnconform.UseVisualStyleBackColor = true;
            this.btnconform.Click += new System.EventHandler(this.btnconform_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnlogout);
            this.groupBox1.Controls.Add(this.txtconfirmpassword);
            this.groupBox1.Controls.Add(this.showcheckbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttop);
            this.groupBox1.Controls.Add(this.btnotp);
            this.groupBox1.Controls.Add(this.txtemailbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnverify);
            this.groupBox1.Controls.Add(this.conpasstext);
            this.groupBox1.Controls.Add(this.nptext);
            this.groupBox1.Controls.Add(this.btnconform);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(94, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1375, 749);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlogout.BackColor = System.Drawing.Color.Black;
            this.btnlogout.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(738, -53);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(157, 50);
            this.btnlogout.TabIndex = 70;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.BackColor = System.Drawing.Color.Silver;
            this.txtconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtconfirmpassword.Location = new System.Drawing.Point(461, 391);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(337, 41);
            this.txtconfirmpassword.TabIndex = 71;
            this.txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // showcheckbox
            // 
            this.showcheckbox.AutoSize = true;
            this.showcheckbox.Location = new System.Drawing.Point(461, 446);
            this.showcheckbox.Name = "showcheckbox";
            this.showcheckbox.Size = new System.Drawing.Size(192, 29);
            this.showcheckbox.TabIndex = 70;
            this.showcheckbox.Text = "Show Password";
            this.showcheckbox.UseVisualStyleBackColor = true;
            this.showcheckbox.CheckedChanged += new System.EventHandler(this.showcheckbox_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(460, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Otp";
            // 
            // txttop
            // 
            this.txttop.BackColor = System.Drawing.Color.Silver;
            this.txttop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.txttop.Location = new System.Drawing.Point(461, 286);
            this.txttop.Multiline = true;
            this.txttop.Name = "txttop";
            this.txttop.Size = new System.Drawing.Size(337, 41);
            this.txttop.TabIndex = 68;
            // 
            // btnotp
            // 
            this.btnotp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnotp.FlatAppearance.BorderSize = 0;
            this.btnotp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnotp.ForeColor = System.Drawing.Color.Black;
            this.btnotp.Location = new System.Drawing.Point(510, 558);
            this.btnotp.Name = "btnotp";
            this.btnotp.Size = new System.Drawing.Size(271, 52);
            this.btnotp.TabIndex = 67;
            this.btnotp.Text = "VERIFY CODE";
            this.btnotp.UseVisualStyleBackColor = true;
            this.btnotp.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtemailbox
            // 
            this.txtemailbox.BackColor = System.Drawing.Color.Silver;
            this.txtemailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.txtemailbox.Location = new System.Drawing.Point(461, 179);
            this.txtemailbox.Multiline = true;
            this.txtemailbox.Name = "txtemailbox";
            this.txtemailbox.Size = new System.Drawing.Size(337, 41);
            this.txtemailbox.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(504, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 36);
            this.label1.TabIndex = 64;
            this.label1.Text = "Reset Password Via Email";
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = global::Car_rentail.Properties.Resources.Close;
            this.btnclose.Location = new System.Drawing.Point(1517, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(38, 33);
            this.btnclose.TabIndex = 64;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.BackColor = System.Drawing.Color.Transparent;
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Image = global::Car_rentail.Properties.Resources.minimize;
            this.btnminimize.Location = new System.Drawing.Point(1473, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(38, 33);
            this.btnminimize.TabIndex = 65;
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = global::Car_rentail.Properties.Resources.BACK;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backbtn.Location = new System.Drawing.Point(-2, -5);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(69, 67);
            this.backbtn.TabIndex = 63;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(73, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 39);
            this.button2.TabIndex = 71;
            this.button2.Text = "LOGOUT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // emailcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Car_rentail.Properties.Resources.wallhaven_eyxxxw_1920x1080;
            this.ClientSize = new System.Drawing.Size(1561, 750);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "emailcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emailcode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.emailcode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label conpasstext;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnverify;
        private System.Windows.Forms.Label nptext;
        private System.Windows.Forms.Button btnconform;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemailbox;
        private System.Windows.Forms.Button btnotp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttop;
        private System.Windows.Forms.CheckBox showcheckbox;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button button2;
    }
}