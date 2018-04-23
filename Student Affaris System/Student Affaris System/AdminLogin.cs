using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Affaris_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "UET-ADMIN" && textBox1.Text == "UET-Administrator-@0321")
            {
                MessageBox.Show("Admin has been Login");
                AdminPageAfterLogin obj = new AdminPageAfterLogin();
                obj.Show();
                this.Hide();
            }
            else if(textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Incompete Information is provided!");
            }
            else
            {
                MessageBox.Show("Incorrect");
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = true;
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage obj = new HomePage();
            obj.Show();
            this.Hide();
        }
    }
}
