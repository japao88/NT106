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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] num= new double[3];
            if (!double.TryParse(tbNum1.Text.Trim(), out num[0]) || !double.TryParse(tbNum2.Text.Trim(), out num[1])|| !double.TryParse(tbNum3.Text.Trim(), out num[2]))
            {
                MessageBox.Show("Vui lòng nhập số","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Array.Sort(num);
                tbMax.Text = num[2].ToString();
                tbMin.Text = num[0].ToString();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbNum1.Text = tbNum2.Text = tbNum3.Text = tbMax.Text = tbMin.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbMin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
