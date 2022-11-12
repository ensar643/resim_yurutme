using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resim_yurutme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.Left = pictureBox3.Left + 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox3.Left = pictureBox3.Left + 100;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox4.Left = pictureBox4.Left + 10;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox4.Left = pictureBox4.Left + 100;
        }
    }
}
