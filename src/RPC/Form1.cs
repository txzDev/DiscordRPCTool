using DiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPC
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse);
        public System.Collections.Generic.IList<System.Text.Json.Serialization.JsonConverter> Converters { get; }
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            if (!File.Exists(Storage.fileName))
            {
                File.Create(Storage.fileName).Dispose();
                string json = JsonSerializer.Serialize(Storage.Config);
                File.AppendAllText(Storage.fileName, json);

                menuArea1.TabCtrl.SelectTab(1);
                MessageBox.Show("Config file wasnt found. New file created, please redo config!", "Config Error");
            }
            else if (File.ReadAllText("config.json") == "null")
            {
                // Remove currupted file
                File.Delete(Storage.fileName);

                // Remake fresh file
                File.Create(Storage.fileName).Dispose();
                string json = JsonSerializer.Serialize(Storage.Config);
                File.AppendAllText(Storage.fileName, json);

                menuArea1.TabCtrl.SelectTab(1);
                MessageBox.Show("Config file was currupted, please redo config!", "Config Error");
            }
            else if (File.Exists(Storage.fileName))
            {
                Storage.Config = JsonSerializer.Deserialize<Settings>(File.ReadAllText(Storage.fileName));
                menuArea1.ClientText.Text = Storage.Config.ClientID;
                menuArea1.DetailsText.Text = Storage.Config.Details;
                menuArea1.StateText.Text = Storage.Config.State;
                menuArea1.ImageText.Text = Storage.UseImage.ToString();
                menuArea1.ImageKeyText.Text = Storage.Config.LargeImageKey;
                menuArea1.ImageTText.Text = Storage.Config.LargeImageText;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void TitleLbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void TitleLbl_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.Selectable, false);
            Environment.Exit(-1);
        }
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            menuArea1.TabCtrl.SelectTab(0);
        }
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            menuArea1.TabCtrl.SelectTab(1);
        }
        private void InfoBtn_Click(object sender, EventArgs e)
        {
            menuArea1.TabCtrl.SelectTab(2);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
    class Storage
    {
        public static bool UseImage = true;
        public static string Client = "";
        public static Settings Config;
        public static string fileName = "config.json";
    }
    public class Settings
    {
        public Settings(string clientID, string details, string state, string largeImageKey, string largeImageText)
        {
            ClientID = clientID;
            Details = details;
            State = state;
            LargeImageKey = largeImageKey;
            LargeImageText = largeImageText;
        }
        public string ClientID { get; }
        public string Details { get; }
        public string State { get; }
        public string LargeImageKey { get; }
        public string LargeImageText { get; }
    }
}
