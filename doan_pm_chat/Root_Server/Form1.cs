using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Threading;
using System.Collections;
using System.Net;
using System.Net.Sockets;


namespace Root_Server
{
    public partial class Form1 : Form
    {
        private ArrayList Users;
        private ArrayList SocketList;
        private user temp;
        private string checkStatus;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users = new ArrayList();
            load_Data();
            SocketList = new ArrayList();
            batdau.Enabled = false;
            Thread threadListener = new Thread(new ThreadStart(listenerThread));
            threadListener.IsBackground = true;
            threadListener.Start();
        }

        public void listenerThread()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, int.Parse(port.Text));
            tcpListener.Start();
            while (true)
            {
                Socket handler = tcpListener.AcceptSocket();
                if (handler.Connected)
                {
                    listBox1.Items.Add("Client " + handler.RemoteEndPoint.ToString() + " Conneted");
                    lock (this)
                    {
                        SocketList.Add(handler);
                    }
                    Thread handle_Request = new Thread(new ThreadStart(handleRequest));
                    handle_Request.IsBackground = true;
                    handle_Request.Start();
                }
            }
        }

 //---------------------------------------------------------------------------------------------------
        //tra ve 0 neu khac nau, tra ve 1 neu bang nhau
        public void handleRequest()
        {
            Socket handler = (Socket)SocketList[SocketList.Count - 1];
            NetworkStream stm = new NetworkStream(handler);
            byte[] byteReceive = new Byte[100];
            stm.Read(byteReceive, 0, 100);
            string str = Encoding.ASCII.GetString(byteReceive);
            temp = splitString1(str);
            if (checkStatus == "dangnhap")
                xuli_DangNhap(stm,str);
            else
                xuli_DangKi(stm,str);
        }
//xu li dang nhap
        public void xuli_DangNhap(NetworkStream stm,string str)
        {
            byte[] byteSend;
            temp = splitString1(str);
            int a = compare_User1(temp.name, temp.password);
            if (a == 0)
            {
                byteSend = Encoding.ASCII.GetBytes("0");
                stm.Write(byteSend, 0, byteSend.Length);
                
            }
            else
            {
                byteSend = Encoding.ASCII.GetBytes("1");
                stm.Write(byteSend, 0, byteSend.Length);
            }
        }
//xu li dang ki
        public void xuli_DangKi(NetworkStream stm, string str)
        {
            byte[] byteSend;
            temp = splitString2(str);
            if (compare_User2(temp.name) == 0)
            {
                byteSend = Encoding.ASCII.GetBytes("0");
                stm.Write(byteSend, 0, byteSend.Length);
                user nguoidung = new user();
                nguoidung = temp;
                Users.Add(nguoidung);
                import_Data(temp.name, temp.password, temp.gioitinh);
            }
            else
            {
                byteSend = Encoding.ASCII.GetBytes("1");
                stm.Write(byteSend, 0, byteSend.Length);
            }
        }






//-----------------------------------------------------------------------------------------------------
//cac ham xu li chuoi
        public user splitString1(string str)
        {
            user nguoidung = new user();
            string[] chuoi = str.Split(',');
            checkStatus = chuoi[0];
            nguoidung.name = chuoi[1];
            nguoidung.password = chuoi[2];
            return nguoidung;
        }

        public user splitString2(string str)
        {
            user nguoidung = new user();
            string[] chuoi = str.Split(',');
            checkStatus = chuoi[0];
            nguoidung.name = chuoi[1];
            nguoidung.password = chuoi[2];
            nguoidung.gioitinh = chuoi[3];
            return nguoidung;
        }
//-------------------------------------------------------------------------------------------------------
        //Các hàm hàm làm việc với database
        public void load_Data()
        {
            FileStream database = new FileStream(@"C:\Users\Mai Thi\Desktop\database.txt", FileMode.Open);
            SoapFormatter sf = new SoapFormatter();

            string path = @"C:\Users\Mai Thi\Desktop\dsUser.txt";
            if (File.Exists(path))
                File.Delete(path);

            FileStream dsUser = new FileStream(path, FileMode.Append);
            try
            {
                user nguoidung = (user)sf.Deserialize(database);
                StreamWriter sw = new StreamWriter(dsUser);
                sw.WriteLine(nguoidung.name + "   " + nguoidung.password + "   ");
                sw.Flush();
                while (nguoidung != null)
                {
                    try
                    {
                        Users.Add(nguoidung);
                        nguoidung = (user)sf.Deserialize(database);
                        sw.WriteLine(nguoidung.name + "   " + nguoidung.password + "   ");
                        sw.Flush();
                    }
                    catch (Exception)
                    {
                        nguoidung = null;
                    }
                }
            }
            catch (Exception)
            { }

            dsUser.Close();
            database.Close();
        }
        public void import_Data(string user_name,string user_password,string user_sex)
        {
            try
            {
                FileStream database = new FileStream(@"C:\Users\Mai Thi\Desktop\database.txt", FileMode.Append);
                user nguoidung = new user();
                nguoidung.name = user_name;
                nguoidung.password = user_password;
                nguoidung.gioitinh = user_sex;
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(database, nguoidung);
                database.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //bang nhau thi tra ve 1, khac nhau tra ve 0
        public int compare_User1(string user_name, string user_password)
        {
            user nguoidung = new user();
            for (int i = 0; i < Users.Count; i++)
            {
                nguoidung = (user)Users[i];
                //MessageBox.Show(nguoidung.name+nguoidung.password+"  "+user_name +user_password);
                int a =string.Compare(nguoidung.name, user_name);
                int b = string.Compare(nguoidung.password,user_password);
                //MessageBox.Show(""+a);
                if (a == 0 && b == 0 )
                { 
                    //if (int.Parse(nguoidung.password) == int.Parse(user_password))
                    return 1;
                }
            }
            return 0;
        }
        public int compare_User2(string user_name)
        {
            user nguoidung = new user();
            for (int i = 0; i < Users.Count; i++)
            {
                nguoidung = (user)Users[i];
                //MessageBox.Show(nguoidung.name + "  " + user_name);
                if (nguoidung.name == user_name)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
//khong the so sanh chuoi so tren C#
