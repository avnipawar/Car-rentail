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
using System.IO;

namespace Car_rentail
{
    public partial class grid : Form
    {
        SqlConnection conn = new SqlConnection(Connect.constr);

        public grid()
        {
            InitializeComponent();
        }

        public void display()
        {
            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter("select CustId as ID,Custname as [Cust Name],Custaddress as [Cust Address],Custcity as [Cust City],Custpincode as [Cust Pincode]  from Custdetail", conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
               
                
                dataGridView1.DataSource = dt;
               }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void grid_Load(object sender, EventArgs e)
        {
            display();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) +dataGridView1.SelectedCells[dataGridView1.ColumnCount-2].Value.ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("custdetailSP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CustID", dataGridView1.SelectedCells[0].Value.ToString());
            cmd.Parameters.Add("opr", "del");
            cmd.ExecuteNonQuery();
            conn.Close();
            display();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup s = new Signup();
            s.Show();
        }
    }
}

