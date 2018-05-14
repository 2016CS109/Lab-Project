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
    public partial class ApproveRequestsTeachers : Form
    {
        public ApproveRequestsTeachers()
        {
            InitializeComponent();
        }
      
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            BindingSource Source = new BindingSource();
            Source.DataSource = StudentsAffairsSystem.SearchDeptteacher(comboBox5.Text);
            dataGridView3.DataSource = Source;
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            BindingSource Source = new BindingSource();
            Source.DataSource = StudentsAffairsSystem.SearchDeptteacher(comboBox5.Text);
            dataGridView3.DataSource = Source;

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            StudentsAffairsSystem.AddApproveTeacherstoList(textBox1.Text);
            textBox1.Text = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPageAfterLogin obj = new AdminPageAfterLogin();
            obj.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
