using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.IO;

namespace projectMessenger
{
    public partial class Form2 : Form
    {
        private static string shortFileName = "";
        private static string fileName = "";
        public delegate void FileRecievedEventHandler(object source,

  string fileName);

        public event FileRecievedEventHandler NewFileRecieved;
        public Form2()
        {
            InitializeComponent();
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }







       
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            this.NewFileRecieved += new FileRecievedEventHandler
(Form2_NewFileRecieved);
        }

        private void Form2_NewFileRecieved(object source, string fileName)
        {
            this.BeginInvoke(
             new Action(
             delegate()
             {
                 MessageBox.Show("New File Recieved\n" + fileName);
                 System.Diagnostics.Process.Start("explorer", @"D:\");
             }));
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "File Sharing Client";
            dlg.ShowDialog();
            txtFile.Text = dlg.FileName;
            fileName = dlg.FileName;
            shortFileName = dlg.SafeFileName;
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIPAddress.Text;
            int port = int.Parse(txtHost.Text);
            string fileName = txtFile.Text;
            Task.Factory.StartNew(() => SendFile(ipAddress, port,

             fileName, shortFileName));
            MessageBox.Show("File Sent");
        }
        public void SendFile(string remoteHostIP, int remoteHostPort

   , string longFileName, string shortFileName)
        {
            try
            {
                if (!string.IsNullOrEmpty(remoteHostIP))
                {
                    byte[] fileNameByte = Encoding.ASCII.GetBytes

                    (shortFileName);
                    byte[] fileData = File.ReadAllBytes(longFileName);
                    byte[] clientData = new byte[4 + fileNameByte.Length

                       + fileData.Length];
                    byte[] fileNameLen = BitConverter.GetBytes(

                     fileNameByte.Length);
                    fileNameLen.CopyTo(clientData, 0);
                    fileNameByte.CopyTo(clientData, 4);
                    fileData.CopyTo(clientData, 4 + fileNameByte.Length);
                    TcpClient clientSocket = new TcpClient(remoteHostIP,

                     remoteHostPort);
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Write(clientData, 0, clientData.GetLength

                     (0));
                    networkStream.Close();
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port = int.Parse(txtHost.Text);
            Task.Factory.StartNew(() => HandleIncomingFile(port));
            MessageBox.Show("Listening on port" + port);
        }
        public void HandleIncomingFile(int port)
        {
            try
            {
                TcpListener tcpListener = new TcpListener(port);
                tcpListener.Start();
                while (true)
                {
                    Socket handlerSocket = tcpListener.AcceptSocket();
                    if (handlerSocket.Connected)
                    {
                        string fileName = string.Empty;
                        NetworkStream networkStream = new NetworkStream

                         (handlerSocket);
                        int thisRead = 0;
                        int blockSize = 1024;
                        Byte[] dataByte = new Byte[blockSize];
                        lock (this)
                        {
                            string folderPath = @"D:\";
                            handlerSocket.Receive(dataByte);
                            int fileNameLen = BitConverter.ToInt32(dataByte,

                             0);
                            fileName = Encoding.ASCII.GetString(dataByte, 4,

                             fileNameLen);
                            Stream fileStream = File.OpenWrite(folderPath +

                             fileName);
                            fileStream.Write(dataByte, 4 + fileNameLen, (

                             1024 - (4 + fileNameLen)));
                            while (true)
                            {
                                thisRead = networkStream.Read(dataByte, 0,

                                 blockSize);
                                fileStream.Write(dataByte, 0, thisRead);
                                if (thisRead == 0)
                                    break;
                            }
                            fileStream.Close();

                        }
                        if (NewFileRecieved != null)
                        {
                            NewFileRecieved(this, fileName);
                        }
                        handlerSocket = null;
                    }
                }

            }
            catch
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
