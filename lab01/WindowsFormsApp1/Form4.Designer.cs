namespace WindowsFormsApp1
{
    partial class Form4
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
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThuchien = new System.Windows.Forms.Button();
            this.lbKetqua = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFrom
            // 
            this.cbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Hexan"});
            this.cbFrom.Location = new System.Drawing.Point(411, 204);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(161, 45);
            this.cbFrom.TabIndex = 0;
            // 
            // cbTo
            // 
            this.cbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Hexan"});
            this.cbTo.Location = new System.Drawing.Point(711, 204);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(152, 45);
            this.cbTo.TabIndex = 1;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(152, 97);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(210, 37);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Nhập một số:";
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(411, 97);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(452, 40);
            this.tbInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sang";
            // 
            // btnThuchien
            // 
            this.btnThuchien.BackColor = System.Drawing.Color.Blue;
            this.btnThuchien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuchien.ForeColor = System.Drawing.Color.White;
            this.btnThuchien.Location = new System.Drawing.Point(411, 319);
            this.btnThuchien.Name = "btnThuchien";
            this.btnThuchien.Size = new System.Drawing.Size(245, 77);
            this.btnThuchien.TabIndex = 6;
            this.btnThuchien.Text = "Thực hiện";
            this.btnThuchien.UseVisualStyleBackColor = false;
            this.btnThuchien.Click += new System.EventHandler(this.btnThuchien_Click);
            // 
            // lbKetqua
            // 
            this.lbKetqua.AutoSize = true;
            this.lbKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetqua.Location = new System.Drawing.Point(247, 458);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(136, 37);
            this.lbKetqua.TabIndex = 7;
            this.lbKetqua.Text = "Kết quả:";
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(411, 458);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(452, 40);
            this.tbOutput.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(699, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 77);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.lbKetqua);
            this.Controls.Add(this.btnThuchien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbFrom);
            this.Name = "Form4";
            this.Text = "Hệ cơ số";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThuchien;
        private System.Windows.Forms.Label lbKetqua;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button button1;
    }
}