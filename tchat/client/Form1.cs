using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {

        static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        private TcpClient client;
        private NetworkStream stream;
        //private string Msg;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if ((client != null) && (!client.Connected)) return;


            userName = tb_user.Text;
            // host = tb_ip.Text;

            client = new TcpClient();
            client.Connect(host, port);
            stream = client.GetStream(); // получаем поток
            ///listBox1.Items.Add("Hello world!");

            string message = userName;
            byte[] data = Encoding.Unicode.GetBytes(message);
            stream.Write(data, 0, data.Length);
            // запускаем новый поток для получения данных
            Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.Start(); //старт потока


        }


        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                string message = tb_message.Text;
                if (message != "")
                {
                    SendMessage(message);
                    listBox1.Items.Add(message);
                }
                else return;

                // запускаем новый поток для получения данных
                //Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                //receiveThread.Start(); //старт потока

                //listBox1.Items.Add(Msg);
                //tb_ip.Text = message;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }


        private void ReceiveMessage()
        {
            while (true)
            {
                if (!client.Connected) return;
                try
                {
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();

                    int bytes = 0;
                    while (stream.DataAvailable)
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }


                    string message = builder.ToString();
                    if (message == "") continue;
                    Invoke((Action)(() => { listBox1.Items.Add(message); }));
                    //Msg = message;
                    //Console.WriteLine(message);//вывод сообщения
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Подключение прервано!"); //соединение было прервано
                    Console.ReadLine();
                    Disconnect();
                }
            }
        }

        private void SendMessage(string msg)
        {


            while (msg != "")
            {
                //string message = Console.ReadLine();
                byte[] data = Encoding.Unicode.GetBytes(msg);
                stream.Write(data, 0, data.Length);
                msg = "";
            }

        }

        private void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
            //Environment.Exit(0); //завершение процесса
        }
    }
}



