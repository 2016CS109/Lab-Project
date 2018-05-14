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
    public partial class AllUploadedImages : Form
    {
        public AllUploadedImages()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UploadImages obj = new UploadImages();
            obj.Show();
            this.Hide();
        }

        private void AllUploadedImages_Load(object sender, EventArgs e)
        {
        }
    }
}
