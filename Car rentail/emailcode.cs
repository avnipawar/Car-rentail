using System;
//using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_rentail
{
    public partial class emailcode : Form
    {
        SqlConnection conn = new SqlConnection(Connect.constr);
        SqlCommand cmd = new SqlCommand();
        static int randomcode;
        SqlDataReader reader;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        static string to;
        public emailcode()
        {
            InitializeComponent();
        }



        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();

        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnconform_Click(object sender, EventArgs e)
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from info where email='"+txtemailbox.Text+"'",conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Random rand = new Random();
                    randomcode = rand.Next(999999);
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    message.From = new MailAddress("jyotiodedra77@gmail.com");
                    message.To.Add(new MailAddress(txtemailbox.Text));
                    message.Subject = "Password Reset Code";
                    message.IsBodyHtml = true; //to make message body as html
                    message.Body = $"Your Reset code is {randomcode}";
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com"; //for gmail host
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("jyotiodedra77@gmail.com", "vkby qxko tfdh hiez");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                    MessageBox.Show("Code successfully Send");

                }
                else
                {
                    MessageBox.Show("Email not registered");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Changepass ch = new Changepass();
            ch.Show();
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            if (randomcode.ToString() == (txtconfirmpassword.Text).ToString())
            {
                to = txtemailbox.Text;
                emailcode em = new emailcode();
                this.Hide();
                em.Show();

            }
            else
            {
                MessageBox.Show("Wronge code");
            }
        }

        private void invisible_Click(object sender, EventArgs e)
        {

        }

        private void showcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnverify_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("changepass", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("confirmpassword", txtconfirmpassword.Text);
            cmd.Parameters.Add("opr", "reset");
            cmd.Parameters.Add("email", txtemailbox.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Password Update successfully..!", "Upadet", MessageBoxButtons.OK, MessageBoxIcon.Question);
            txtconfirmpassword.Text = "";


            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (randomcode.ToString() == txttop.Text)
            {
                MessageBox.Show("Message verified");
            }
        }

        private void showcheckbox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showcheckbox.Checked)
            {
                txtconfirmpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtconfirmpassword.UseSystemPasswordChar = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void emailcode_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Signup s = new Signup();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup s = new Signup();
            s.Show();
        }
    }
}
