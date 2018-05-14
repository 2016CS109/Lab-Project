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
    public partial class StudentsRegisterationForm : Form
    {
        public StudentsRegisterationForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage obj = new HomePage();
            obj.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox1.Text == "" || comboBox3.Text == "" || comboBox2.Text == "" || comboBox4.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Incomplete Information is Provided!");
            }
            else if(textBox4.Text != textBox3.Text)
            {
                MessageBox.Show("Your Confirmation Password is Incorrect");
                textBox4.Text = null;
            }
            else
            {
                StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
                StudentsAffairsSystem.StudentInfo(textBox2.Text, textBox5.Text, textBox6.Text, comboBox3.Text, comboBox4.Text, textBox7.Text, comboBox1.Text);
                StudentsAffairsSystem.StudentRegister(textBox2.Text, textBox3.Text, textBox5.Text, textBox6.Text, comboBox4.Text, textBox7.Text, comboBox1.Text, comboBox3.Text, comboBox2.Text, textBox8.Text);
                MessageBox.Show("U have been Registered!");
                textBox2.Text = null; textBox3.Text = null; textBox5.Text = null; textBox6.Text = null; textBox7.Text = null; comboBox1.Text = null; comboBox3.Text = null; comboBox4.Text = null; comboBox2.Text = null; textBox8.Text = null; textBox4.Text = null;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLoginPage obj = new UserLoginPage();
            obj.Show();
            this.Hide();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
