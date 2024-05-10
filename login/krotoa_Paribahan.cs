using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace login
{
    public partial class krotoa_Paribahan : Form
    {
        public krotoa_Paribahan()
        {
            InitializeComponent();
        }

        // SqlConnection cop = new SqlConnection(@"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;");
        public int id;
        string conn = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
        private object currentUser;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void krotoa_Paribahan_Load(object sender, EventArgs e)
        {
            GetSArecord();

        }



        private void another()
        {

        }

        private void GetSArecord()
        {
            SqlConnection cop = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("select * from kta", cop);
            DataTable dt = new DataTable();

            cop.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cop.Close();

            sap.DataSource = dt;
        }

        private void up_Click(object sender, EventArgs e)
        {
            SqlConnection cop = new SqlConnection(conn);
            if (id > 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE kta SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address, Type_Product = @Type_Product, Weight_Product = @Weight_Product WHERE id = @ID", cop);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", na.Text);
                    cmd.Parameters.AddWithValue("@Email", em.Text);
                    cmd.Parameters.AddWithValue("@Phone", phn.Text);
                    cmd.Parameters.AddWithValue("@Address", addr.Text);
                    cmd.Parameters.AddWithValue("@Type_Product", tp.SelectedItem != null ? tp.SelectedItem.ToString() : ""); // Check for null before calling ToString()
                    cmd.Parameters.AddWithValue("@Weight_Product", int.Parse(coc.Text));
                    cmd.Parameters.AddWithValue("@ID", this.id);

                    cop.Open();
                    cmd.ExecuteNonQuery();
                    cop.Close();

                    MessageBox.Show("Successfully Updated Your Parcel Details", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetSArecord();
                    ResetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Exception Details: " + ex.ToString());
                }
                finally
                {
                    cop.Close();
                }

            }

            else
            {
                MessageBox.Show("Select Student Id For Update.Try Again  ", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void clr_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void ResetData()
        {
            id = 0;
            na.Clear();
            em.Clear();
            phn.Clear();
            addr.Clear();
            tp.SelectedIndex = -1;
            coc.Clear();


            na.Focus();
        }

        private void con_Click(object sender, EventArgs e)
        {
            SqlConnection cop = new SqlConnection(conn);

            if (IsValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into kta values(@Name,@Email,@Phone,@Address,@Type_Product,@Weight_Product)", cop);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("Name", na.Text);
                    cmd.Parameters.AddWithValue("Email", em.Text);
                    cmd.Parameters.AddWithValue("Phone", phn.Text);
                    cmd.Parameters.AddWithValue("Address", addr.Text);
                    cmd.Parameters.AddWithValue("Type_Product", tp.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("Weight_Product", int.Parse(coc.Text));


                    cop.Open();
                    cmd.ExecuteNonQuery();

                    cop.Close();
                    MessageBox.Show("Successfully Added Your Percel Details  ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetSArecord();
                    ResetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Exception Details: " + ex.ToString());
                }
                finally
                {
                    cop.Close();
                }
            }
        }
        private bool IsValid()
        {
            if (na.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void sap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(sap.SelectedRows[0].Cells[0].Value);
            na.Text = sap.SelectedRows[0].Cells[1].Value.ToString();
            em.Text = sap.SelectedRows[0].Cells[2].Value.ToString();
            phn.Text = sap.SelectedRows[0].Cells[3].Value.ToString();
            addr.Text = sap.SelectedRows[0].Cells[4].Value.ToString();
            tp.Text = sap.SelectedRows[0].Cells[5].Value.ToString();
            coc.Text = sap.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void del_Click(object sender, EventArgs e)
        {
            SqlConnection cop = new SqlConnection(conn);
            if (id > 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM kta WHERE id=@ID", cop);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", this.id);

                    cop.Open();
                    cmd.ExecuteNonQuery();
                    cop.Close();

                    MessageBox.Show("Successfully Delete Your Parcel Details", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetSArecord();
                    ResetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Exception Details: " + ex.ToString());
                }
                finally
                {
                    cop.Close();
                }
            }
            else
            {
                MessageBox.Show("Select Student Id For Delete.Try Again  ", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now we are Leaving From  Korotoa Courier Service Page.Thank You For Visit Our Page", "Leaving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            User_pannel fm = new User_pannel();
            fm.Show();
            this.Hide();
        }

        private void Cost_Click(object sender, EventArgs e)
        {
            try
            {


                if (!string.IsNullOrEmpty(coc.Text))
                {
                    // Parse the input weight
                    int weight = int.Parse(coc.Text);

                    // Determine the base price based on the weight
                    int basePrice;

                    if (weight < 20)
                    {
                        basePrice = 150;
                    }
                    else if (weight >= 20 && weight < 40)
                    {
                        basePrice = 200;
                    }
                    else if (weight <= 40)
                    {
                        basePrice = 500;
                    }
                    else
                    {

                        MessageBox.Show("We allow a maximum weight of 40 kg.", "Maximum Weight Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int additionalCost = 0;
                    switch (tp.SelectedItem.ToString())
                    {
                        case "Glass":
                            additionalCost = 90;
                            break;
                        case "Electronics":
                            additionalCost = 42;
                            break;
                        case "Fruit":
                            additionalCost = 73;
                            break;
                        case "Other":
                            additionalCost = 0;
                            break;
                        default:

                            break;
                    }


                    int totalCost = basePrice + additionalCost;


                    calcu.Text = "Total Cost: " + totalCost.ToString() + " taka";
                }
                else
                {

                    calcu.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void na_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
