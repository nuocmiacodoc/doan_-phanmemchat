namespace Client
{
    partial class DangNhap
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
            this.dn = new System.Windows.Forms.Button();
            this.ten = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.dk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu :";
            // 
            // dn
            // 
            this.dn.Location = new System.Drawing.Point(58, 120);
            this.dn.Name = "dn";
            this.dn.Size = new System.Drawing.Size(68, 23);
            this.dn.TabIndex = 2;
            this.dn.Text = "Đăng nhập";
            this.dn.UseVisualStyleBackColor = true;
            this.dn.Click += new System.EventHandler(this.dn_Click);
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(92, 35);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(125, 20);
            this.ten.TabIndex = 3;
            this.ten.Text = "MaiThi";
            // 
            // matkhau
            // 
            this.matkhau.Location = new System.Drawing.Point(92, 76);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(125, 20);
            this.matkhau.TabIndex = 4;
            this.matkhau.Text = "14520860";
            // 
            // dk
            // 
            this.dk.Location = new System.Drawing.Point(185, 120);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(65, 23);
            this.dk.TabIndex = 5;
            this.dk.Text = "Đăng Kí";
            this.dk.UseVisualStyleBackColor = true;
            this.dk.Click += new System.EventHandler(this.dk_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 155);
            this.Controls.Add(this.dk);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.dn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dn;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Button dk;
    }
}

