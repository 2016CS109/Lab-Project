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
    public partial class TeacherPageAfterLogin : Form
    {
        public TeacherPageAfterLogin()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddAnnoucement obj = new AddAnnoucement();
            obj.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage obj = new HomePage();
            obj.Show();
            this.Hide();
        }

        private void ShowDeptStudents_Click(object sender, EventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            BindingSource Source = new BindingSource();
            Source.DataSource = StudentsAffairsSystem.ShowTeachersDeptStudents();
            dataGridView1.DataSource = Source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            BindingSource Source = new BindingSource();
            Source.DataSource = StudentsAffairsSystem.ShowTeachersDeptStudents();
            dataGridView1.DataSource = Source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            List<StudentsAffairsSystemServer.InformationTeacher> obj1 = new List<StudentsAffairsSystemServer.InformationTeacher>();
            obj1 = StudentsAffairsSystem.SpecificTeachersProfile().ToList();
            foreach(StudentsAffairsSystemServer.InformationTeacher obj in obj1)
            {
                textBox1.Text =  obj.UserName;
                textBox3.Text =  obj.ContactNumber;
                textBox2.Text = obj.EmailId;
                textBox4.Text =  obj.Department;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
