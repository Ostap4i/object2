using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace летючий_обєкт
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
            timer2.Interval = 500;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point point = Point.Add(pictureBox1.Location, new Size(5, 0));

            pictureBox1.Location = point;



        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
    
       
    }
}
