using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Car_rentail
{
    public partial class custdeatail : Form
    {
        private Dictionary<string, List<string>> carData;
        SqlConnection conn = new SqlConnection(Connect.constr);
        int custid;
        public custdeatail()
        {
            InitializeComponent();
            // InitializeCarData();
            //BindBrandComboBox();
        }
        //private void InitializeCarData()
        //{
        //    carData = new Dictionary<string, List<string>>
        //    {
        //        { "BMW", new List<string> { "X5", "X3", "M3", "M4" } },
        //        { "Audi", new List<string> { "A4", "Q7", "A6", "A8" } },
        //        { "Jeep", new List<string> { "Wrangler", "Cherokee", "Grand Cherokee" } },
        //        { "Tesla", new List<string> { "Model S", "Model 3", "Model X", "Model Y" } },
        //        { "Jaguar", new List<string> { "F-PACE", "E-PACE", "XE", "XF" } },
        //        { "Rolls-Royce", new List<string> { "Phantom", "Ghost", "Wraith", "Cullinan" } },
        //        { "Kia", new List<string> { "Sorento", "Sportage", "Optima", "Seltos" } },
        //        { "Ford", new List<string> { "F-150", "Mustang", "Explorer", "Escape" } },
        //        { "Toyota", new List<string> { "Camry", "Corolla", "RAV4", "Highlander" } },
        //        { "Chevrolet", new List<string> { "Camaro", "Silverado", "Malibu", "Equinox" } },
        //        { "Honda", new List<string> { "Civic", "Accord", "CR-V", "Pilot" } },
        //        { "Hyundai", new List<string> { "Elantra", "Santa Fe", "Tucson", "Sonata" } }
        //    };
        //}

        //private void BindBrandComboBox()
        //{
        //    comboBoxBrand.DataSource = new BindingSource(carData, null);
        //    comboBoxBrand.DisplayMember = "Key";
        //}

        //private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBoxBrand.SelectedItem != null)
        //    {
        //        var selectedBrand = ((KeyValuePair<string, List<string>>)comboBoxBrand.SelectedItem).Key;
        //        comboBoxModel.DataSource = carData[selectedBrand];
        //    }
        //}
        public void display()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select Brandname as [Brand Name],Modelname as [Model Name],Carnumber as [car Number],Purchasedate as [Purchase Date],RentalFee as [Rental Fee],Actualprice as [Actual Price],img as [img]  from Cartbl", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString(), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); 
            }
        }
        public void refresh()
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbid.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void custdeatail_Load(object sender, EventArgs e)
        {
            display();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select bookingid from rent", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbid.Items.Add(dt.Rows[i][0].ToString());
                }

                da = new SqlDataAdapter("select distinct Brandname from Cartbl", conn);
                dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBoxBrand.Items.Add(dt.Rows[i][0].ToString());
                }
                comboBoxBrand.SelectedIndex = 0;

            }
            catch (Exception exc)
            {

                //throw;
            }

        }


        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {   // Process form submission here (e.g., save data, etc.)

                // Clear the ComboBox selection
                comboBoxBrand.SelectedIndex = -1; // No item selected

                comboBoxModel.SelectedIndex = -1; // No item selected

                string query = "INSERT INTO custdetail (Custname, Custaddress, Custcity, CustContactno, CustPincode) VALUES (@Custname, @Custaddress, @Custcity,@CustContactno,@CustPincode)";
                if (txtCustname.Text == string.Empty || txtCustaddress.Text == string.Empty || txtCustcity.Text == string.Empty || txtCustContactno.Text == string.Empty || txtCustPincode.Text == string.Empty)
                {
                    MessageBox.Show("Please enter all the details");

                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("custdetailSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("Custname", @txtCustname.Text);
                    cmd.Parameters.Add("Custaddress", @txtCustaddress.Text);
                    cmd.Parameters.Add("Custcity", @txtCustcity.Text);
                    cmd.Parameters.Add("CustContactno", @txtCustContactno.Text);
                    cmd.Parameters.Add("CustPincode", @txtCustPincode.Text);
                    cmd.Parameters.Add("opr", "ins");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("inserted", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                conn.Close();

            }

        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from cartbl where Brandname='" + comboBoxBrand.Text + "' and Modelname='" + comboBoxModel.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtCarNumber.Text = dt.Rows[0][2].ToString();
                txtRentalFee.Text = dt.Rows[0][5].ToString();
                img.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + dt.Rows[0][7].ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxModel.Items.Clear();
                SqlDataAdapter da = new SqlDataAdapter("select Modelname from cartbl where Brandname='" + comboBoxBrand.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBoxModel.Items.Add(dt.Rows[i][0].ToString());
                }
                comboBoxModel.SelectedIndex = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate;
                DateTime endDate;

                // Try to parse the dates entered by the user
                if (DateTime.TryParse(StartingDate.Text, out startDate) && DateTime.TryParse(EndingDate.Text, out endDate))
                {
                    // Calculate the difference
                    TimeSpan dateDifference = endDate - startDate;
                    int diff = int.Parse(dateDifference.TotalDays.ToString()) + 1;
                    if (diff > 0)
                    {
                        txtnoofday.Text = diff.ToString();
                        int total = int.Parse(txtRentalFee.Text) * diff;
                        txtrent.Text = total.ToString();
                    }
                    else
                    {

                        StartingDate.Text = DateTime.Now.ToShortDateString();
                        EndingDate.Text = DateTime.Now.ToShortDateString();
                        MessageBox.Show("Starting date can not be greater than ending date");
                    }
                }
                else
                {
                    // If dates are not valid, show an error message
                    MessageBox.Show("Please enter valid dates.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void txtCustPincode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustPincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent non-numeric input
            }
            // Check if the textbox already has 6 digits and the key pressed is not a control key
            else if (txtCustPincode.Text.Length >= 6 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent input if already 6 digits
            }
        }

        private void txtCustContactno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustContactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent non-numeric input
            }
            // Prevent more than 10 digits from being entered
            else if (txtCustContactno.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent input if already 10 digits
            }
        }

        private void txtCustcity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustcity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not, prevent the key from being entered
                e.Handled = true;
            }
        }

        private void txtRentalFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRentalFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not, prevent the key from being entered
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not, prevent the key from being entered
                e.Handled = true;
            }
        }

        private void txtnoofday_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnoofday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not, prevent the key from being entered
                e.Handled = true;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            cars c = new cars();
            c.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void txtCustname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not, prevent the key from being entered
                e.Handled = true;
            }
        }

        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtCustcity.Text == string.Empty || txtCustPincode.Text == string.Empty || txtCustContactno.Text == string.Empty || txtCustname.Text == string.Empty || txtCustaddress.Text == string.Empty || txtCustContactno.Text == string.Empty)
                {
                    MessageBox.Show("Please enter all the details");
                }
               
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("custdetailSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("Custname", txtCustname.Text);
                    cmd.Parameters.Add("Custaddress", txtCustaddress.Text);
                    cmd.Parameters.Add("Custcity", txtCustcity.Text);
                    cmd.Parameters.Add("CustContactno", txtCustContactno.Text);
                    cmd.Parameters.Add("CustPincode", txtCustPincode.Text);
                    cmd.Parameters.Add("opr", "ins");
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    SqlDataAdapter da = new SqlDataAdapter("select carid from cartbl where brandname='" + comboBoxBrand.SelectedItem.ToString() + "' and carnumber='" + txtCarNumber.Text + "'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    int carid = int.Parse(dt.Rows[0][0].ToString());

                    da = new SqlDataAdapter("select custid from custdetail where custname='" + txtCustname.Text + "' and CustCity='" + txtCustcity.Text + "'", conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    int cusid = int.Parse(dt.Rows[0][0].ToString());


                    conn.Open();
                    cmd = new SqlCommand("rentsp", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("custid", cusid);
                    cmd.Parameters.Add("carid", carid);
                    cmd.Parameters.Add("startingdate", StartingDate.Text);
                    cmd.Parameters.Add("endingdate", EndingDate.Text);
                    cmd.Parameters.Add("bookingdate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.Add("totlrent", txtrent.Text);
                    cmd.Parameters.Add("noofdays", txtnoofday.Text);
                    cmd.Parameters.Add("opr", "ins");
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("inserted",
                   "Employee", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    //this.Hide();
                    //custdeatail cu = new custdeatail();
                    //cu.Show();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void StartingDate_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                DateTime startDate;
                DateTime endDate;

                // Try to parse the dates entered by the user
                if (DateTime.TryParse(StartingDate.Text, out startDate) && DateTime.TryParse(EndingDate.Text, out endDate))
                {
                    // Calculate the difference
                    TimeSpan dateDifference = endDate - startDate;
                    int diff = int.Parse(dateDifference.TotalDays.ToString()) + 1;

                    if (diff > 0)
                    {
                        txtnoofday.Text = diff.ToString();
                        int total = int.Parse(txtRentalFee.Text) * diff;
                        txtrent.Text = total.ToString();

                    }
                    else
                    {
                        StartingDate.Text = DateTime.Now.ToShortDateString();
                        EndingDate.Text = DateTime.Now.ToShortDateString();
                        MessageBox.Show("Starting date can not be greater than ending date");

                    }
                }
                else
                {
                    // If dates are not valid, show an error message
                    MessageBox.Show("Please enter valid dates.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int iid=Int32.Parse(cmbid.SelectedItem.ToString());


            conn.Open();

            SqlCommand cmd = new SqlCommand("custdetailSP", conn);
            SqlDataAdapter da  = new SqlDataAdapter(); 
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Custname", txtCustname.Text);
            cmd.Parameters.Add("@Custaddress", txtCustaddress.Text);
            cmd.Parameters.Add("@Custcity", txtCustcity.Text);
            cmd.Parameters.Add("@CustContactno", txtCustContactno.Text);
            cmd.Parameters.Add("@CustPincode", txtCustPincode.Text);
            cmd.Parameters.Add("@opr", "upd");
            cmd.Parameters.Add("@CustId", custid);

            int rowsAffected = cmd.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            da.UpdateCommand = cmd;
            
            

            //SqlCommand cmd = new SqlCommand("custdetailSP", conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("Custname", txtCustname.Text);
            //cmd.Parameters.Add("Custaddress", txtCustaddress.Text);
            //cmd.Parameters.Add("Custcity", txtCustcity.Text);
            //cmd.Parameters.Add("CustContactno", txtCustContactno.Text);
            //cmd.Parameters.Add("CustPincode", txtCustPincode.Text);

            ////cmd.Parameters.Add("CarID", comboBoxBrand.Text);
            ////cmd.Parameters.Add("ModelName", txtCarNumber.Text);
            //// cmd.Parameters.Add("PurchaseDate", txtPurchaseDate.Text);
            ////cmd.Parameters.Add("RentalFee", txtRentalFee.Text);
            ////cmd.Parameters.Add("Actualprice", txtActualprice.Text);
            ////cmd.Parameters.Add("img", imgvar);

            //cmd.Parameters.Add("opr", "upd");
            //cmd.ExecuteNonQuery();
            MessageBox.Show("Data Update successfully..!", "Upadet", MessageBoxButtons.OK, MessageBoxIcon.Question);


            conn.Close();
        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT r.BookingID, c.Custname, c.CustContactno, c.Custaddress, c.Custcity, " +
                    "c.CustPincode,ct.Brandname," +" ct.Carnumber, ct.Modelname, ct.RentalFee, ct.Actualprice, r.StartingDate, r.EndingDate, r.BookingDate, " +
                    "r.totalrent, r.noofdays, c.CustId FROM rent r JOIN custdetail c ON r.CustID = c.CustId JOIN Cartbl ct ON r.CarID = ct.CarId where r.BookingID=" 
                    + cmbid.SelectedItem.ToString(), conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtCustname.Text = dt.Rows[0][1].ToString();
                txtCustContactno.Text = dt.Rows[0][2].ToString();
                txtCustaddress.Text = dt.Rows[0][3].ToString();
                txtCustcity.Text = dt.Rows[0][4].ToString();
                txtCustPincode.Text = dt.Rows[0][5].ToString();
                comboBoxBrand.SelectedItem = dt.Rows[0][6].ToString();
                txtCarNumber.Text = dt.Rows[0][7].ToString();
                comboBoxModel.SelectedItem = dt.Rows[0][8].ToString();
                txtRentalFee.Text = dt.Rows[0][9].ToString();
                StartingDate.Text = dt.Rows[0][11].ToString();
                EndingDate.Text = dt.Rows[0][12].ToString();
                txtrent.Text = dt.Rows[0][14].ToString();
                txtnoofday.Text = dt.Rows[0][15].ToString();
                custid = Int32.Parse(dt.Rows[0][16].ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                txtresult.Clear();
                txtresult.Text += "***************************************" + "\n";
                txtresult.Text += "  ******  Fees Receipt System  ******" + "\n"; ;
                txtresult.Text += "***************************************" + "\n"; ;
                txtresult.Text += "date:" + DateTime.Now + "\n\n";
                txtresult.Text += "Customer Name:" + txtCustname.Text + "\n\n";
                txtresult.Text += "Address:" + txtCustaddress.Text + "\n\n";
                txtresult.Text += "City:" + txtCustcity.Text + "\n\n";
                txtresult.Text += "Car Number:" + txtCarNumber.Text + "\n\n";
                txtresult.Text += "Total rent:" + txtCustContactno.Text + "\n\n";
                txtresult.Text += "Total number of days:" + txtnoofday.Text + "\n\n";
                txtresult.Text += "                                                       Signature";

            }
        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtresult.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            
        }

        
    }
}