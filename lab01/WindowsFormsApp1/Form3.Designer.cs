namespace WindowsFormsApp1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbtInput = new System.Windows.Forms.TextBox();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.tbtKetqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập vào số nguyên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbtInput
            // 
            this.tbtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtInput.Location = new System.Drawing.Point(518, 87);
            this.tbtInput.Name = "tbtInput";
            this.tbtInput.Size = new System.Drawing.Size(507, 56);
            this.tbtInput.TabIndex = 1;
            this.tbtInput.TextChanged += new System.EventHandler(this.tbtInput_TextChanged);
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.Blue;
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.ForeColor = System.Drawing.Color.White;
            this.btnDoc.Location = new System.Drawing.Point(173, 258);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(231, 85);
            this.btnDoc.TabIndex = 2;
            this.btnDoc.Text = "Đọc";
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(518, 258);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(243, 85);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(882, 258);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(255, 85);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.Location = new System.Drawing.Point(106, 488);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(154, 42);
            this.lblKetqua.TabIndex = 5;
            this.lblKetqua.Text = "Kết quả";
            // 
            // tbtKetqua
            // 
            this.tbtKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtKetqua.Location = new System.Drawing.Point(314, 476);
            this.tbtKetqua.Name = "tbtKetqua";
            this.tbtKetqua.Size = new System.Drawing.Size(882, 44);
            this.tbtKetqua.TabIndex = 6;
            this.tbtKetqua.TextChanged += new System.EventHandler(this.tbtKetqua_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 599);
            this.Controls.Add(this.tbtKetqua);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.tbtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Đọc số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtInput;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.TextBox tbtKetqua;
    }
}