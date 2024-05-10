using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace login
{

    public partial class FeedbackUsers : Form
    {
        public FeedbackUsers()
        {
            InitializeComponent();
        }
        // private const string connectionString = @"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;";

        string connn = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
        private void types(object sender, EventArgs e)
        {

        }

        private void level(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string feedbackType = GetSelectedFeedbackType();





            SqlConnection connection = new SqlConnection(connn);
            {
                if (IsValid())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("insert into Feedback values(@Courier_Name,@Feedback_Type,@Satisfied_or_Not,@Advice)", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("Courier_Name", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("Feedback_Type", comboBox2.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("Satisfied_or_Not", feedbackType);
                        cmd.Parameters.AddWithValue("Advice", textBox1.Text);



                        connection.Open();
                        cmd.ExecuteNonQuery();

                        connection.Close();
                        MessageBox.Show("Successfully Added Your Percel Details  ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Exception Details: " + ex.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }
        }



        private bool IsValid()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private string GetSelectedFeedbackType()
        {
            if (radioButton4.Checked)
                return radioButton4.Text;
            else if (radioButton3.Checked)
                return radioButton3.Text;
            else if (radioButton6.Checked)
                return radioButton6.Text;
            else if (radioButton5.Checked)
                return radioButton5.Text;
            else
                return "Other";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Successfull now we are loading to Sundorbon Courier Service WEB form", "Loading Sundarbon Courier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Showfeedback Su = new Showfeedback();
            Su.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FeedbackUsers_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Back To The User Pannel","User Pannel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 Su3 = new Form1();
            Su3.Show();
            this.Hide();
        }
    }
}
