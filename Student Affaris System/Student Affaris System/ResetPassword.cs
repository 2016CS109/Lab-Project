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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            bool testpass;
            bool isvalidpass;
            bool testpass1;
            bool isvalidpass1;
            StudentsAffairsSystem.ChkTeachersSecretQuest(comboBox1.Text, textBox1.Text, out testpass, out isvalidpass);
            StudentsAffairsSystem.ChkStudentsSecretQuest(comboBox1.Text, textBox1.Text, out testpass1, out isvalidpass1);
            if(testpass || testpass1)
            {
                NewPassword obj = new NewPassword();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your Secret Anwers are not correct");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage obj = new HomePage();
            obj.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
