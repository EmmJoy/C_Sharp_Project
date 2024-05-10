using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Admin_Pannel : Form
    {
        public Admin_Pannel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration_info Su33 = new Registration_info();
            Su33.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Feedback Su30 = new Admin_Feedback();
            Su30.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Back To The LogIN Page", "LogIn Page", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 Su3 = new Form1();
            Su3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            admin_p_info s3 = new admin_p_info();
            s3.Show();
            this.Hide();
        }

        private void Admin_Pannel_Load(object sender, EventArgs e)
        {

        }
    }
}
