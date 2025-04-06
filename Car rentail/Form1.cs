using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Car_rentail
{
    public partial class Form1 : Form
    {
        SqlConnection conn =new SqlConnection(Connect.constr);
       // SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\JAVA PROJECT\Car rentail\Car rentail\Database1.mdf;Integrated Security=True");
        
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnlog_Click(object sender, EventArgs e)
        {

            try
            {
                if (unm.Text == string.Empty && pass.Text == string.Empty)
                {
                    MessageBox.Show("Please enter password and username");
                }

                else if (pass.Text == "")
                {
                    MessageBox.Show("Please enter password");
                }
                else if (unm.Text == "")
                {
                    MessageBox.Show("Please enter username");
                }

                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from info where unm='" + unm.Text + "' and pass='" + pass.Text + "'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count <= 0)//dt.Rows.Count > 0 ||
                    {
                        MessageBox.Show("Username not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Connect.unm = unm.Text;       
                        MessageBox.Show("Login Successfull", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Dashboard d = new Dashboard();
                        d.Show();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
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
        private void unm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is a letter or control character (like backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
            }//if (!char.IsControl(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                //e.Handled = true;
        }
        private void labelFP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 c = new Form1();
            c.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            emailcode c = new emailcode();
            c.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup c = new Signup();
            c.Show();
        }
        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}