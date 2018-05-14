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
    public partial class ApproveRequestsStudents : Form
    {
        public ApproveRequestsStudents()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPageAfterLogin obj = new AdminPageAfterLogin();
            obj.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            BindingSource Source = new BindingSource();
            Source.DataSource = StudentsAffairsSystem.SearchDeptstudent(comboBox1.Text);
            dataGridView1.DataSource = Source;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            BindingSource Source = new BindingSource();
            Source.DataSource = StudentsAffairsSystem.SearchDeptstudent(comboBox1.Text);
            dataGridView1.DataSource = Source;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            StudentsAffairsSystem.AddApproveStudentstoList(textBox1.Text);
            textBox1.Text = null;
        }
    }
}
