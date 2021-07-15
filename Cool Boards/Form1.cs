using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cool_Boards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Show();
            label3.Show();
            label5.Text = "Tricia Mills";
            label5.Refresh();
            label4.Text = "500-1111";
            label4.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Show();
            label3.Show();
            label5.Text = "Mon - Sun: 10:00 AM to 12:00 AM";
            label5.Refresh();
            label4.Text = "2460 Burwell Heights Road";
            label4.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Show();
            label3.Show();
            label5.Text = "Mon - Fri: 8:00 AM to 8:00 PM";
            label5.Refresh();
            label4.Text = "3151 Rockford Road";
            label4.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Show();
            label3.Show();
            label5.Text = "Mon - Sat: 10:00 AM to 10:00 PM";
            label5.Refresh();
            label4.Text = "2857 Eastland Avenue";
            label4.Refresh();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
