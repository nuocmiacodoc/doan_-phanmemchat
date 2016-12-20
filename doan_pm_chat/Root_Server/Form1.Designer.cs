namespace Root_Server
{
    partial class Form1
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
            this.ip = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.batdau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(70, 44);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(95, 20);
            this.ip.TabIndex = 0;
            this.ip.Text = "127.0.0.1";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(70, 85);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(95, 20);
            this.port.TabIndex = 1;
            this.port.Text = "20000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP :";
            // 
            // lol
            // 
            this.lol.AutoSize = true;
            this.lol.Location = new System.Drawing.Point(11, 85);
            this.lol.Name = "lol";
            this.lol.Size = new System.Drawing.Size(32, 13);
            this.lol.TabIndex = 3;
            this.lol.Text = "Port :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quản lí kết nối :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 82);
            this.listBox1.TabIndex = 5;
            // 
            // batdau
            // 
            this.batdau.Location = new System.Drawing.Point(200, 50);
            this.batdau.Name = "batdau";
            this.batdau.Size = new System.Drawing.Size(76, 48);
            this.batdau.TabIndex = 6;
            this.batdau.Text = "Bắt Đầu";
            this.batdau.UseVisualStyleBackColor = true;
            this.batdau.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 251);
            this.Controls.Add(this.batdau);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ip);
            this.Name = "Form1";
            this.Text = "Root Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button batdau;
    }
}

