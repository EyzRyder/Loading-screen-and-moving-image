using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_sei
{
    public partial class Form2 : Form
    {
        public Form2(string name)
        {
            InitializeComponent();
            label1.Text = name;
            timer1.Enabled = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void car_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (car.Location.X < 500)
            {
                car.Location = new Point(car.Location.X + 10,142);
            }
            else
            {
                timer1.Enabled = false;
            }
        }
    }
}
