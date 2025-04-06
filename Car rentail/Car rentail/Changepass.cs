using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using Microsoft.VisualBasic;


namespace Car_rentail
{
    public partial class Changepass : Form
    {
        SqlConnection conn = new SqlConnection(Connect.constr);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();


        public Changepass()
        {
            InitializeComponent();
        }

        private void btnconform_Click(object sender, EventArgs e)
        {
            if (txtCurrentpassword.Text == string.Empty || txtNewpassword.Text == string.Empty || txtconfirmpassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter all the details");

            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select *from info where pass='" + txtCurrentpassword.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Current Password is Not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("changepass", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("currentpassword", txtCurrentpassword.Text);
                    cmd.Parameters.Add("newpassword", txtNewpassword.Text);
                    cmd.Parameters.Add("opr", "upd");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Update successfully..!", "Upadet", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtconfirmpassword.Text = "";
                    txtCurrentpassword.Text = "";
                    txtNewpassword.Text = "";

                    conn.Close();

                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtCurrentpassword.Clear();
            txtNewpassword.Clear();
            txtconfirmpassword.Clear();
            showcheckbox.Checked = false;
        }

        private void Changepass_Load(object sender, EventArgs e)
        {

        }

        private void txtCurrentpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showcheckbox.Checked)
            {

                txtNewpassword.UseSystemPasswordChar = false;
                txtconfirmpassword.UseSystemPasswordChar = false;
                txtCurrentpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewpassword.UseSystemPasswordChar = true;
                txtconfirmpassword.UseSystemPasswordChar = true;
                txtCurrentpassword.UseSystemPasswordChar = true;

            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            emailcode E= new emailcode();
            E.Show();
        }
    }
}
