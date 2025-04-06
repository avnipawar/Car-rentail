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
    public partial class custgrid : Form
    {
        SqlConnection conn = new SqlConnection(Connect.constr);
        public custgrid()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void custgrid_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter("select custiD as [ID],Custname as [Customer Name],Custaddress as [Address] from custdetail", conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
