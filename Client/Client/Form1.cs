using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue800, Accent.LightBlue200, TextShade.WHITE);
            //Connect();
        }
        string IPaddress ;
        IPEndPoint IP;
        Socket Client;
        public string User;
        public string Temp = " : ";
        public string Message;


        // Gui tin di
        private void lollipopBtnSend_Click(object sender, EventArgs e)
        {
            Message = User + Temp + txbMesseger.Text;
            Send();
            AddMessage(Message);
            txbMesseger.Clear();
        }

        // Connect
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse(IPaddress),7421);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                Client.Connect(IP);
            }
            catch
            {
                FormLogin fLogin = new FormLogin();
                MessageBox.Show("Không thể kết nối server !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
            Client.Send(Serialize(User + Temp + "Đã kết nối"));
        }

        new void Close()
        {
            Client.Close();
        }
        //
        void Send()
        {
            if (txbMesseger.Text != string.Empty)
            {
                Message = User + Temp + txbMesseger.Text;
                Client.Send(Serialize(Message));
            }
        }

        //
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    Client.Receive(data);

                    string s = (string)Deserialize(data);
                    AddMessage(s);
                }
            }
            catch
            {
                Close();
            }
        }

        //
        void AddMessage(string s)
        {
            listBox1.Items.Add(s);

        }

        //string -> byte
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        //byte -> string
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin fLogin = new FormLogin();
            try
            {
                this.Show();
                // AttempLogin();
                fLogin.ShowDialog(this);
                fLogin.Dispose();
                User = fLogin.textBox1.Text;
                label1.Text = User;
                IPaddress = fLogin.textBox_IP.Text;
                Connect();
               // Client.Send(Serialize(User + Temp + "Connect"));
                labelIP.Visible = true;
                labelIP.Text = Client.RemoteEndPoint.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể kết nối Server. Vui lòng thực hiện lại đăng nhập !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lollipopLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
