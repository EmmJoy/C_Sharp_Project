using System.Data.SqlClient;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;



namespace login
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //SqlConnection con = new SqlConnection(@"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;");
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation for empty fields
                bool isAnyEmpty = false;

                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        if (string.IsNullOrEmpty(control.Text))
                        {
                            isAnyEmpty = true;
                            break;
                        }
                    }
                    else if (control is ComboBox)
                    {
                        if (((ComboBox)control).SelectedIndex == -1)
                        {
                            isAnyEmpty = true;
                            break;
                        }
                    }
                }
                if (isAnyEmpty)
                {
                    MessageBox.Show("Please Fill The Empty Field Before Confirm The Registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                
                if (!rb3.Text.EndsWith("@gmail.com"))
                {
                    errorProvider1.SetError(rb3, "Email must end with '@gmail.com'");
                    return; 
                }
                else
                {
                    errorProvider1.SetError(rb3, ""); 
                }
                if (rb4.Text.Length != 11 || !rb4.Text.All(char.IsDigit))
                {
                    errorProvider1.SetError(rb4, "Phone number must be 11 digits");
                    return; 
                }
                else
                {
                    errorProvider1.SetError(rb4, ""); // Clear error if input is valid
                }

                string con = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
                SqlConnection con2 = new SqlConnection(con);
                con2.Open();

                string insertQuery = "INSERT INTO LG VALUES(@Fname,@Lname,@Email,@Pnumb,@pass,@Desig,@Gender)";
                
                SqlCommand cmd = new SqlCommand(insertQuery, con2);
                cmd.Parameters.AddWithValue("@Fname", rb1.Text);
                cmd.Parameters.AddWithValue("@lname", rb2.Text);
                cmd.Parameters.AddWithValue("@Email", rb3.Text);
                cmd.Parameters.AddWithValue("@Pnumb", rb4.Text);
                cmd.Parameters.AddWithValue("@Pass", rb6.Text);
                cmd.Parameters.AddWithValue("@Desig", rb5.Text);
                cmd.Parameters.AddWithValue("@Gender", rc1.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void button2_Click(object sender, EventArgs e)
        {
            rb1.Clear();
            rb2.Clear();
            rb3.Clear();
            rb4.Clear();
            rb5.Clear();
            rb6.Clear();
            rc1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now we are Leaving Registration Form");
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void rb3_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!textBox.Text.EndsWith("@gmail.com"))
            {
                errorProvider1.SetError(textBox, "Email must end with '@gmail.com'");
            }
            else
            {
                errorProvider1.SetError(textBox, ""); // Clear error if input is valid
            }
        }

        private void rb4_TextChanged(object sender, EventArgs e)
        {
            TextBox rb4 = (TextBox)sender;
            string input = rb4.Text.Trim();

            // Check if the input consists of exactly 11 digits
            if (!string.IsNullOrEmpty(input) && input.Length != 11 || !input.All(char.IsDigit))
            {
                errorProvider1.SetError(rb4, "Please enter exactly 11 digits.");
                rb4.Focus(); // Set focus back to the TextBox
            }
            else
            {
                errorProvider1.SetError(rb4, ""); // Clear error indicator
            }
        }
    }
}
