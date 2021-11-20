using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordRPC
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public System.Collections.Generic.IList<System.Text.Json.Serialization.JsonConverter> Converters { get; }
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));

            if (!File.Exists(Storage.fileName))
            {
                File.Create(Storage.fileName).Dispose();
                string json = JsonSerializer.Serialize(Storage.Config);
                File.AppendAllText(Storage.fileName, json);

                MenusUC.TabControl.SelectTab(1);
                MessageBox.Show("Config file wasnt found. New file created, please redo config!", "Config Error");
            }
            else if (File.ReadAllText("config.json") == "null")
            {
                // Remove currupted/empty file
                File.Delete(Storage.fileName);

                // Remake fresh file
                File.Create(Storage.fileName).Dispose();
                string json = JsonSerializer.Serialize(Storage.Config);
                File.AppendAllText(Storage.fileName, json);

                MenusUC.TabControl.SelectTab(1);
                MessageBox.Show("Config file was currupted or missing info, please redo config!", "Config Error");
            }
            else if (File.Exists(Storage.fileName))
            {
                Storage.Config = JsonSerializer.Deserialize<Settings>(File.ReadAllText(Storage.fileName));
                MenusUC.ClientIDValLbl.Text = Storage.Config.ClientID;
                MenusUC.DetailTextValLbl.Text = Storage.Config.Details;
                MenusUC.StateTextValLbl.Text = Storage.Config.State;
                MenusUC.UseImageValLbl.Text = Storage.UseImage.ToString();
                MenusUC.ImageTypeValLbl.Text = Storage.Config.ImageSize;
                MenusUC.ImageKeyValLbl.Text = Storage.Config.ImageKey;
                MenusUC.ImageTextValLbl.Text = Storage.Config.ImageText;
                MenusUC.UseButtonValLbl.Text = Storage.UseButton.ToString();
                MenusUC.ButtonTextValLbl.Text = Storage.Config.ButtonText;
                MenusUC.ButtonUrlValLbl.Text = Storage.Config.ButtonURL;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            MenusUC.TabControl.SelectTab(0);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            MenusUC.TabControl.SelectTab(1);
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            MenusUC.TabControl.SelectTab(2);
        }
    }
    class Storage
    {
        public static bool UseImage = true;
        public static bool UseButton = true;
        public static string Client = "";
        public static Settings Config;
        public static string fileName = "config.json";
    }
    public class Settings
    {
        public Settings(string clientID, string details, string state, string imageSize, string largeImageKey, string largeImageText, string buttonText, string buttonUrl)
        {
            ClientID = clientID;
            Details = details;
            State = state;
            ImageSize = imageSize;
            ImageKey = largeImageKey;
            ImageText = largeImageText;
            ButtonText = buttonText;
            ButtonURL = buttonUrl;
        }
        public string ClientID { get; }
        public string Details { get; }
        public string State { get; }
        public string ImageSize { get; }
        public string ImageKey { get; }
        public string ImageText { get; }
        public string ButtonText { get; }
        public string ButtonURL { get; }
    }
}

