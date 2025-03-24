using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }
    }
}
