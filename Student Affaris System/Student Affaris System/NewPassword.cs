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
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage obj = new HomePage();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill the form completely");
            }
            if(textBox1.Text != "")
            {
                if(textBox2.Text != textBox1.Text)
                {
                    MessageBox.Show("Your Confirmation Password is not same");
                }
            }
            if(textBox1.Text != "" && textBox2.Text != "" && textBox2.Text == textBox1.Text)
            {
                StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
                StudentsAffairsSystem.NewTeachersPassword(textBox2.Text);
                StudentsAffairsSystem.NewStudentsPassword(textBox2.Text);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
