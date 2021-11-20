
namespace DiscordRPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftPnl = new System.Windows.Forms.Panel();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.MenusUC = new DiscordRPC.Menus();
            this.MinBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LeftPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPnl
            // 
            this.LeftPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(36)))));
            this.LeftPnl.Controls.Add(this.InfoBtn);
            this.LeftPnl.Controls.Add(this.SettingsBtn);
            this.LeftPnl.Controls.Add(this.MenuBtn);
            this.LeftPnl.Location = new System.Drawing.Point(0, -2);
            this.LeftPnl.Name = "LeftPnl";
            this.LeftPnl.Size = new System.Drawing.Size(41, 310);
            this.LeftPnl.TabIndex = 0;
            // 
            // InfoBtn
            // 
            this.InfoBtn.FlatAppearance.BorderSize = 0;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.Image = ((System.Drawing.Image)(resources.GetObject("InfoBtn.Image")));
            this.InfoBtn.Location = new System.Drawing.Point(3, 168);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(35, 35);
            this.InfoBtn.TabIndex = 2;
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Image")));
            this.SettingsBtn.Location = new System.Drawing.Point(3, 126);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(35, 35);
            this.SettingsBtn.TabIndex = 1;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuBtn.Image")));
            this.MenuBtn.Location = new System.Drawing.Point(3, 86);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(35, 35);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // MenusUC
            // 
            this.MenusUC.Location = new System.Drawing.Point(51, 33);
            this.MenusUC.Name = "MenusUC";
            this.MenusUC.Size = new System.Drawing.Size(587, 261);
            this.MenusUC.TabIndex = 0;
            // 
            // MinBtn
            // 
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinBtn.Image")));
            this.MinBtn.Location = new System.Drawing.Point(588, 5);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(20, 20);
            this.MinBtn.TabIndex = 3;
            this.MinBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(614, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 20);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(646, 307);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MinBtn);
            this.Controls.Add(this.MenusUC);
            this.Controls.Add(this.LeftPnl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.LeftPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel LeftPnl;
        public Menus MenusUC;
        public System.Windows.Forms.Button MenuBtn;
        public System.Windows.Forms.Button InfoBtn;
        public System.Windows.Forms.Button SettingsBtn;
        public System.Windows.Forms.Button MinBtn;
        public System.Windows.Forms.Button ExitBtn;
    }
}

