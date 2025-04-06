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
    public partial class cars : Form
    {
        SqlConnection conn = new SqlConnection(Connect.constr);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        int index;
        static int id;

        private static string imgvar;

        public cars()
        {
            InitializeComponent();
            //InitializeCarData();
            //BindBrandComboBox();
        }
        //private void InitializeCarData()
        //{
        //    //carData = new Dictionary<string, List<string>>
        //    //{
        //    //    { "BMW", new List<string> { "X5", "X3", "M3", "M4" } },
        //    //    { "Audi", new List<string> { "A4", "Q7", "A6", "A8" } },
        //    //    { "Jeep", new List<string> { "Wrangler", "Cherokee", "Grand Cherokee" } },
        //    //    { "Tesla", new List<string> { "Model S", "Model 3", "Model X", "Model Y" } },
        //    //    { "Jaguar", new List<string> { "F-PACE", "E-PACE", "XE", "XF" } },
        //    //    { "Rolls-Royce", new List<string> { "Phantom", "Ghost", "Wraith", "Cullinan" } },
        //    //    { "Kia", new List<string> { "Sorento", "Sportage", "Optima", "Seltos" } },
        //    //    { "Ford", new List<string> { "F-150", "Mustang", "Explorer", "Escape" } },
        //    //    { "Toyota", new List<string> { "Camry", "Corolla", "RAV4", "Highlander" } },
        //    //    { "Chevrolet", new List<string> { "Camaro", "Silverado", "Malibu", "Equinox" } },
        //    //    { "Honda", new List<string> { "Civic", "Accord", "CR-V", "Pilot" } },
        //    //    { "Hyundai", new List<string> { "Elantra", "Santa Fe", "Tucson", "Sonata" } }
        //    //};
        //}

        private void BindBrandComboBox()
        {
            //comboBoxBrand.DataSource = new BindingSource(carData, null);
            //comboBoxBrand.DisplayMember = "Key";
        }

        public void display()
        {

            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter("select carId as ID,Brandname as [Brand Name],Modelname as [Model Name],Carnumber as [car Number],Purchasedate as [Purchase Date],RentalFee as [Rental Fee],Actualprice as [Actual Price],img as [img]  from Cartbl", conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
                foreach (DataRow drow in dt.Rows)
                {
                    drow["Image"] = File.ReadAllBytes(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + drow["img"].ToString());
                }
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;

                ((DataGridViewImageColumn)dataGridView1.Columns[dataGridView1.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridView1.Columns[dataGridView1.Columns.Count - 1].Width = 250;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void cars_Load(object sender, EventArgs e)
        {
            display();
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    modelcombobox.Visible = false;
                    txtmodelnm.Visible = true;
                    comboBoxBrand.Text = "";
                    txtActualprice.Text = "";
                    txtRentalFee.Text = "";
                    txtCarNumber.Text = "";
                    btnadd.Visible = true;
                    btnupdate.Visible = false;
                }
                else
                {
                    comboBoxBrand.Items.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("select distinct Brandname from Cartbl", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        comboBoxBrand.Items.Add(dt.Rows[i][0].ToString());
                    }
                    comboBoxBrand.SelectedIndex = 0;


                }

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }


        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            img.ImageLocation = openFileDialog1.FileName;
            imgvar = "/img/" + comboBoxBrand.Text + " " + txtmodelnm.Text + ".jpg";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //txtCarName.Text = "";
            txtmodelnm.Text = "";
            txtCarNumber.Text = "";
            txtPurchaseDate.Text = "";
            txtRentalFee.Text = "";
            txtActualprice.Text = "";
            img.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "/img/empty.jpg";



        }
        private void txtCarName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtmodelnm.Text == string.Empty || txtCarNumber.Text == string.Empty || txtPurchaseDate.Text == string.Empty || txtActualprice.Text == string.Empty || txtRentalFee.Text == string.Empty || imgvar == null)
                {
                    MessageBox.Show("Please enter all the details");

                }
                else
                {

                    File.Copy(img.ImageLocation, Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "/img/" + comboBoxBrand.Text + " " + txtmodelnm.Text + ".jpg");

                    conn.Open();


                    SqlCommand cmd = new SqlCommand("CarSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("Brandname", comboBoxBrand.Text);
                    cmd.Parameters.Add("ModelName", txtmodelnm.Text);
                    cmd.Parameters.Add("CarNumber", txtCarNumber.Text);
                    cmd.Parameters.Add("PurchaseDate", txtPurchaseDate.Text);
                    cmd.Parameters.Add("RentalFee", txtRentalFee.Text);
                    cmd.Parameters.Add("Actualprice", txtActualprice.Text);
                    cmd.Parameters.Add("img", "/img/" + comboBoxBrand.Text+ " " + txtmodelnm.Text + ".jpg");
                    cmd.Parameters.Add("opr", "ins");
                    cmd.ExecuteNonQuery();


                    SqlDataAdapter da = new SqlDataAdapter("select carid from cartbl where Carnumber='" + txtCarNumber.Text + "' and Rentalfee='" + txtRentalFee.Text + "' and ModelName = '" + modelcombobox.Text + "' and Actualprice = '" + txtActualprice.Text + "'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //// int carid = int.Parse(dt.Rows[0][0].ToString());

                    conn.Close();
                    MessageBox.Show("inserted",
                    "Employee", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    display();
                    this.Hide();
                    custdeatail cu = new custdeatail();
                    cu.Show();

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void img_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void txtRentalFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not, prevent the key from being entered
                e.Handled = true;
            }
        }

        private void txtActualprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not, prevent the key from being entered
                e.Handled = true;
            }
        }



        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT CarId from cartbl where Brandname='" + comboBoxBrand.SelectedItem.ToString() + "' and Modelname='" + modelcombobox.SelectedItem.ToString() + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            id = int.Parse(dt.Rows[0][0].ToString());
            if (File.Exists(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "/img/" + comboBoxBrand.Text + " " + modelcombobox.Text + ".jpg"))
            {
                File.Delete(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "/img/" + comboBoxBrand.Text + " " + modelcombobox.Text + ".jpg");
                File.Copy(img.ImageLocation, Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "/img/" + comboBoxBrand.Text + " " + modelcombobox.Text + ".jpg");
            }
            else
                File.Copy(img.ImageLocation, Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "/img/" + comboBoxBrand.Text + " " + modelcombobox.Text + ".jpg");
            conn.Open();

            SqlCommand cmd = new SqlCommand("CarSP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //comboBoxBrand
            cmd.Parameters.Add("CarId", id);
            cmd.Parameters.Add("Brandname", comboBoxBrand.Text);
            cmd.Parameters.Add("ModelName", modelcombobox.Text);
            cmd.Parameters.Add("CarNumber", txtCarNumber.Text);

            cmd.Parameters.Add("PurchaseDate", txtPurchaseDate.Text);
            cmd.Parameters.Add("RentalFee", txtRentalFee.Text);
            cmd.Parameters.Add("Actualprice", txtActualprice.Text);
            cmd.Parameters.Add("img", "/img/" + comboBoxBrand.Text + " " + modelcombobox.Text + ".jpg");

            cmd.Parameters.Add("opr", "upd");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Update successfully..!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Question);

            conn.Close();
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                modelcombobox.Visible = false;
                txtmodelnm.Visible = true;
                comboBoxBrand.Text = "";
                txtActualprice.Text = "";
                txtRentalFee.Text = "";
                txtCarNumber.Text = "";
                btnadd.Visible = true;

                btnupdate.Visible = false;
                comboBoxBrand.Items.Clear();

                comboBoxBrand.Items.Add("BMW");
                comboBoxBrand.Items.Add("Audi");
                comboBoxBrand.Items.Add("Jeep");
                comboBoxBrand.Items.Add("Tesla");
                comboBoxBrand.Items.Add("Jaguar");
                comboBoxBrand.Items.Add("Rolls-Royce");
                comboBoxBrand.Items.Add("Kia");
                comboBoxBrand.Items.Add("Ford");
                comboBoxBrand.Items.Add("Toyota");
                comboBoxBrand.Items.Add("Chevrolet");
                comboBoxBrand.Items.Add("Honda");
                comboBoxBrand.Items.Add("Hyundai");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                modelcombobox.Visible = true;
                txtmodelnm.Visible = false;
                btnadd.Visible = false;
                btnupdate.Visible = true;
                comboBoxBrand.Items.Clear();
                SqlDataAdapter da = new SqlDataAdapter("select distinct Brandname from Cartbl", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBoxBrand.Items.Add(dt.Rows[i][0].ToString());
                }
                comboBoxBrand.SelectedIndex = 0;


            }
        }

        private void modelcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("select Modelname,CarNumber,purchasedate,Actualprice,RentalFee,img from Cartbl where brandname='" + comboBoxBrand.SelectedItem.ToString() + "' and modelname='" + modelcombobox.SelectedItem.ToString() + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                modelcombobox.Text = dt.Rows[0][0].ToString();
                txtCarNumber.Text = dt.Rows[0][1].ToString();
                txtPurchaseDate.Text = dt.Rows[0][2].ToString();
                txtActualprice.Text = dt.Rows[0][3].ToString();
                txtRentalFee.Text = dt.Rows[0][4].ToString();
                img.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + dt.Rows[0][5].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT Modelname from cartbl where Brandname='" + comboBoxBrand.Text + "'", conn);
                //SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                da.Fill(dt);

                modelcombobox.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    modelcombobox.Items.Add(dt.Rows[i][0]);
                    //this will bind combo of model
                }
                modelcombobox.SelectedIndex = 0;


            }
            catch (Exception ex)
            {

                //   MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            File.Delete(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + dataGridView1.SelectedCells[dataGridView1.ColumnCount - 2].Value.ToString());
            conn.Open();
            SqlCommand cmd= new SqlCommand("Delete Cartbl where Carid="+ dataGridView1.SelectedCells[0].Value.ToString(),conn);
            cmd.ExecuteNonQuery();
            display();
            conn.Close();
            
        }
        static string id1;

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup s = new Signup();
            s.Show();
        }
    }
}

