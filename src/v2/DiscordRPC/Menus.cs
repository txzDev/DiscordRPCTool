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
    public partial class Menus : UserControl
    {
        DiscordRpcClient client;
        bool Status = false;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public Menus()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void ClientIDTB_Click(object sender, EventArgs e)
        {
            if (ClientIDTB.Text == " ClientID")
            {
                ClientIDTB.Text = string.Empty;
            }
        }

        private void DetailTextTB_Click(object sender, EventArgs e)
        {
            if (DetailTextTB.Text == " Detail Text")
            {
                DetailTextTB.Text = string.Empty;
            }
        }

        private void StateTextTB_Click(object sender, EventArgs e)
        {
            if (StateTextTB.Text == " State Text")
            {
                StateTextTB.Text = string.Empty;
            }
        }

        private void ImageKeyTB_Click(object sender, EventArgs e)
        {
            if (ImageKeyTB.Text == " Image Key")
            {
                ImageKeyTB.Text = string.Empty;
            }
        }

        private void ImageTextTB_Click(object sender, EventArgs e)
        {
            if (ImageTextTB.Text == " Image Text")
            {
                ImageTextTB.Text = string.Empty;
            }
        }

        private void ButtonTextTB_Click(object sender, EventArgs e)
        {
            if (ButtonTextTB.Text == " Button Text")
            {
                ButtonTextTB.Text = string.Empty;
            }
        }

        private void ButtonUrlTB_Click(object sender, EventArgs e)
        {
            if (ButtonUrlTB.Text == " Button Url")
            {
                ButtonUrlTB.Text = string.Empty;
            }
        }

        private void UseImageCB_CheckedChanged(object sender, EventArgs e)
        {
            if (UseImageCB.Checked)
            {
                ImageSizeCB.Visible = true;
                ImageKeyTB.Visible = true;
                ImageTextTB.Visible = true;
            }
            else if (!UseImageCB.Checked)
            {
                ImageSizeCB.Visible = false;
                ImageKeyTB.Visible = false;
                ImageTextTB.Visible = false;
            }
        }

        private void UseButtonCB_CheckedChanged(object sender, EventArgs e)
        {
            if (UseButtonCB.Checked)
            {
                ButtonTextTB.Visible = true;
                ButtonUrlTB.Visible = true;
            }
            else if (!UseButtonCB.Checked)
            {
                ButtonTextTB.Visible = false;
                ButtonUrlTB.Visible = false;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(Storage.fileName))
            {
                File.Create(Storage.fileName).Dispose();
                string json = JsonSerializer.Serialize(Storage.Config);
                File.AppendAllText(Storage.fileName, json);

                string client = ClientIDTB.Text;
                string details = DetailTextTB.Text;
                string state = StateTextTB.Text;
                bool include1 = UseImageCB.Checked;
                bool include2 = UseButtonCB.Checked;
                if (include1 && include2)
                {
                    Storage.UseImage = true;
                    Storage.UseButton = true;
                    string IS = ImageSizeCB.Text;
                    string IK = ImageKeyTB.Text;
                    string IT = ImageTextTB.Text;
                    string BT = ButtonTextTB.Text;
                    string BU = ButtonUrlTB.Text;
                    Storage.Config = new Settings(client, details, state, IS, IK, IT, BT, BU);
                    File.WriteAllText(Storage.fileName, JsonSerializer.Serialize(Storage.Config));
                }
                else if (!include1 && include2)
                {
                    Storage.UseImage = false;
                    Storage.UseButton = true;
                    string BT = ButtonTextTB.Text;
                    string BU = ButtonUrlTB.Text;
                    Storage.Config = new Settings(client, details, state, "NULL", "NULL", "NULL", BT, BU);
                    File.WriteAllText(Storage.fileName, JsonSerializer.Serialize(Storage.Config));
                }
                else if (include1 && !include2)
                {
                    Storage.UseImage = true;
                    Storage.UseButton = false;
                    string IS = ImageSizeCB.Text;
                    string IK = ImageKeyTB.Text;
                    string IT = ImageTextTB.Text;
                    Storage.Config = new Settings(client, details, state, IS,  IK, IT, "NULL", "NULL");
                    File.WriteAllText(Storage.fileName, JsonSerializer.Serialize(Storage.Config));
                }
                else if (!include1 && !include2)
                {
                    Storage.UseImage = false;
                    Storage.UseButton = false;
                    Storage.Config = new Settings(client, details, state, "NULL", "NULL", "NULL", "NULL", "NULL");
                    File.WriteAllText(Storage.fileName, JsonSerializer.Serialize(Storage.Config));
                }
            }
            ClientIDValLbl.Text = Storage.Config.ClientID;
            DetailTextValLbl.Text = Storage.Config.Details;
            StateTextValLbl.Text = Storage.Config.State;
            UseImageValLbl.Text = Storage.UseImage.ToString();
            ImageTypeValLbl.Text = Storage.Config.ImageSize;
            ImageKeyValLbl.Text = Storage.Config.ImageKey;
            ImageTextValLbl.Text = Storage.Config.ImageText;
            UseButtonValLbl.Text = Storage.UseButton.ToString();
            ButtonTextValLbl.Text = Storage.Config.ButtonText;
            ButtonUrlValLbl.Text = Storage.Config.ButtonURL;
            MessageBox.Show("Config was saved!", "Success");
            TabControl.SelectTab(0);
        }

        private void MainStartBtn_Click(object sender, EventArgs e)
        {
            ResetRPC();
            if (Storage.UseImage == false && Storage.UseButton == false)
            {
                RichPresence presence = new RichPresence()
                {
                    Details = Storage.Config.Details,
                    State = Storage.Config.State,
                };
                if (Status == true)
                {
                    client.SetPresence(presence);
                    MainStartBtn.Text = "Stop";
                    StateTextLbl.Text = "Status: Running.";
                }
            }
            else if (Storage.UseImage == true && Storage.UseButton == false)
            {
                if (Storage.Config.ImageSize == "Large Image")
                {
                    RichPresence presence1 = new RichPresence()
                    {
                        Details = Storage.Config.Details,
                        State = Storage.Config.State,
                        Assets = new Assets()
                        {
                            LargeImageKey = Storage.Config.ImageKey,
                            LargeImageText = Storage.Config.ImageText
                        }
                    };
                    if (Status == true)
                    {
                        client.SetPresence(presence1);
                        MainStartBtn.Text = "Stop";
                        StateTextLbl.Text = "Status: Running.";
                    }
                }
                else if (Storage.Config.ImageSize == "Small Image")
                {
                    RichPresence presence2 = new RichPresence()
                    {
                        Details = Storage.Config.Details,
                        State = Storage.Config.State,
                        Assets = new Assets()
                        {
                            SmallImageKey = Storage.Config.ImageKey,
                            SmallImageText = Storage.Config.ImageText
                        }
                    };
                    if (Status == true)
                    {
                        client.SetPresence(presence2);
                        MainStartBtn.Text = "Stop";
                        StateTextLbl.Text = "Status: Running.";

                    }
                }
            }
            else if (Storage.UseImage == false && Storage.UseButton == true)
            {
                RichPresence presence = new RichPresence()
                {
                    Details = Storage.Config.Details,
                    State = Storage.Config.State,
                    Buttons = new Button[]
                    {
                        new Button() { Label = Storage.Config.ButtonText, Url = Storage.Config.ButtonURL}
                    }
                };
                if (Status == true)
                {
                    client.SetPresence(presence);
                    MainStartBtn.Text = "Stop";
                    StateTextLbl.Text = "Status: Running.";
                }
            }
            else if (Storage.UseImage == true && Storage.UseButton == true)
            {
                if (Storage.Config.ImageSize == "Large Image")
                {
                    RichPresence presence1 = new RichPresence()
                    {
                        Details = Storage.Config.Details,
                        State = Storage.Config.State,
                        Buttons = new Button[]
                        {
                            new Button() { Label = Storage.Config.ButtonText, Url = Storage.Config.ButtonURL}
                        },
                        Assets = new Assets()
                        {
                            LargeImageKey = Storage.Config.ImageKey,
                            LargeImageText = Storage.Config.ImageText
                        }

                    };
                    if (Status == true)
                    {
                        client.SetPresence(presence1);
                        MainStartBtn.Text = "Stop";
                        StateTextLbl.Text = "Status: Running.";
                    }
                }
                else if (Storage.Config.ImageSize == "Small Image")
                {
                    RichPresence presence2 = new RichPresence()
                    {
                        Details = Storage.Config.Details,
                        State = Storage.Config.State,
                        Buttons = new Button[]
                        {
                            new Button() { Label = Storage.Config.ButtonText, Url = Storage.Config.ButtonURL}
                        },
                        Assets = new Assets()
                        {
                            SmallImageKey = Storage.Config.ImageKey,
                            SmallImageText = Storage.Config.ImageText
                        }
                    };
                    if (Status == true)
                    {
                        client.SetPresence(presence2);
                        MainStartBtn.Text = "Stop";
                        StateTextLbl.Text = "Status: Running.";

                    }
                }
            }
        }
        public void ResetRPC()
        {
            if (Status == true)
            {
                if (client.IsInitialized)
                {
                    Status = false;
                    client.ClearPresence();
                    client.Dispose();
                    MainStartBtn.Text = "Start";
                    StateTextLbl.Text = "Status: Not Running.";
                }
            }
            else
            {
                Status = true;
                client = new DiscordRpcClient(Storage.Config.ClientID);
                client.Initialize();
            }
        }
    }
}
