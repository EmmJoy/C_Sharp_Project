using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class admin_p_info : Form
    {
        public admin_p_info()
        {
            InitializeComponent();
        }

        private void admin_p_info_Load(object sender, EventArgs e)
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
                    adminsundarban Su = new adminsundarban();
                    Su.Show();
                    this.Hide();
                    break;
                case "SA Paribahan":

                    MessageBox.Show("Request Successfull now we are loading to SA Parihan", "LoadingSA Paribahan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    adminSA Su2 = new adminSA();
                    Su2.Show();
                    this.Hide();
                    break;
                case "Korotoa COurier Service":

                    MessageBox.Show("Request Successfull now we are loading to Korotoa Courier Service", "Loading Korotoa Courier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminkorotoa Su3 = new adminkorotoa();
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
            MessageBox.Show("Back To The Asmin Pannel", "Admin Pannel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Admin_Pannel Su4 = new Admin_Pannel();
            Su4.Show();
            this.Hide();
        }
    }
}
