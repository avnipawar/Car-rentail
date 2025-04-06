namespace Car_rentail
{
    partial class Changepass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showcheckbox = new System.Windows.Forms.CheckBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.conpasstext = new System.Windows.Forms.Label();
            this.txtNewpassword = new System.Windows.Forms.TextBox();
            this.nptext = new System.Windows.Forms.Label();
            this.btnconform = new System.Windows.Forms.Button();
            this.txtCurrentpassword = new System.Windows.Forms.TextBox();
            this.cptext = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.invisible = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.showcheckbox);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.txtconfirmpassword);
            this.groupBox1.Controls.Add(this.conpasstext);
            this.groupBox1.Controls.Add(this.txtNewpassword);
            this.groupBox1.Controls.Add(this.nptext);
            this.groupBox1.Controls.Add(this.btnconform);
            this.groupBox1.Controls.Add(this.txtCurrentpassword);
            this.groupBox1.Controls.Add(this.cptext);
            this.groupBox1.Controls.Add(this.invisible);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(116, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1375, 749);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // showcheckbox
            // 
            this.showcheckbox.AutoSize = true;
            this.showcheckbox.Location = new System.Drawing.Point(464, 547);
            this.showcheckbox.Name = "showcheckbox";
            this.showcheckbox.Size = new System.Drawing.Size(192, 29);
            this.showcheckbox.TabIndex = 29;
            this.showcheckbox.Text = "Show Password";
            this.showcheckbox.UseVisualStyleBackColor = true;
            this.showcheckbox.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // btnclear
            // 
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Location = new System.Drawing.Point(695, 644);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(199, 52);
            this.btnclear.TabIndex = 28;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.BackColor = System.Drawing.Color.Silver;
            this.txtconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtconfirmpassword.Location = new System.Drawing.Point(463, 459);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(337, 41);
            this.txtconfirmpassword.TabIndex = 12;
            this.txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // conpasstext
            // 
            this.conpasstext.AutoSize = true;
            this.conpasstext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conpasstext.ForeColor = System.Drawing.Color.White;
            this.conpasstext.Location = new System.Drawing.Point(458, 418);
            this.conpasstext.Name = "conpasstext";
            this.conpasstext.Size = new System.Drawing.Size(187, 25);
            this.conpasstext.TabIndex = 11;
            this.conpasstext.Text = "Confirm Password";
            // 
            // txtNewpassword
            // 
            this.txtNewpassword.BackColor = System.Drawing.Color.Silver;
            this.txtNewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNewpassword.Location = new System.Drawing.Point(460, 331);
            this.txtNewpassword.Name = "txtNewpassword";
            this.txtNewpassword.Size = new System.Drawing.Size(337, 41);
            this.txtNewpassword.TabIndex = 10;
            this.txtNewpassword.UseSystemPasswordChar = true;
            // 
            // nptext
            // 
            this.nptext.AutoSize = true;
            this.nptext.BackColor = System.Drawing.Color.Transparent;
            this.nptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nptext.ForeColor = System.Drawing.Color.White;
            this.nptext.Location = new System.Drawing.Point(455, 290);
            this.nptext.Name = "nptext";
            this.nptext.Size = new System.Drawing.Size(154, 25);
            this.nptext.TabIndex = 9;
            this.nptext.Text = "New Password";
            // 
            // btnconform
            // 
            this.btnconform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnconform.FlatAppearance.BorderSize = 0;
            this.btnconform.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnconform.ForeColor = System.Drawing.Color.Black;
            this.btnconform.Location = new System.Drawing.Point(436, 644);
            this.btnconform.Name = "btnconform";
            this.btnconform.Size = new System.Drawing.Size(213, 52);
            this.btnconform.TabIndex = 8;
            this.btnconform.Text = "CONFIRM";
            this.btnconform.UseVisualStyleBackColor = true;
            this.btnconform.Click += new System.EventHandler(this.btnconform_Click);
            // 
            // txtCurrentpassword
            // 
            this.txtCurrentpassword.BackColor = System.Drawing.Color.Silver;
            this.txtCurrentpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCurrentpassword.Location = new System.Drawing.Point(462, 203);
            this.txtCurrentpassword.Name = "txtCurrentpassword";
            this.txtCurrentpassword.Size = new System.Drawing.Size(337, 41);
            this.txtCurrentpassword.TabIndex = 7;
            this.txtCurrentpassword.UseSystemPasswordChar = true;
            this.txtCurrentpassword.TextChanged += new System.EventHandler(this.txtCurrentpassword_TextChanged);
            // 
            // cptext
            // 
            this.cptext.AutoSize = true;
            this.cptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cptext.ForeColor = System.Drawing.Color.White;
            this.cptext.Location = new System.Drawing.Point(457, 157);
            this.cptext.Name = "cptext";
            this.cptext.Size = new System.Drawing.Size(184, 25);
            this.cptext.TabIndex = 6;
            this.cptext.Text = "Current Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(426, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 43);
            this.button1.TabIndex = 63;
            this.button1.Text = "Forgottrn Current Password?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = global::Car_rentail.Properties.Resources.BACK;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backbtn.Location = new System.Drawing.Point(0, -11);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(69, 67);
            this.backbtn.TabIndex = 30;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.BackColor = System.Drawing.Color.Transparent;
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Image = global::Car_rentail.Properties.Resources.minimize;
            this.btnminimize.Location = new System.Drawing.Point(1494, 6);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(38, 33);
            this.btnminimize.TabIndex = 61;
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = global::Car_rentail.Properties.Resources.Close;
            this.btnclose.Location = new System.Drawing.Point(1538, 6);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(38, 33);
            this.btnclose.TabIndex = 60;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // invisible
            // 
            this.invisible.BackColor = System.Drawing.Color.Silver;
            this.invisible.BackgroundImage = global::Car_rentail.Properties.Resources.Invisible;
            this.invisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.invisible.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.invisible.FlatAppearance.BorderSize = 0;
            this.invisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            this.invisible.Location = new System.Drawing.Point(656, 458);
            this.invisible.Name = "invisible";
            this.invisible.Size = new System.Drawing.Size(54, 36);
            this.invisible.TabIndex = 25;
            this.invisible.UseVisualStyleBackColor = false;
            // 
            // Changepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1583, 806);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Changepass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changepass";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Changepass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNewpassword;
        private System.Windows.Forms.Label nptext;
        private System.Windows.Forms.Button btnconform;
        private System.Windows.Forms.TextBox txtCurrentpassword;
        private System.Windows.Forms.Label cptext;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label conpasstext;
        private System.Windows.Forms.Button invisible;
        private System.Windows.Forms.CheckBox showcheckbox;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button button1;
    }
}