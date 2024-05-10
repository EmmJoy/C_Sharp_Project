using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now We Are Going Back To Our LogIN Page", "LogIn Page", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 Su3 = new Form1();
            Su3.Show();
            this.Hide();
        }
    }
}
