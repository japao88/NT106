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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }



        private void btnThuchien_Click(object sender, EventArgs e)
        {
            try
            {
                string input = tbInput.Text.Trim();
                string from = cbFrom.Text;
                string to = cbTo.Text;

                if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
                {
                    MessageBox.Show("Vui lòng chọn hệ cơ số nguồn và đích.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

 
                if (!TryConvertInput(input, from, out int num))
                    return;

                string result = ConvertOutput(num, to);
                if (result == null)
                {
                    MessageBox.Show("Hệ cơ số đích không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tbOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryConvertInput(string input, string fromBase, out int num)
        {
            num = 0;
            try
            {
                switch (fromBase)
                {
                    case "Binary":
                        num = Convert.ToInt32(input, 2);
                        break;
                    case "Hexan":
                        num = Convert.ToInt32(input, 16);
                        break;
                    case "Decimal":
                        num = int.Parse(input);
                        break;
                    default:
                        MessageBox.Show("Hệ cơ số nguồn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                }
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show($"Dữ liệu nhập không hợp lệ với hệ {fromBase}.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Giá trị nhập vượt quá giới hạn cho phép.", "Lỗi tràn số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string ConvertOutput(int num, string toBase)
        {
            switch (toBase)
            {
                case "Binary":
                    return Convert.ToString(num, 2);
                case "Hexan":
                    return Convert.ToString(num, 16).ToUpper();
                case "Decimal":
                    return num.ToString();
                default:
                    return null;
            }
        }
    }
}
