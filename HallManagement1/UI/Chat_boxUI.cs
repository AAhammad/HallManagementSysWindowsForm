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

namespace HallManagement1.UI
{
    public partial class Chat_boxUI : Form
    {
        private Socket sck;
        private EndPoint epLocal, epRemote;
        public Chat_boxUI()
        {
            InitializeComponent();
            
            sck =new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket,SocketOptionName.ReuseAddress,true);

            firstIPTextBox.Text = GetLocalIp();
            secondIPTextBox.Text = GetLocalIp();
        }

        private string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {

            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);

                if (size > 0)
                {
                    byte[] receiveData=new byte[1464];
                    receiveData = (byte[]) aResult.AsyncState;

                    ASCIIEncoding eEncoding=new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receiveData);

                    messageListBox.Items.Add("Friend:" + receivedMessage);

                }
                byte[] buffer=new byte[1500];
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Message_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Chat_boxUI_Load(object sender, EventArgs e)
        {

        }
    }
}
