using System;
using System.Windows.Forms;
using System.ServiceModel;
using System.Net;
using System.Net.NetworkInformation;

namespace NetGameEngine
{
    public partial class NetGameWindow : Form
    {
        private ServiceHost host;
        private GameService service;
        private GameContractClient proxy;
        private GameServiceCallback callback;
        private string name;

        public NetGameWindow()
        {
            InitializeComponent();
            service = new GameService();
            service.ClientMoved += Service_ClientMoved;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            name = "Server";
            if (host == null)
            {
                connectButton.Enabled = false;
                createButton.Enabled = false;
                ipTextBox.Enabled = false;
                disconnectButton.Enabled = true;
                Text = name;

                string uriString = string.Format("net.tcp://{0}:12345", GetLocalIpAddress());
                host = new ServiceHost(service);
                host.AddServiceEndpoint(typeof(IGameContract), new NetTcpBinding(SecurityMode.None), uriString);
                host.Open();
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            name = "Client";
            if (proxy == null)
            {
                connectButton.Enabled = false;
                createButton.Enabled = false;
                ipTextBox.Enabled = false;
                disconnectButton.Enabled = true;
                Text = name;

                string uriString = string.Format("net.tcp://{0}:12345", ipTextBox.Text);
                callback = new GameServiceCallback();
                callback.ServerMoved += Callback_ServerMoved;
                proxy = new GameContractClient(new InstanceContext(callback), new NetTcpBinding(SecurityMode.None), new EndpointAddress(uriString));
                proxy.Connect();
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = true;
            createButton.Enabled = true;
            ipTextBox.Enabled = true;
            disconnectButton.Enabled = false;
            Text = "Net Game";

            if (host != null)
            {
                host.Close();
                host = null;
            }

            if (proxy != null)
            {
                proxy.Close();
                proxy = null;
            }
        }

        private void ShootButton_Click(object sender, EventArgs e)
        {
            //switch (name)
            {
                //case "Server":
                    if (proxy != null)
                    {
                        proxy.ClientMove(shootTextBox.Text);
                        shootListTextBox.AppendText("Client> " + shootTextBox.Text + '\n');
                    }
                    //break;
                //case "Client":
                    if (host != null)
                    {
                        service.ServerMove(shootTextBox.Text);
                        shootListTextBox.AppendText("Server> " + shootTextBox.Text + '\n');
                    }
                    //break;
            }

            shootButton.Enabled = false;
            shootTextBox.Clear();
        }

        private void Service_ClientMoved(string shoot)
        {
            shootListTextBox.AppendText("Client> " + shoot + '\n');
            shootButton.Enabled = true;
        }

        private void Callback_ServerMoved(string shoot)
        {
            shootListTextBox.AppendText("Server> " + shoot + '\n');
            shootButton.Enabled = true;
        }

        public static string GetLocalIpAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }
    }
}
