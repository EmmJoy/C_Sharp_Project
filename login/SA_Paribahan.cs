using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace login
{
    public partial class SA_Paribahan : Form
    {
        public SA_Paribahan()
        {
            InitializeComponent();
        }
       // SqlConnection co = new SqlConnection(@"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;");
        public int id;
        string connn = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;

        private void SA_Paribahan_Load(object sender, EventArgs e)
        {
            GetSArecord();
        }

        private void GetSArecord()
        {
            SqlConnection co = new SqlConnection(connn);
            SqlCommand cmd = new SqlCommand("select * from SAP", co);
            DataTable dt = new DataTable();

            co.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            co.Close();

            sap.DataSource = dt;
        }

        private void sap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void con_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection(connn);
            if (IsValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into SAP values(@Name,@Email,@Phone,@Address,@Type_Product,@Weight_Product)", co);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("Name", na.Text);
                    cmd.Parameters.AddWithValue("Email", em.Text);
                    cmd.Parameters.AddWithValue("Phone", phn.Text);
                    cmd.Parameters.AddWithValue("Address", addr.Text);
                    cmd.Parameters.AddWithValue("Type_Product", tp.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("Weight_Product", int.Parse(wp.Text));


                    co.Open();
                    cmd.ExecuteNonQuery();

                    co.Close();
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
                    co.Close();
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
            wp.Clear();


            na.Focus();
        }

        private void up_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection(connn);
            if (id > 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE sap SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address, Type_Product = @Type_Product, Weight_Product = @Weight_Product WHERE id = @ID", co);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", na.Text);
                    cmd.Parameters.AddWithValue("@Email", em.Text);
                    cmd.Parameters.AddWithValue("@Phone", phn.Text);
                    cmd.Parameters.AddWithValue("@Address", addr.Text);
                    cmd.Parameters.AddWithValue("@Type_Product", tp.SelectedItem != null ? tp.SelectedItem.ToString() : ""); // Check for null before calling ToString()
                    cmd.Parameters.AddWithValue("@Weight_Product", int.Parse(wp.Text));
                    cmd.Parameters.AddWithValue("@ID", this.id);

                    co.Open();
                    cmd.ExecuteNonQuery();
                    co.Close();

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
                    co.Close();
                }

            }

            else
            {
                MessageBox.Show("Select Student Id For Update.Try Again  ", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(sap.SelectedRows[0].Cells[0].Value);
            na.Text = sap.SelectedRows[0].Cells[1].Value.ToString();
            em.Text = sap.SelectedRows[0].Cells[2].Value.ToString();
            phn.Text = sap.SelectedRows[0].Cells[3].Value.ToString();
            addr.Text = sap.SelectedRows[0].Cells[4].Value.ToString();
            tp.Text = sap.SelectedRows[0].Cells[5].Value.ToString();
            wp.Text = sap.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void del_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection(connn);
            if (id > 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM SAP WHERE id=@ID", co);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", this.id);

                    co.Open();
                    cmd.ExecuteNonQuery();
                    co.Close();

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
                    co.Close();
                }
            }
            else
            {
                MessageBox.Show("Select Student Id For Delete.Try Again  ", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now we are Leaving From  SA Paribahan Page.Thank You For Visit Our Page");
            User_pannel fm = new User_pannel();
            fm.Show();
            this.Hide();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {


                if (!string.IsNullOrEmpty(wp.Text))
                {

                    int weight = int.Parse(wp.Text);


                    int basePrice;

                    if (weight < 20)
                    {
                        basePrice = 80;
                    }
                    else if (weight >= 20 && weight < 40)
                    {
                        basePrice = 100;
                    }
                    else if (weight >= 40 && weight < 60)
                    {
                        basePrice = 130;
                    }
                    else if (weight >= 60 && weight < 85)
                    {
                        basePrice = 512;
                    }
                    else if (weight >= 85 && weight < 90)
                    {
                        basePrice = 700;
                    }

                    else
                    {

                        MessageBox.Show("We allow a maximum weight of 90 kg.", "Maximum Weight Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int additionalCost = 0;
                    switch (tp.SelectedItem.ToString())
                    {
                        case "Glass":
                            additionalCost = 23;
                            break;
                        case "Electronics":
                            additionalCost = 37;
                            break;
                        case "Fruit":
                            additionalCost = 44;
                            break;
                        case "Others":
                            additionalCost = 0;
                            break;
                        default:

                            break;
                    }


                    int totalCost = basePrice + additionalCost;


                    tbs.Text = "Total Cost: " + totalCost.ToString() + " taka";
                }
                else
                {

                    tbs.Text = "";
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
