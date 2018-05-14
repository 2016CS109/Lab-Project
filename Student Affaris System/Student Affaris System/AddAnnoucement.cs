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
    public partial class AddAnnoucement : Form
    {
        public AddAnnoucement()
        {
            InitializeComponent();
        }

        private void AddAnnoucement_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            StudentsAffairsSystem.AddAnnoucementstolist(textBox1.Text);
            textBox1.Text = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewAnnoucement obj = new ViewAnnoucement();
            obj.Show();
            this.Hide();
        }
    }
}
