using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TCP_Test : Form
    {
        BackgroundWorker TCP_Listener = new BackgroundWorker();
        public bool isServer = false;

        private TcpClient client;
        public TCP_Test()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }
        private void InitializeBackgroundWorker()
        {
            this.TCP_Listener.WorkerReportsProgress = true;
            this.TCP_Listener.WorkerSupportsCancellation = true;

            TCP_Listener.DoWork +=
                new DoWorkEventHandler(TCP_Listen_Loop);

            // TCP_Listener.RunWorkerCompleted +=
            //     new RunWorkerCompletedEventHandler(
            //         backgroundWorker1_RunWorkerCompleted);

            TCP_Listener.ProgressChanged +=
                new ProgressChangedEventHandler(
                    PacketRecieved);

        }

        private void ConnectTo_TCP_Server(Object sender, EventArgs e)
        {
            try
            {
                // LOOK INTO HOW TO DISPOSE OF CLIENTS AND SERVERS

                IPAddress serverIP = IPAddress.Parse(IP_Server.Text);
                IPEndPoint server = new IPEndPoint(serverIP, (int)Port_Server.Value);

                // Prefer a using declaration to ensure the instance is Disposed later.
                client = new TcpClient(server);


            }
            catch (ArgumentNullException exception)
            {
                Debug.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException exception)
            {
                Debug.WriteLine("SocketException: {0}", e);
            }
        }

        private async void SendMessage(Object sender, EventArgs e)
        {
            if (client == null)
            {
                return;
            }

            IPAddress serverIP = IPAddress.Parse(IP_Server.Text);
            IPEndPoint server = new IPEndPoint(serverIP, (int)Port_Server.Value);
            await client.ConnectAsync(server);

            var message = ClientInput.Text;
            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            // Get a client stream for reading and writing.
            await using NetworkStream stream = client.GetStream();
            // Send the message to the connected TcpServer.
            stream.Write(data, 0, data.Length);

            Console.WriteLine("Sent: {0}", message);

            // Receive the server response.

            // Buffer to store the response bytes.
            data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine("Received: {0}", responseData);
            ClientLog.Text = responseData;

            // Explicit close is not necessary since TcpClient.Dispose() will be
            // called automatically.
            // stream.Close();
            // client.Close();
        }

        private void Create_TCP_Server(Object sender, EventArgs e)
        {
            isServer = true;
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = (int)Port_Self.Value;
                IPAddress localAddr = IPAddress.Parse(IP_Self.Text);

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);


                TCP_Listener.RunWorkerAsync(server);

            }
            catch (SocketException exception)
            {
                Debug.WriteLine("SocketException: {0}", exception);
            }
        }

        private async void TCP_Listen_Loop(object sender, DoWorkEventArgs e)
        {
            TcpListener server = (TcpListener)e.Argument;

            // Start listening for client requests.
            server.Start();

            // Buffer for reading data
            Byte[] bytes = new Byte[256];
            String data = null;

            // Enter the listening loop.
            while (true)
            {
                Debug.Write("Waiting for a connection... ");

                // Perform a blocking call to accept requests.
                // You could also use server.AcceptSocket() here.
                using TcpClient client = await server.AcceptTcpClientAsync();
                Debug.WriteLine("Connected!");

                data = null;

                // Get a stream object for reading and writing
                await using NetworkStream stream = client.GetStream();

                int i;

                // Loop to receive all the data sent by the client.
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Debug.WriteLine("Received: {0}", data);

                    // Process the data sent by the client.
                    ServerLog.Text = data;
                    data = "Message Received";

                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                    // Send back a response.
                    stream.Write(msg, 0, msg.Length);
                    Debug.WriteLine("Sent: {0}", data);
                }
            }
        }

        private void PacketRecieved(object sender,
            ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(
            object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
