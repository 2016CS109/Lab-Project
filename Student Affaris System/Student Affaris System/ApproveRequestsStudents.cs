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
    }
}
