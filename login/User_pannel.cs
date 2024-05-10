namespace login
{
    public partial class User_pannel : Form
    {
        public User_pannel()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (cmb1.SelectedItem == null)
            {
                MessageBox.Show("Please select an option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string selectedOption = cmb1.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Sundarban Courier Service":

                    MessageBox.Show("Request Successfull now we are loading to Sundorbon Courier Service WEB form", "Loading Sundarbon Courier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sundaraban_Paribahan Su = new Sundaraban_Paribahan();
                    Su.Show();
                    this.Hide();
                    break;
                case "SA Paribahan":

                    MessageBox.Show("Request Successfull now we are loading to SA Parihan", "LoadingSA Paribahan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SA_Paribahan Su2 = new SA_Paribahan();
                    Su2.Show();
                    this.Hide();
                    break;
                case "Korotoa Courier Service":

                    MessageBox.Show("Request Successfull now we are loading to Korotoa Courier Service", "Loading Korotoa Courier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    krotoa_Paribahan Su3 = new krotoa_Paribahan();
                    Su3.Show();
                    this.Hide();

                    break;
                default:

                    MessageBox.Show("First You have to select a courier servicee", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand);
                    break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Back To The LogInpage", "Quit", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("We are going to our feedback page", "Feedback Page", MessageBoxButtons.OK, MessageBoxIcon.None);
            FeedbackUsers Su33 = new FeedbackUsers();
            Su33.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;

        }

        private void User_pannel_Load(object sender, EventArgs e)
        {

        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
