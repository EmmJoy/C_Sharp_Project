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
    public partial class adminsundarban : Form
    {
        public adminsundarban()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;");
        //public int id;
        string connn = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
        private void adminsundarban_Load(object sender, EventArgs e)
        {
            GetRecord();
        }

        private void GetRecord()
        {

            SqlConnection con = new SqlConnection(connn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM sundarban11", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            ds.DataSource = dt;
        }

        private void bk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now we are Leaving From  Sundarban Courier Service Page.Thank You For Visit Our Page", "Leaving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            admin_p_info fm = new admin_p_info();
            fm.Show();
            this.Hide();
        }
    }
}
