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
    public partial class UserLoginPage : Form
    {
        public UserLoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            int userisvalid;
            bool isvalidpassed;
            int userisvalid1;
            bool isvalidpassed1;
            StudentsAffairsSystem.isvalidstudent(textBox3.Text, textBox2.Text, out userisvalid, out isvalidpassed);
            StudentsAffairsSystem.isvalidteacher(textBox3.Text, textBox2.Text, out userisvalid1, out isvalidpassed1);
            bool TeacherApproved;
            bool isvalidTeacher;
            StudentsAffairsSystem.CheckApproveTeachers(textBox3.Text, out TeacherApproved, out isvalidTeacher);
            bool StudentApproved;
            bool isvalidStudent;
            StudentsAffairsSystem.CheckApproveStudents(textBox3.Text, out StudentApproved, out isvalidStudent);
            if(userisvalid == 2 || userisvalid == 3)
            {
                if (StudentApproved)
                {
                    if (userisvalid == 2)
                    {
                        StudentsAffairsSystem.AddStudentDeptTeacherstoList(textBox3.Text);
                        StudentsAffairsSystem.AddStudentstoProfileList(textBox3.Text);
                        MessageBox.Show("valid user");
                        CRPageAfterLogin obj = new CRPageAfterLogin();
                        obj.Show();
                        this.Hide();
                    }
                    if (userisvalid == 3)
                    {
                        StudentsAffairsSystem.AddStudentstoProfileList(textBox3.Text);
                        MessageBox.Show("valid user");
                        StudentPageAfterLogin obj = new StudentPageAfterLogin();
                        obj.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Your Registeration Request are not approved by Admin");
                    textBox3.Text = null;
                    textBox2.Text = null;
                }
            }

            if(userisvalid1 == 1)
            {
                if (TeacherApproved)
                {
                    StudentsAffairsSystem.AddTeacherstoProfileList(textBox3.Text);
                    StudentsAffairsSystem.AddTeachersDeptStudentstoList(textBox3.Text);
                    MessageBox.Show("valid user");
                    TeacherPageAfterLogin obj = new TeacherPageAfterLogin();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your Registeration Request are not approved by Admin");
                    textBox3.Text = null;
                    textBox2.Text = null;
                }
            }
            if(userisvalid != 2 && userisvalid != 3 && userisvalid1 != 1)
            {
                MessageBox.Show("Invalid User!");
                textBox3.Text = null;
                textBox2.Text = null;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage obj = new HomePage();
            obj.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            StudentsAffairsSystem.ResetTeachersPasswordList(textBox3.Text);
            StudentsAffairsSystem.ResetStudentsPasswordList(textBox3.Text);
            ResetPassword obj = new ResetPassword();
            obj.Show();
            this.Hide();
        }
    }
}
