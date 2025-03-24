using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string[] so = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

        string DocBaSo(int num, bool docDayDu = false)
        {
            int tram = num / 100;
            int chuc = (num % 100) / 10;
            int donvi = num % 10;

            string result = "";

            if (tram != 0)
                result += so[tram] + " trăm ";
            else if (docDayDu && (chuc != 0 || donvi != 0))
                result += "không trăm ";

            if (chuc != 0)
            {
                if (chuc == 1)
                    result += "mười ";
                else
                    result += so[chuc] + " mươi ";
            }
            else if (donvi != 0)
                result += "lẻ ";

            if (donvi != 0)
            {
                if (chuc != 0 && donvi == 1)
                    result += "mốt";
                else if (donvi == 5 && chuc != 0)
                    result += "lăm";
                else
                    result += so[donvi];
            }

            return result.Trim();
        }


        string DocSo(int num)
        {
            if (num == 0) return "Không";
            if (num < 0) return "Âm " + DocSo(-num);

            string[] donviNhom = { "", "nghìn", "triệu", "tỷ" };
            string result = "";
            int i = 0;

            while (num > 0)
            {
                int block = num % 1000;
                if (block != 0)
                {
                    bool docDayDu = (i != 0);
                    string text = DocBaSo(block, docDayDu);
                    result = text + " " + donviNhom[i] + " " + result;
                }
                num /= 1000;
                i++;
            }

            return result.Trim();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbtInput.Text, out int num))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }
            tbtKetqua.Text = DocSo(num);
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

        private void tbtKetqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
