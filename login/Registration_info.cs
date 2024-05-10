using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace login
{
    public partial class Registration_info : Form
    {
        public Registration_info()
        {
            InitializeComponent();
        }
        //SqlConnection co = new SqlConnection(@"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;");
        string connn = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Registration_info_Load(object sender, EventArgs e)
        {
            GetSArecord();
        }

        private void GetSArecord()
        {

            SqlConnection co = new SqlConnection(connn);
            string con = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
            SqlConnection con2 = new SqlConnection(con);
           

            string cmd = "select * from Registration";
            DataTable dt = new DataTable();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd, con2);
            sdr.Fill(dt);
            con2.Open();
            con2.Close();

            dataGridView1.DataSource = dt;
        }

        private void con_Click(object sender, EventArgs e)
        {
            Admin_Pannel Su33 = new Admin_Pannel();
            Su33.Show();
            this.Hide();
        }
    }
}
