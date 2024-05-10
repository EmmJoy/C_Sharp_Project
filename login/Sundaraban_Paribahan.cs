using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace login
{
    public partial class Sundaraban_Paribahan : Form
    {
        public Sundaraban_Paribahan()
        {
            InitializeComponent();
        }
       // SqlConnection con = new SqlConnection(@"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;");
        public int id;
        string con = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con2 = new SqlConnection(con);
            if (IsValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into sundarban11 values(@Name,@Email,@Phone,@Address,@Type_Product,@Weight_Product)", con2);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("Name", sn.Text);
                    cmd.Parameters.AddWithValue("Email", se.Text);
                    cmd.Parameters.AddWithValue("Phone", sp.Text);
                    cmd.Parameters.AddWithValue("Address", sa.Text);
                    cmd.Parameters.AddWithValue("Type_Product", sc.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("Weight_Product", int.Parse(spw.Text));


                    con2.Open();
                    cmd.ExecuteNonQuery();

                    con2.Close();
                    MessageBox.Show("Successfully Added Your Percel Details  ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetRecord();
                    NewMethod();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Exception Details: " + ex.ToString());
                }
                finally
                {
                    con2.Close();
                }

            }
        }

        private bool IsValid()
        {
            if (sn.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


        }




        private void button4_Click(object sender, EventArgs e)
        {
           
            SqlConnection con2 = new SqlConnection(con);
            if (id > 0)
            {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand("UPDATE sundarban11 SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address, Type_Product = @Type_Product, Weight_Product = @Weight_Product WHERE id = @ID", con2);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", sn.Text);
                    cmd.Parameters.AddWithValue("@Email", se.Text);
                    cmd.Parameters.AddWithValue("@Phone", sp.Text);
                    cmd.Parameters.AddWithValue("@Address", sa.Text);
                    cmd.Parameters.AddWithValue("@Type_Product", sc.SelectedItem != null ? sc.SelectedItem.ToString() : ""); // Check for null before calling ToString()
                    cmd.Parameters.AddWithValue("@Weight_Product", int.Parse(spw.Text));
                    cmd.Parameters.AddWithValue("@ID", this.id);

                    con2.Open();
                    cmd.ExecuteNonQuery();
                    con2.Close();

                    MessageBox.Show("Successfully Updated Your Parcel Details", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetRecord();
                    NewMethod();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Exception Details: " + ex.ToString());
                }
                finally
                {
                    con2.Close();
                }

            }

            else
            {
                MessageBox.Show("Select Student Id For Update.Try Again  ", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now we are Leaving From Sudarban Courier Service Page","Leaving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            User_pannel fm = new User_pannel();
            fm.Show();
            this.Hide();
        }

        private void Sundaraban_Paribahan_Load(object sender, EventArgs e)
        {
            GetRecord();
        }

        private void GetRecord()
        {
            SqlConnection con2 = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("select * from sundarban11", con2);
            DataTable dt = new DataTable();

            con2.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con2.Close();

            sdg.DataSource = dt;



            //SqlDataReader sdr = con.ExecuteReader();
            //dt.Load(sdr);
            //con.Close();
           
           
        }

        private void sdel_Click(object sender, EventArgs e)
        {
            
            SqlConnection con2 = new SqlConnection(con);
            if (id > 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM sundarban11 WHERE id=@ID", con2);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", this.id);

                    con2.Open();
                    cmd.ExecuteNonQuery();
                    con2.Close();

                    MessageBox.Show("Successfully Delete Your Parcel Details", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetRecord();
                    NewMethod();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Exception Details: " + ex.ToString());
                }
                finally
                {
                    con2.Close();
                }
            }
            else
            {
                MessageBox.Show("Select Student Id For Delete.Try Again  ", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void scl_Click(object sender, EventArgs e)
        {
            NewMethod();

        }

        private void NewMethod()
        {
            id = 0;
            sn.Clear();
            se.Clear();
            sp.Clear();
            sa.Clear();
            sc.SelectedIndex = -1;
            spw.Clear();


            se.Focus();
        }

        private void sdg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(sdg.SelectedRows[0].Cells[0].Value);
            sn.Text = sdg.SelectedRows[0].Cells[1].Value.ToString();
            se.Text = sdg.SelectedRows[0].Cells[2].Value.ToString();
            sp.Text = sdg.SelectedRows[0].Cells[3].Value.ToString();
            sa.Text = sdg.SelectedRows[0].Cells[4].Value.ToString();
            sc.Text = sdg.SelectedRows[0].Cells[5].Value.ToString();
            spw.Text = sdg.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void sdg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cost_Click(object sender, EventArgs e)
        {



            try
            {


                if (!string.IsNullOrEmpty(spw.Text))
                {
               
                    int weight = int.Parse(spw.Text);

     
                    int basePrice;

                    if (weight < 20)
                    {
                        basePrice = 150;
                    }
                    else if (weight >= 20 && weight < 40)
                    {
                        basePrice = 200;
                    }
                    else if (weight > 40 && weight <= 100)
                    {
                        basePrice = 500;
                    }
                    else if (weight > 100 && weight <= 200)
                    {
                        basePrice = 2000;
                    }

                    else
                    {

                        MessageBox.Show("We allow a maximum weight of 40 kg.", "Maximum Weight Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int additionalCost = 0;
                    switch (sc.SelectedItem.ToString())
                    {
                        case "Glass":
                            additionalCost = 90;
                            break;
                        case "Electronics":
                            additionalCost = 70;
                            break;
                        case "Fruit":
                            additionalCost = 100;
                            break;
                        case "Other":
                            additionalCost = 0;
                            break;
                        default:

                            break;
                    }


                    int totalCost = basePrice + additionalCost;


                    cos.Text = "Total Cost: " + totalCost.ToString() + " taka";
                }
                else
                {

                    cos.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception Details: " + ex.ToString());
            }
            finally
            {
                
            }


        }
    }
}