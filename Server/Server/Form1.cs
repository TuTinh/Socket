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
using MaterialSkin;
using MaterialSkin.Controls;

namespace Server
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
            manager.ColorScheme = new ColorScheme(Primary.BlueGrey200, Primary.Blue700, Primary.Blue700, Accent.LightBlue700, TextShade.BLACK);
            Connect();
        }

        IPEndPoint IP;  //IP của Server để Client kết nối
        Socket Server; 
        List<Socket> ListClient; // danh sách các client
        string NameServer = "Server : ";
        public string Message;

        //Đóng kết nối
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        ///  gui cho tat ca cac Client
      
        // Ket noi
        void Connect()
        {
            ListClient = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any,7421);
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);      
            Server.Bind(IP);  //Doi IP cua any client nao

            // thread : da luong
            Thread Listen = new Thread(() =>
              {
                  try
                  {
                      while (true)
                      {
                          Server.Listen(100);  // toi da 100 client
                          Socket client = Server.Accept(); // client dc accept
                          ListClient.Add(client); //add client duoc accept vao ListClient
                          Thread receive = new Thread(Receive);
                          receive.IsBackground = true;
                          receive.Start(client);
                      }
                  }
                  catch
                  {
                      IP = new IPEndPoint(IPAddress.Any, 7421);
                      Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                  }
              });
            Listen.IsBackground = true;
            Listen.Start();
                
        }

        new void Close()
        {
            Server.Close();
        }

        //Gui
        void Send(Socket server)
        {
            if (server != null && txbMesseger.Text != string.Empty)
            {
                Message = NameServer + txbMesseger.Text;
                server.Send(Serialize(Message));
            }       
        }

        // Nhan
        void Receive(object obj)
        {
            Socket server = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    server.Receive(data);  // 
                    ///  chuyen byte -> messeger
                    string messeger = (string)Deserialize(data);
                    string[] A = new string[2];
                    A = messeger.Split(':');
                    if (A[1] == " Đã kết nối")
                        AddNameClient(A[0]);

                    //gui messeger toi tat ca Client con lai
                    foreach (Socket item in ListClient)
                    {
                        if (item != null && item != server)
                            item.Send(Serialize(messeger));  //chuyen messeger ->byte xong moi Send
                    }
                    // add messger vao khung chat
                    AddMesseger(messeger);
                }
            }
            catch
            {
                ListClient.Remove(server);
                server.Close();
            }
        }
        // add messeger
        void AddMesseger(string s)
        {
            listBox1.Items.Add(s);
        }

        void AddNameClient(string name)
        {
            ListBoxClient.Items.Add(name);
        }
        // chuan hoa string -> byte
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
            BinaryFormatter format = new BinaryFormatter();
            return format.Deserialize(stream);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddMesseger("Server sẵn sàng kết nối");
            //GetIPandName(textBox_IP.Text, textBox_Host.Text);
            textBox_Host.Text = Dns.GetHostName();
            IPHostEntry iphostentry = Dns.GetHostByName(textBox_Host.Text);
            foreach (IPAddress IPname in iphostentry.AddressList)
            {
                textBox_IP.Text += IPname.ToString();
            }
        }

    
        private void lollipopBtnSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in ListClient)
            {
                Send(item);
            }
            Message = NameServer + txbMesseger.Text;
            AddMesseger(Message);
            txbMesseger.Clear();
        }
    }
}
