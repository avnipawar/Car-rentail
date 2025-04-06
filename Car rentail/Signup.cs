using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Car_rentail
{
    public partial class Signup : Form
    {
        SqlConnection conn =new SqlConnection(Connect.constr);
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\JAVA PROJECT\Car rentail\Car rentail\Database1.mdf;Integrated Security=True");

        public Signup()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void visible_Click(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = false;
            visible.Visible = false;
            invisible.Visible = true;
        }

        private void invisible_Click(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = true;
            visible.Visible = true;
            invisible.Visible = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
         
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            try
            {
                
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("signupSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("email", email.Text);
                    cmd.Parameters.Add("unm", unm.Text);
                    cmd.Parameters.Add("pass", pass.Text);
                    cmd.Parameters.Add("opr", "ins");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
                
                if (unm.Text == string.Empty && pass.Text == string.Empty && email.Text==string.Empty)
                {
                    MessageBox.Show("Please enter email,username & password");
                }
                else if (email.Text == "")
                {
                    MessageBox.Show("Please enter email & password");
                }

                else if (unm.Text == "")
                {
                    MessageBox.Show("Please enter username & password");
                }
                else if (pass.Text == "")
                {
                    MessageBox.Show("Please enter password & username");
                }
                
                    else
                    {

                        MessageBox.Show("signup Successfull",
                       "Employee", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                        Form1 form = new Form1();
                        form.Show();
           
                    }
                }
            
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 c = new Form1();
            c.Show();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            email.Clear();
            unm.Clear();
            pass.Clear();
        }

        private void email_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is a letter or control character (like backspace)
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
            }//if (!char.IsControl(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
             //e.Handled = true;
        }


        private void unm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is a letter or control character (like backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
            }//if (!char.IsControl(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
             //e.Handled = true;
        }

        private void btnminimize_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Leave(object sender, EventArgs e)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email.Text, pattern))
            {
                btnsignup.Enabled = false;
                MessageBox.Show("Invalid email address");
            }
            else
                btnsignup.Enabled = true;
           
         
        }
    }
}
