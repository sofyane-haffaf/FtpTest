using System;
using System.Windows.Forms;
using System.IO;
using OpenNETCF.Net.NetworkInformation;

using OpenNETCF.Net.Ftp;

namespace FTPTest
{
    public partial class Acceuil : Form
    {
        delegate void StringDelegate(string value);
        
        private FTP m_ftp;
        
        public Acceuil()
        {
            InitializeComponent();
        }

        void m_ftp_Connected(FTP source)
        {
            // when this happens we're ready to send command
            OnResponse("Connected.");
        }

        void m_ftp_ResponseReceived(FTP source, FTPResponse Response)
        {
            OnResponse(Response.Text);
        }

        private void OnResponse(string response)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new StringDelegate(OnResponse), new object[] { response });
                return;
            }
            var item = new ListViewItem(new string[] { DateTime.Now.ToShortTimeString(), response });
            status.Items.Insert(0, item);
            status.Columns[1].Width = -1;
        }

        public bool PingTest()
        {
            var ping = new Ping();
            const string adr = "173.194.39.56";
            PingReply pingReply = ping.Send(adr, 500);

            if (pingReply.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void listefichier_Click(object sender, EventArgs e)
        {
            FTPFiles files = m_ftp.EnumFiles();

            fileList.Items.Clear();

            foreach (FTPFile file in files)
            {
                fileList.Items.Add(new ListViewItem(new string[] { file.Name, file.Size.ToString() }));
            }

            tab.SelectedIndex = 1;
        }

        private void uploaderfichier_Click(object sender, EventArgs e)
        {
            FileStream stream = File.OpenRead("\\My Documents\\ASP.NET.Design.Patterns.pdf");
            m_ftp.SendFile(stream, "ASP.NET.Design.Patterns.pdf");
            stream.Close();
        }

        private void Pinguer_Click(object sender, EventArgs e)
        {
            bool pt = PingTest();
            if (pt == true) MessageBox.Show("Connexion internet disponible");
            else MessageBox.Show("pas de connexion internet");
        }

        private void Connecter_Click(object sender, EventArgs e)
        {
            OnResponse("Connecting");
            m_ftp = new FTP(server.Text);
            m_ftp.ResponseReceived += new FTPResponseHandler(m_ftp_ResponseReceived);
            m_ftp.Connected += new FTPConnectedHandler(m_ftp_Connected);
            m_ftp.BeginConnect(user.Text, password.Text);
        }
    }
}