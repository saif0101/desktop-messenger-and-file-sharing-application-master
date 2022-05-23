using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace projectMessenger
{
    public partial class home : Form
    {
        //  Socket sck;
        //  EndPoint user1, user2;
        // byte[] buffer;
        private TcpClient client;
        public StreamReader str;
        public StreamWriter stw;
        public string receive;
        public string texttosend;
        public home()
        {
            InitializeComponent();
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip1textbox.Text = address.ToString();
                }
            }
        }
     //   string n;
     //   byte[] b1;
      //  OpenFileDialog op;
        string rd;
        //byte[] b1;
        string v;
        int m;
     //   TcpListener list;

        Int32 port = 5050;
    //    Int32 port1 = 5055;
       /* private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                imgtextbox.Text = ofd.FileName;


                imgpicturebox.Image = Image.FromFile(@ofd.FileName);

            }
        }*/

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

      
        private string getlocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint ipend = new IPEndPoint(IPAddress.Parse(ip2textbox.Text), int.Parse(port2textbox.Text));
            try
            {
                client.Connect(ipend);
                if (client.Connected)
                {
                    msglisttextbox.AppendText("connected to server" + "\n");
                    str = new StreamReader(client.GetStream());
                    stw = new StreamWriter(client.GetStream());
                    stw.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;

                }
            }
            /*try
            {
                user1 = new IPEndPoint(IPAddress.Parse(ip1textbox.Text), Convert.ToInt32(port1textbox.Text));
                sck.Bind(user1);

                user2 = new IPEndPoint(IPAddress.Parse(ip2textbox.Text), Convert.ToInt32(port2textbox.Text));
                sck.Connect(user2);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref user1, new AsyncCallback(MessageCallBack), buffer);

                sendbtn.Enabled = true;

                connectbtn.Text = "Connected";

                connectbtn.Enabled = false;

                msgtextbox.Focus();
            }*/
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }




           
        
      

        private void sendbtn_Click(object sender, EventArgs e)
        {
            if (msgtextbox.Text != ""
                )
            {
                texttosend = msgtextbox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
                msgtextbox.Text = "";
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(port1textbox.Text)
               );
            listener.Start();
            client = listener.AcceptTcpClient();
            str = new StreamReader(client.GetStream());
            stw = new StreamWriter(client.GetStream());
            stw.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = str.ReadLine();
                    this.msglisttextbox.Invoke(new MethodInvoker(delegate
                        ()
                        {
                            msglisttextbox.AppendText("my frnd: " + receive + "\n");
                        }));
                    receive = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                stw.WriteLine(texttosend);
                this.msglisttextbox.Invoke(new MethodInvoker(delegate()
                    {
                        msglisttextbox.AppendText("me: " + texttosend + "\n");
                    }));

            }
            else
            {
                MessageBox.Show("sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void msgtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ip1textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void msglisttextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

    

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
        

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void home_Load(object sender, EventArgs e)
        {
            //TcpListener list = new TcpListener(localAddr, port);
            TcpListener list = new TcpListener(port);
            list.Start();
            TcpClient client = list.AcceptTcpClient();
            MessageBox.Show("Client trying to connect");
            StreamReader sr = new StreamReader(client.GetStream());
            rd = sr.ReadLine();
            v = rd.Substring(rd.LastIndexOf('.') + 1);
            m = int.Parse(v);
            list.Stop();
            client.Close();

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void port1textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ip2textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void port2textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        { }
            private void browsebttn_Click(object sender, EventArgs e)
        {
            
        }

private void sendbttn_Click(object sender, EventArgs e)
        {
        }

private void home_Load_1(object sender, EventArgs e)
{

}

private void browse5btn_Click(object sender, EventArgs e)
{
    
}

private void button5_Click(object sender, EventArgs e)
{

}

private void button6_Click(object sender, EventArgs e)
{
    Form2 homeform2 = new Form2();
    homeform2.Show();
}

private void button1_Click(object sender, EventArgs e)
{

}

private void button1_Click_1(object sender, EventArgs e)
{

    
}

private void button2_Click_1(object sender, EventArgs e)
{
   
}

private void button3_Click_1(object sender, EventArgs e)
{
   
}

private void groupBox1_Enter(object sender, EventArgs e)
{

}
        }
}

      /*  private void browsebttn_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                string t = textBox2.Text;
                t = op.FileName;
                FileInfo fi = new FileInfo(textBox2.Text = op.FileName);
                n = fi.Name + "." + fi.Length;
                TcpClient client = new TcpClient("SwtRascal", 5055);
                StreamWriter sw = new StreamWriter(client.GetStream());
                sw.WriteLine(n);
                sw.Flush();
                label10.Text = "File Transferred....";
            }
        }

        private void sendbttn_Click(object sender, EventArgs e)
        {
            {
                TcpClient client = new TcpClient("SwtRascal", 5050);
                Stream s = client.GetStream();
                b1 = File.ReadAllBytes(op.FileName);
                s.Write(b1, 0, b1.Length);
                client.Close();
                label10.Text = "File Transferred....";

            }
        } */
    

