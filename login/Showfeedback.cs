using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login
{
    public partial class Showfeedback : Form
    {
        public Showfeedback()
        {
            InitializeComponent();
        }
        //SqlConnection cop = new SqlConnection(@"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;");
        string connn = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
        private void Showfeedback_Load(object sender, EventArgs e)
        {
            GetSArecord();
        }

        private void GetSArecord()
        {

            SqlConnection cop = new SqlConnection(connn);
            SqlCommand cmd = new SqlCommand("select * from Feedback", cop);
            DataTable dt = new DataTable();

            cop.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cop.Close();

            sdd.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sdd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

        }

        private void userbut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_pannel Su3 = new User_pannel();
            Su3.Show();
            this.Hide();
        }
    }
}
