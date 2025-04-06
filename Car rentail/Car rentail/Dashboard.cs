using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_rentail
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        int count = 0;

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 c = new Form1();
            c.Show();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            /*Signup c = new Signup();
            c.TopLevel = false;
            pnlmain.Controls.Add(c);
            c.Show();*/
            this.Hide();
            Signup c = new Signup();
            c.Show();
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            this.Hide();
            cars c = new cars();
           
           
            c.Show();

        }

        private void btnbooklist_Click(object sender, EventArgs e)
        {
            this.Hide();
            grid g = new grid();
            g.Show();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.Show();

        }

        private void keybtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Changepass pass = new Changepass();
            pass.Show();

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
           
                // Perform logout operations
                //Logout();

                // Show the login window
                Form1 f = new Form1();
                f.Show();

                // Close the current main window
                //this.Close();
        }

        private void Logout()
        {
                // Clear any user-specific data or reset the application state

                // Example: Resetting a static user object
               // Session.CurrentUser = null;

                // Clear any persistent credentials, tokens, etc.
        }
        private void keybtn_Click_1(object sender, EventArgs e)
        {
            Changepass ch = new Changepass();
            ch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            custdeatail c = new custdeatail();
            c.Show();
        }



        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (count < 5)
        //    {
        //        pictureBox2.Image = imageList1.Images[count];
        //        count++;
        //    }

        //    else
        //    {
        //        count = 0;
        //    }
        //}


    }
}
