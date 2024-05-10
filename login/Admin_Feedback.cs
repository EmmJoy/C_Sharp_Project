using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace login
{
    public partial class Admin_Feedback : Form
    {
        public Admin_Feedback()
        {
            InitializeComponent();
        }
        //  SqlConnection cop = new SqlConnection(@"Data Source=BACKSTAGE\SQLEXPRESS13;Initial Catalog=Shipping_and_parcell;Integrated Security=True;");
        string connn = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;

        private void Admin_Feedback_Load(object sender, EventArgs e)
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

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now We Are Leaving This Page", "Leaving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Admin_Pannel Su3 = new Admin_Pannel();
            Su3.Show();
            this.Hide();
        }
    }
}
