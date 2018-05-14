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
    public partial class UploadImages : Form
    {
        public UploadImages()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllUploadedImages obj = new AllUploadedImages();
            obj.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage obj = new HomePage();
            obj.Show();
            this.Hide();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Image img = Image.FromStream(openFileDialog1.OpenFile());
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void UploadImages_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Student_Affaris_System.Properties.Resources.Un_known;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsAffairsSystemServer.Service1 StudentsAffairsSystem = new StudentsAffairsSystemServer.Service1();
            //StudentsAffairsSystem.addimages(pictureBox1.Image);
            pictureBox1.Image = Student_Affaris_System.Properties.Resources.Un_known;
        }
    }
}
