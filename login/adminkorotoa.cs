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
    public partial class adminkorotoa : Form
    {
        public adminkorotoa()
        {
            InitializeComponent();
        }
        // SqlConnection con = new SqlConnection(@"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;");
        string connn = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
        private void adminkorotoa_Load(object sender, EventArgs e)
        {
            GetSArecord();
        }

        private void GetSArecord()
        {

            SqlConnection con = new SqlConnection(connn);
            SqlCommand cmd = new SqlCommand("select * from kta", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dda.DataSource = dt;
        }

        private void bk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now we are Leaving From  Korotoa Courier Service Page.Thank You For Visit Our Page", "Leaving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            admin_p_info fm = new admin_p_info();
            fm.Show();
            this.Hide();
        }
    }
}
