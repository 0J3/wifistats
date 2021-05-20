
namespace wifistats_winforms
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.RunChecks = new System.Windows.Forms.Timer(this.components);
            this.toggleAlwaysOnTop = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Ping = new System.Windows.Forms.Label();
            this.DNSPing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RunChecks
            // 
            this.RunChecks.Enabled = true;
            this.RunChecks.Interval = 1000;
            this.RunChecks.Tick += new System.EventHandler(this.RunChecks_Tick);
            // 
            // toggleAlwaysOnTop
            // 
            this.toggleAlwaysOnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(7)))), ((int)(((byte)(54)))));
            this.toggleAlwaysOnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toggleAlwaysOnTop.FlatAppearance.BorderSize = 0;
            this.toggleAlwaysOnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleAlwaysOnTop.Location = new System.Drawing.Point(12, 71);
            this.toggleAlwaysOnTop.Name = "toggleAlwaysOnTop";
            this.toggleAlwaysOnTop.Size = new System.Drawing.Size(147, 32);
            this.toggleAlwaysOnTop.TabIndex = 0;
            this.toggleAlwaysOnTop.Text = "Toggle Overlay Mode";
            this.toggleAlwaysOnTop.UseVisualStyleBackColor = false;
            this.toggleAlwaysOnTop.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(7)))), ((int)(((byte)(54)))));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(180, 71);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(143, 32);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Ping
            // 
            this.Ping.AutoSize = true;
            this.Ping.Location = new System.Drawing.Point(21, 43);
            this.Ping.Name = "Ping";
            this.Ping.Size = new System.Drawing.Size(123, 15);
            this.Ping.TabIndex = 2;
            this.Ping.Text = "NeverSSL Ping: 420ms";
            // 
            // DNSPing
            // 
            this.DNSPing.AutoSize = true;
            this.DNSPing.Location = new System.Drawing.Point(21, 28);
            this.DNSPing.Name = "DNSPing";
            this.DNSPing.Size = new System.Drawing.Size(149, 15);
            this.DNSPing.TabIndex = 3;
            this.DNSPing.Text = "Cloudflare DNS Ping: 69ms";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(335, 113);
            this.Controls.Add(this.DNSPing);
            this.Controls.Add(this.Ping);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.toggleAlwaysOnTop);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "App";
            this.Text = "WifiStats by 0J3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer RunChecks;
        private System.Windows.Forms.Button toggleAlwaysOnTop;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Ping;
        private System.Windows.Forms.Label DNSPing;
    }
}

