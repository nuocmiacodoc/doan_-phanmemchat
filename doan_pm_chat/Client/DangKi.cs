using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

        private void dk_Click(object sender, EventArgs e)
        {
            string gt;
            ClientSocket tcp_Client = new ClientSocket();
            tcp_Client.initTCPClient("localhost", 20000);
            tcp_Client.connectToServer();

            if (this.gtNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nu";

            string str = "dangki"+","+ten.Text + "," + matkhau.Text+","+gt;
            tcp_Client.sendData(str);
            string result = tcp_Client.receiveData();
            //MessageBox.Show(result);
            if (int.Parse(result) == 0)
            {
                MessageBox.Show("Đăng kí thành công!");
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã được sử dụng!\nVui lòng chọn lại tên khác.");
                tcp_Client.closeConnection();
            }
        }
    }
}
