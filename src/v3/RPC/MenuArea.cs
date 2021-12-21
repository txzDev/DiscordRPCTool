using DiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPC
{
    public partial class MenuArea : UserControl
    {
        DiscordRpcClient client;
        bool Status = false;
        public MenuArea()
        {
            InitializeComponent();
        }
        private void ImageCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ImageCb.Checked)
            {
                ImageKeyTb.Visible = true;
                ImageTextTb.Visible = true;
                label2.Visible = true;
            }
            else if (!ImageCb.Checked)
            {
                ImageKeyTb.Visible = false;
                ImageTextTb.Visible = false;
                label2.Visible = false;
            }
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            ResetRPC(Storage.Config.ClientID);
            if (Storage.UseImage == false)
            {
                RichPresence presence = new RichPresence()
                {
                    Details = Storage.Config.Details,
                    State = Storage.Config.State,
                };
                if (Status == true)
                {
                    client.SetPresence(presence);
                    StartBtn.Text = "Stop ";
                    StatusText.Text = "Status: Running.";
                }
            }
            else if (Storage.UseImage == true)
            {
                RichPresence presence = new RichPresence()
                {
                    Details = Storage.Config.Details,
                    State = Storage.Config.State,
                    Assets = new Assets()
                    {
                        LargeImageKey = Storage.Config.LargeImageKey,
                        LargeImageText = Storage.Config.LargeImageText
                    }
                };
                if (Status == true)
                {
                    client.SetPresence(presence);
                    StartBtn.Text = "Stop ";
                    StatusText.Text = "Status: Running.";
                }
            }
        }
        public void ResetRPC(string CID)
        {
            if (Status == true)
            {
                if (client.IsInitialized)
                {
                    Status = false;
                    client.ClearPresence();
                    client.Dispose();
                    StartBtn.Text = "Start ";
                    StatusText.Text = "Status: Not Running.";
                }
            }
            else
            {
                Status = true;
                client = new DiscordRpcClient(Storage.Config.ClientID);
                client.Initialize();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(Storage.fileName))
            {
                File.Create(Storage.fileName).Dispose();
                string json = JsonSerializer.Serialize(Storage.Config);
                File.AppendAllText(Storage.fileName, json);

                string client = ClientTb.Text;
                string details = DetailsTb.Text;
                string state = StateTb.Text;
                bool include = ImageCb.Checked;
                if (include)
                {
                    Storage.UseImage = true;
                    string IK = ImageKeyTb.Text;
                    string IT = ImageTextTb.Text;
                    Storage.Config = new Settings(client, details, state, IK, IT);
                    File.WriteAllText(Storage.fileName, JsonSerializer.Serialize(Storage.Config));
                }
                else if (!include)
                {
                    Storage.UseImage = false;
                    Storage.Config = new Settings(client, details, state, "NULL", "NULL");
                    File.WriteAllText(Storage.fileName, JsonSerializer.Serialize(Storage.Config));
                }
            }
            ClientText.Text = Storage.Config.ClientID;
            DetailsText.Text = Storage.Config.Details;
            StateText.Text = Storage.Config.State;
            ImageText.Text = Storage.UseImage.ToString();
            ImageKeyText.Text = Storage.Config.LargeImageKey;
            ImageTText.Text = Storage.Config.LargeImageText;
            MessageBox.Show("Config was saved!", "Success");
            TabCtrl.SelectTab(0);
        }

        private void ClientTb_Click(object sender, EventArgs e)
        {
            if (ClientTb.Text == "ClientID")
            {
                ClientTb.Text = string.Empty;
            }
        }

        private void DetailsTb_Click(object sender, EventArgs e)
        {
            if (DetailsTb.Text == "Detail Text")
            {
                DetailsTb.Text = string.Empty;
            }
        }

        private void StateTb_Click(object sender, EventArgs e)
        {
            if (StateTb.Text == "State Text")
            {
                StateTb.Text = string.Empty;
            }
        }

        private void ImageKeyTb_Click(object sender, EventArgs e)
        {
            if (ImageKeyTb.Text == "ImageKey")
            {
                ImageKeyTb.Text = string.Empty;
            }
        }

        private void ImageTextTb_Click(object sender, EventArgs e)
        {
            if (ImageTextTb.Text == "ImageText")
            {
                ImageTextTb.Text = string.Empty;
            }
        }

        private void ImageTText_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/txzDev/DiscordRPCTool/blob/main/README.md");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/txzDev/DiscordRPCTool");
        }
    }
}