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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int iNum1, iNum2;
            int sum = 0;


            if (!Int32.TryParse(tbSo2.Text, out iNum2)|| !Int32.TryParse(tbSo1.Text, out iNum1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                sum = iNum1 + iNum2;
                tbKetqua.Text = sum.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbSo1.Clear();
            tbSo2.Clear();
            tbKetqua.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
