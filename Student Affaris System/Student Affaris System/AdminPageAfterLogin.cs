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
    public partial class AdminPageAfterLogin : Form
    {
        public AdminPageAfterLogin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApproveRequestsTeachers obj = new ApproveRequestsTeachers();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApproveRequestsStudents obj = new ApproveRequestsStudents();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage obj = new HomePage();
            obj.Show();
            this.Hide();
        }
    }
}
