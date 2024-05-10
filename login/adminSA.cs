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
    public partial class adminSA : Form
    {
        public adminSA()
        {
            InitializeComponent();
        }
        // SqlConnection con = new SqlConnection(@"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;");
        string connn = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;


        private void adminSA_Load(object sender, EventArgs e)
        {
            GetSArecord();
        }

        private void GetSArecord()
        {
            SqlConnection con = new SqlConnection(connn);

            SqlCommand cmd = new SqlCommand("select * from SAP", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dds.DataSource = dt;
        }

        private void bk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now we are Leaving From  SA paribahan web Page.Thank You For Visit Our Page", "Leaving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            admin_p_info fm = new admin_p_info();
            fm.Show();
            this.Hide();
        }
    }
}
