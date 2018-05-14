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
    public partial class CRPageAfterLogin : Form
    {
        public CRPageAfterLogin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            BindingSource Source = new BindingSource();
            Source.DataSource = StudentsAffairsSystem.ShowStudentDeptTeachers();
            dataGridView1.DataSource = Source;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddAnnoucement obj = new AddAnnoucement();
            obj.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage obj = new HomePage();
            obj.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UploadImages obj = new UploadImages();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CRPageAfterLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            BindingSource Source = new BindingSource();
            Source.DataSource = StudentsAffairsSystem.ShowStudentDeptTeachers();
            dataGridView1.DataSource = Source;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            List<StudentsAffairsSystemServer.InformationStudent> obj1 = new List<StudentsAffairsSystemServer.InformationStudent>();
            obj1 = StudentsAffairsSystem.SpecificStudentsProfile().ToList();
            foreach (StudentsAffairsSystemServer.InformationStudent obj in obj1)
            {
                textBox1.Text = obj.UserName;
                textBox3.Text = obj.ContactNumber;
                textBox7.Text = obj.Department;
                textBox2.Text = obj.EmailId;
                textBox4.Text = obj.RegisterationNumber;
                textBox6.Text = obj.Section;
                textBox5.Text = obj.StudentCategory;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
