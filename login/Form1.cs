using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        //       string con = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
        //SqlConnection con2 = new SqlConnection(con);
        //string sqlquery = "select * form Shipping_and_parcell";
        //con2.Open();
           
        }
     
       // SqlConnection con = new SqlConnection(@"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string email, user_pass;
            email = em.Text;
            user_pass = pass.Text;

           

            try
            {


                //string sqlquery = "select * form Shipping_and_parcell";

                string con = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
                SqlConnection con2 = new SqlConnection(con);
                con2.Open();

                string adminQuery = "SELECT * FROM adminLG WHERE Email='" + em.Text + "' AND Pass='" + pass.Text + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter sdr = new SqlDataAdapter(adminQuery, con2);
                sdr.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    email = em.Text;
                    user_pass = pass.Text;

                    Admin_Pannel adminPanel = new Admin_Pannel();
                    adminPanel.Show();
                    this.Hide();
                }

                else
                {

                    string userQuery = "SELECT * FROM LG WHERE Email='" + em.Text + "' AND Pass='" + pass.Text + "'";
                    // SqlDataAdapter userAdapter = new SqlDataAdapter(userQuery, con);
                    // DataTable userTable = new DataTable();
                    //userAdapter.Fill(userTable);

                    DataTable dt1 = new DataTable();
                    SqlDataAdapter sdr1 = new SqlDataAdapter(userQuery, con2);
                    sdr1.Fill(dt1);


                    if (dt1.Rows.Count > 0)
                    {
                        email = em.Text;
                        user_pass = pass.Text;

                        User_pannel userPanel = new User_pannel();
                        userPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Details For Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        em.Clear();
                        pass.Clear();
                        em.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception Details: " + ex.ToString());
            }
            finally
            {
               // con.Close();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            em.Clear();
            pass.Clear();
            clr.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void forg_Click(object sender, EventArgs e)
        {
            AboutUs Su2 = new AboutUs();
            Su2.Show();
            this.Hide();
        }
        private bool movingRight = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (movingRight)
            {
                wel.Left += 5;
            }
            else
            {
                wel.Left -= 5;
            }


            if (wel.Left <= 0)
            {

                movingRight = true;
            }
            else if (wel.Right >= this.ClientSize.Width)
            {

                movingRight = false;
            }
        }

        private void picbx_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}


