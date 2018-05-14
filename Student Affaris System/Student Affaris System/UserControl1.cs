using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Affaris_System
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(Image img)
        {
            InitializeComponent();
            pictureBox1.Image = img;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
