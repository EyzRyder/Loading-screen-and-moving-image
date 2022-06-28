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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbj_splah.Value<100)
            {
                pbj_splah.Value = pbj_splah.Value+2;
            } 
            else {
                timer1.Enabled = false;
                this.Visible = false;
                Form2 visivel = new Form2("wellCUM");
                visivel.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbj_splah_Click(object sender, EventArgs e)
        {

        }
    }
}
