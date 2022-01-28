using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using System.Threading;

using System.Diagnostics;



namespace Minecraft_Launcher
{
    public partial class Username : Form
    {
        public Username()
        {
            InitializeComponent();
            session = MSession.GetOfflineSession(usern.Text);
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        MSession session;

        private discordRPC.EventHandlers handlers;
        private discordRPC.RichPresence presence;
        int a = 0;

        public static string version;

        private void path()
        {
            var path = new MinecraftPath(); // use default directory

            var launcher = new CMLauncher(path);

            // show launch progress to console
            launcher.FileChanged += (e) =>
            {
                log.Items.Add(string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount));
            };

            launcher.ProgressChanged += (s, e) =>
            {
                //Console.WriteLine("{0}%", e.ProgressPercentage);
            };


            foreach (var item in launcher.GetAllVersions())
            {
                // show all version names
                // use this version name in CreateProcessAsync method.
               vers.Items.Add(item.Name);
            }


        }
        private void launch()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);
            launcher.FileChanged += (e) =>
            {
                log.Items.Add(string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount));
            };
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = int.Parse(ram1.Text),
                Session = MSession.GetOfflineSession(usern.Text),
                ScreenWidth = int.Parse(wid.Text),
                ScreenHeight = int.Parse(hei.Text),

            };
            if (vers.SelectedIndex == -1)
            {
                MessageBox.Show("Versiyon Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                a = 0;
                //Formun Genişlik değeri piksel olarak
                this.Width = Convert.ToInt16("303");
                kpt.Visible = true;
                settings.Enabled = false;
                version = vers.SelectedItem.ToString();
                timer1.Start();

                var process = launcher.CreateProcess(version, launchOption);

                process.Start();
                timer1.Stop();

            }
        }

        private void Username_Load(object sender, EventArgs e)
        {
            this.handlers = default(discordRPC.EventHandlers);
            discordRPC.Initialize("831055177330851851", ref this.handlers, true, null);
            this.presence.details = "İsim Seçiyor";
            this.presence.state = "Zaytron";
            this.presence.largeImageKey = "zaytron";
            this.presence.smallImageKey = "zaytron";
            this.presence.largeImageText = "Zaytron";
            this.presence.smallImageText = "Zaytron";
            this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            discordRPC.UpdatePresence(ref this.presence);
            path();


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usern.Text != "")
            {

                    Thread thread = new Thread(() => launch());
                    thread.IsBackground = true;
                    thread.Start();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Boş Bırakılamaz", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Warning); 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (a == 1)
            {
                a = 0;
                //Formun Genişlik değeri piksel olarak
                this.Width = Convert.ToInt16("303");
                kpt.Visible = true;
            }
            else
            {

                a = 1;
                //Formun Genişlik değeri piksel olarak
                this.Width = Convert.ToInt16("646");
                kpt.Visible = false;
            }

        }

        private void kpt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void kpt1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int nItems = (int)(log.Height / log.ItemHeight);
            log.TopIndex = log.Items.Count - nItems;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            this.handlers = default(discordRPC.EventHandlers);
            discordRPC.Initialize("831055177330851851", ref this.handlers, true, null);
            this.presence.details = usern.Text;
            this.presence.state = "Zaytron";
            this.presence.largeImageKey = "zaytron";
            this.presence.smallImageKey = "zaytron";
            this.presence.largeImageText = "Zaytron";
            this.presence.smallImageText = "Zaytron";
            this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            discordRPC.UpdatePresence(ref this.presence);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ArdaDDemir");
        }
    }
}
