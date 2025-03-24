namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNum1 = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.lbNum3 = new System.Windows.Forms.Label();
            this.tbNum3 = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(29, 54);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(182, 37);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Số thứ nhất";
            // 
            // tbNum1
            // 
            this.tbNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum1.Location = new System.Drawing.Point(217, 47);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(146, 44);
            this.tbNum1.TabIndex = 1;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(423, 54);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(162, 37);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Số thứ hai";
            // 
            // tbNum2
            // 
            this.tbNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum2.Location = new System.Drawing.Point(591, 47);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(164, 44);
            this.tbNum2.TabIndex = 3;
            // 
            // lbNum3
            // 
            this.lbNum3.AutoSize = true;
            this.lbNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum3.Location = new System.Drawing.Point(840, 54);
            this.lbNum3.Name = "lbNum3";
            this.lbNum3.Size = new System.Drawing.Size(155, 37);
            this.lbNum3.TabIndex = 4;
            this.lbNum3.Text = "Số thứ ba";
            // 
            // tbNum3
            // 
            this.tbNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum3.Location = new System.Drawing.Point(1015, 47);
            this.tbNum3.Name = "tbNum3";
            this.tbNum3.Size = new System.Drawing.Size(164, 44);
            this.tbNum3.TabIndex = 5;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Blue;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTim.Location = new System.Drawing.Point(228, 218);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(238, 82);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(521, 218);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(216, 82);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(805, 218);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(208, 82);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(91, 439);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(191, 37);
            this.lblMax.TabIndex = 9;
            this.lblMax.Text = "Số lớn nhất";
            // 
            // tbMax
            // 
            this.tbMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMax.Location = new System.Drawing.Point(278, 432);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(174, 44);
            this.tbMax.TabIndex = 10;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(675, 439);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(202, 37);
            this.lblMin.TabIndex = 11;
            this.lblMin.Text = "Số nhỏ nhất";
            // 
            // tbMin
            // 
            this.tbMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMin.Location = new System.Drawing.Point(883, 432);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(146, 44);
            this.tbMin.TabIndex = 12;
            this.tbMin.TextChanged += new System.EventHandler(this.tbMin_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 568);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.tbNum3);
            this.Controls.Add(this.lbNum3);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form2";
            this.Text = " Số lớn nhất, số nhỏ nhất";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label lbNum3;
        private System.Windows.Forms.TextBox tbNum3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox tbMin;
    }
}