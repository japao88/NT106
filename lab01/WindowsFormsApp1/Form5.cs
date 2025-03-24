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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text.Trim();
            string[] parts = input.Split(',');
            List<double> scores = new List<double>();

            foreach (string part in parts)
            {
                if (double.TryParse(part, out double score))
                {
                    if (score < 0 || score > 10)
                    {
                        MessageBox.Show("Điểm phải nằm trong khoảng 0 đến 10.");
                        return;
                    }
                    scores.Add(score);
                }
                else
                {
                    MessageBox.Show($"Dữ liệu không hợp lệ: \"{part}\"");
                    return;
                }
            }

            lbDanhSach.Items.Clear();
            for (int i = 0; i < scores.Count; i++)
            {
                lbDanhSach.Items.Add($"Môn {i + 1}: {scores[i]}đ");
            }

            double avg = scores.Average();
            lblDTB.Text = $"Điểm trung bình: {avg:F2}";

            double max = scores.Max();
            double min = scores.Min();
            lblMax.Text = $"Môn có điểm cao nhất: {max}đ";
            lblMin.Text = $"Môn có điểm thấp nhất: {min}đ";


            int passed = scores.Count(s => s >= 5);
            lblDau.Text = $"Số môn đậu: {passed}";

            int failed = scores.Count(s => s < 5);
            lblRot.Text = $"Số môn rớt: {failed}";

            string rank;
            bool hasBelow2 = scores.Any(s => s < 2);
            bool hasBelow3_5 = scores.Any(s => s < 3.5);
            bool hasBelow5 = scores.Any(s => s < 5);
            bool hasBelow6_5 = scores.Any(s => s < 6.5);


            if (avg >= 8 && !hasBelow6_5)
                rank = "Giỏi";
            else if (avg >= 6.5 && !hasBelow5)
                rank = "Khá";
            else if (avg >= 5 && !hasBelow3_5)
                rank = "TB";
            else if (avg >= 3.5 && !hasBelow2)
                rank = "Yếu";
            else
                rank = "Kém";

            lblXepLoai.Text = $"Xếp loại học lực: {rank}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblSoMonD_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
