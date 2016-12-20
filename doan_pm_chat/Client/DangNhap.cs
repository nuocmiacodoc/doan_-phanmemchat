using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Client
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void dn_Click(object sender, EventArgs e)
        {
            
            ClientSocket tcp_Client = new ClientSocket();
            tcp_Client.initTCPClient("localhost",20000);
            tcp_Client.connectToServer();
            string str ="dangnhap"+","+ ten.Text + "," + matkhau.Text;
            tcp_Client.sendData(str);
            string result = tcp_Client.receiveData();
            //MessageBox.Show(result);
            if (int.Parse(result) == 1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Cửa_Sổ_Chat chatWindow = new Cửa_Sổ_Chat();
                chatWindow.property = ten.Text;
                chatWindow.showProperty();
                //MessageBox.Show(chatWindow.property);
                chatWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!\nVui lòng đăng nhập lại.");
                tcp_Client.closeConnection();
            }
        }

        private void dk_Click(object sender, EventArgs e)
        {
            //Thread.CurrentThread.Abort();
            DangKi dangki = new DangKi();
            dangki.Show();
            this.Close();
            
            
        }
    }
}
