namespace Client
{
    partial class DangKi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gtNam = new System.Windows.Forms.RadioButton();
            this.gtNu = new System.Windows.Forms.RadioButton();
            this.ten = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.dk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính :";
            // 
            // gtNam
            // 
            this.gtNam.AutoSize = true;
            this.gtNam.Checked = true;
            this.gtNam.Location = new System.Drawing.Point(109, 137);
            this.gtNam.Name = "gtNam";
            this.gtNam.Size = new System.Drawing.Size(47, 17);
            this.gtNam.TabIndex = 3;
            this.gtNam.TabStop = true;
            this.gtNam.Text = "Nam";
            this.gtNam.UseVisualStyleBackColor = true;
            // 
            // gtNu
            // 
            this.gtNu.AutoSize = true;
            this.gtNu.Location = new System.Drawing.Point(190, 137);
            this.gtNu.Name = "gtNu";
            this.gtNu.Size = new System.Drawing.Size(39, 17);
            this.gtNu.TabIndex = 4;
            this.gtNu.Text = "Nữ\r\n";
            this.gtNu.UseVisualStyleBackColor = true;
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(109, 61);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(120, 20);
            this.ten.TabIndex = 5;
            this.ten.Text = "mai thi";
            // 
            // matkhau
            // 
            this.matkhau.Location = new System.Drawing.Point(109, 99);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(120, 20);
            this.matkhau.TabIndex = 6;
            this.matkhau.Text = "14520860";
            // 
            // dk
            // 
            this.dk.Location = new System.Drawing.Point(121, 176);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(87, 26);
            this.dk.TabIndex = 7;
            this.dk.Text = "Đăng kí";
            this.dk.UseVisualStyleBackColor = true;
            this.dk.Click += new System.EventHandler(this.dk_Click);
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 232);
            this.Controls.Add(this.dk);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.gtNu);
            this.Controls.Add(this.gtNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangKi";
            this.Text = "Đăng Kí";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton gtNam;
        private System.Windows.Forms.RadioButton gtNu;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Button dk;
    }
}