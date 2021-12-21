
namespace RPC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuArea1 = new RPC.MenuArea();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.TitleLbl);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 26);
            this.panel1.TabIndex = 1;
            // 
            // MinBtn
            // 
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.ForeColor = System.Drawing.Color.Transparent;
            this.MinBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinBtn.Image")));
            this.MinBtn.Location = new System.Drawing.Point(271, 3);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(22, 22);
            this.MinBtn.TabIndex = 7;
            this.MinBtn.TabStop = false;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(297, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(22, 22);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(0, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(323, 26);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "DiscordRPC Tool";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLbl.Click += new System.EventHandler(this.TitleLbl_Click);
            this.TitleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLbl_MouseDown);
            this.TitleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLbl_MouseMove);
            // 
            // MenuBtn
            // 
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuBtn.ForeColor = System.Drawing.Color.Transparent;
            this.MenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuBtn.Image")));
            this.MenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuBtn.Location = new System.Drawing.Point(12, 29);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(81, 28);
            this.MenuBtn.TabIndex = 2;
            this.MenuBtn.Text = "Menu ";
            this.MenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Image")));
            this.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Location = new System.Drawing.Point(117, 29);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(85, 28);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = " Settings";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.FlatAppearance.BorderSize = 0;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.InfoBtn.Image = ((System.Drawing.Image)(resources.GetObject("InfoBtn.Image")));
            this.InfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoBtn.Location = new System.Drawing.Point(233, 29);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(81, 28);
            this.InfoBtn.TabIndex = 4;
            this.InfoBtn.Text = "Info   ";
            this.InfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notif";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // menuArea1
            // 
            this.menuArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.menuArea1.Location = new System.Drawing.Point(12, 63);
            this.menuArea1.Name = "menuArea1";
            this.menuArea1.Size = new System.Drawing.Size(297, 260);
            this.menuArea1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(321, 334);
            this.Controls.Add(this.menuArea1);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RPC Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button MinBtn;
        private MenuArea menuArea1;
    }
}

