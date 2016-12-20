namespace Client
{
    partial class Cửa_Sổ_Chat
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.men = new System.Windows.Forms.RadioButton();
            this.animal = new System.Windows.Forms.RadioButton();
            this.alien = new System.Windows.Forms.RadioButton();
            this.lady = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(71, 118);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(128, 20);
            this.txtUser.TabIndex = 12;
            this.txtUser.Text = "Mai Thi";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(2, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "User Name:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(205, 114);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 26);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Chọn Phòng";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(5, 154);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(275, 196);
            this.txtLog.TabIndex = 15;
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(5, 358);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(194, 20);
            this.txtMessage.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(205, 356);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(2, 19);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(119, 13);
            this.lblServer.TabIndex = 10;
            this.lblServer.Text = "Danh sách các phòng :";
            // 
            // men
            // 
            this.men.AutoSize = true;
            this.men.Location = new System.Drawing.Point(36, 46);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(77, 17);
            this.men.TabIndex = 16;
            this.men.TabStop = true;
            this.men.Text = "Men Room";
            this.men.UseVisualStyleBackColor = true;
            // 
            // animal
            // 
            this.animal.AutoSize = true;
            this.animal.Location = new System.Drawing.Point(36, 78);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(87, 17);
            this.animal.TabIndex = 17;
            this.animal.TabStop = true;
            this.animal.Text = "Animal Room";
            this.animal.UseVisualStyleBackColor = true;
            // 
            // alien
            // 
            this.alien.AutoSize = true;
            this.alien.Location = new System.Drawing.Point(160, 76);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(79, 17);
            this.alien.TabIndex = 18;
            this.alien.TabStop = true;
            this.alien.Text = "Alien Room";
            this.alien.UseVisualStyleBackColor = true;
            // 
            // lady
            // 
            this.lady.AutoSize = true;
            this.lady.Location = new System.Drawing.Point(160, 46);
            this.lady.Name = "lady";
            this.lady.Size = new System.Drawing.Size(79, 17);
            this.lady.TabIndex = 19;
            this.lady.TabStop = true;
            this.lady.Text = "Lady Room";
            this.lady.UseVisualStyleBackColor = true;
            // 
            // Cửa_Sổ_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 395);
            this.Controls.Add(this.lady);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.men);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnConnect);
            this.Name = "Cửa_Sổ_Chat";
            this.Text = "Cửa_Sổ_Chat";
            this.Load += new System.EventHandler(this.Cửa_Sổ_Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.RadioButton men;
        private System.Windows.Forms.RadioButton animal;
        private System.Windows.Forms.RadioButton alien;
        private System.Windows.Forms.RadioButton lady;
    }
}