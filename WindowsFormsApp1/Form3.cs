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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            int Num;
            if (!Int32.TryParse(tbtInput.Text, out Num) ||!(Num<9&& Num>0))
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (Num) {

                    case 0: tbtKetqua.Text="Không"; break;
                    case 1: tbtKetqua.Text="Một"; break;
                    case 2: tbtKetqua.Text="Hai"; break;
                    case 3: tbtKetqua.Text="Ba"; break;
                    case 4: tbtKetqua.Text="Bốn"; break;
                    case 5: tbtKetqua.Text="Năm"; break;
                    case 6: tbtKetqua.Text="Sáu"; break;
                    case 7: tbtKetqua.Text="Bảy"; break;
                    case 8: tbtKetqua.Text="Tám"; break;
                    case 9: tbtKetqua.Text="Chín"; break;
                }
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbtInput.Text = tbtKetqua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
