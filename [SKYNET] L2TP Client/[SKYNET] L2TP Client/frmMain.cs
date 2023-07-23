using DotRas;
using SKYNET.GUI;
using SKYNET.Helpers;
using System;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYNET
{
    public partial class frmMain : frmBase
    {
        private string _adapterName;
        private string _server;
        private string _preSharedKey;
        private string _userName;
        private string _passWord;
        private bool connected;
        private bool setDisconnected;

        private RasHandle _handle;
        private RasDialer _dialer;

        public bool Connected
        {
            set
            {
                connected = value;
                if (connected)
                {
                    BT_Auth.Text = "Desconectar";
                }
                else
                {
                    BT_Auth.Text = "Conectar";
                }
            }
            get { return connected; }
        }

        public frmMain()
        {
            InitializeComponent();
            base.SetMouseMove(PN_Top);
            CheckForIllegalCrossThreadCalls = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Settings.Load();

            _dialer = new RasDialer();

            TB_Username.Text = Settings.Username;
            TB_Password.Text = Settings.Password;
            TB_PreSharedKey.Text = Settings.PreSharedKey;
            TB_Servers.Text = Settings.Server;
            CH_AutoConnect.Checked = Settings.AutoConnect;

            if (Settings.AutoConnect)
            {
                BT_Auth_Click(null, null);
            }
        }

        private void CloseBox_BoxClicked(object sender, EventArgs e)
        {
            Settings.Username = TB_Username.Text;
            Settings.Password = TB_Password.Text;
            Settings.PreSharedKey = TB_PreSharedKey.Text;
            Settings.Server = TB_Servers.Text;
            Settings.AutoConnect = CH_AutoConnect.Checked;
            Settings.Save();

            Disconnect();

            Application.Exit();
        }

        private void MinimizeBox_BoxClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private async void BT_Auth_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                Disconnect();
                setDisconnected = true;
                return;
            }

            Disconnect();

            if (string.IsNullOrEmpty(TB_Servers.Text))
            {
                Common.Show("Por favor... seleccione un servidor válido para continuar.");
                return;
            }

            if (string.IsNullOrEmpty(TB_Username.Text))
            {
                Common.Show("Por favor... introduzca un usuario válido para continuar.");
                return;
            }

            if (string.IsNullOrEmpty(TB_Password.Text))
            {
                Common.Show("Por favor... introduzca una contraseña válida para continuar.");
                return;
            }

            if (string.IsNullOrEmpty(TB_PreSharedKey.Text))
            {
                Common.Show("Por favor... introduzca una clave válida para continuar.");
                return;
            }

            BT_Auth.Enabled = false;

            _server = TB_Servers.Text;
            _preSharedKey = TB_PreSharedKey.Text;
            _userName = TB_Username.Text;
            _passWord = TB_Password.Text;
            _adapterName = TB_Servers.Text;

            WriteLine($"Conectando al servidor {_server}");

            try
            {
                using (var rasPhoneBook = new RasPhoneBook())
                {
                    rasPhoneBook.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers));
                    if (rasPhoneBook.Entries.Contains(_adapterName))
                    {
                        try
                        {
                            rasPhoneBook.Entries.Remove(_adapterName);
                        }
                        catch
                        {
                        }
                    }
                    var rasEntry = RasEntry.CreateVpnEntry(_adapterName, _server, RasVpnStrategy.L2tpOnly, RasDevice.GetDeviceByName("(L2TP)", RasDeviceType.Vpn));
                    rasPhoneBook.Entries.Add(rasEntry);
                    rasEntry.Options.PreviewDomain = false;
                    rasEntry.Options.ShowDialingProgress = false;
                    rasEntry.Options.PromoteAlternates = false;
                    rasEntry.Options.DoNotNegotiateMultilink = false;
                    rasEntry.Options.UsePreSharedKey = true;
                    rasEntry.UpdateCredentials(RasPreSharedKey.Client, _preSharedKey);
                    rasEntry.Update();
                    _dialer.EntryName = _adapterName;
                    _dialer.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers);
                    _dialer.Credentials = new NetworkCredential(_userName, _passWord);
                }
                _handle = _dialer.DialAsync();

                await Task.Delay(5000);
                CheckConnection();
            }
            catch (Exception ex)
            {
                WriteLine($"Error conectando al servidor {_server}");
                //Common.Show(ex);
                Disconnect();
            }

            BT_Auth.Enabled = true;
            setDisconnected = false;
        }

        private async void CheckConnection()
        {
            while (true)
            {
                bool connected = false;
                foreach (var connection in RasConnection.GetActiveConnections())
                {
                    if (connection.EntryName.Equals(_adapterName))
                    {
                        connected = true;
                        break;
                    }
                }

                if (connected)
                {
                    WriteLine($"Conectado al servidor {_server} satisfactoriamente.");
                    PN_Status.BackColor = Color.Green;
                    Connected = true;
                }
                else
                {
                    if (setDisconnected)
                    {
                        WriteLine($"");
                        PN_Status.BackColor = BackColor;
                        Connected = false;
                        return;
                    }

                    WriteLine($"Error al conectar al servidor {_server}");
                    PN_Status.BackColor = Color.Red;
                    Connected = false;
                }

                await Task.Delay(5000);
            }
        }

        public void Disconnect()
        {
            Task.Run(() =>
           {
               BT_Auth.Enabled = false;
               try
               {
                   if (_dialer.IsBusy)
                   {
                       _dialer.DialAsyncCancel();
                   }
                   else if (_handle != null)
                   {
                       RasConnection.GetActiveConnectionByHandle(_handle)?.HangUp();
                   }
                   var rasPhoneBook = new RasPhoneBook();
                   rasPhoneBook.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers));
                   if (rasPhoneBook.Entries.Contains(_adapterName))
                   {
                       rasPhoneBook.Entries.Remove(_adapterName);
                   }
               }
               catch (Exception)
               {

               }
               BT_Auth.Enabled = true;
           });
        }

        private void WriteLine(object msg)
        {
            LB_Info.Text = msg.ToString();
        }

    }
}
