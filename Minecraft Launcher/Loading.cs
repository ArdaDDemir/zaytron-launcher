using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Minecraft_Launcher
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();

        }
        private discordRPC.EventHandlers handlers;
        private discordRPC.RichPresence presence;

        private void Loading_Load(object sender, EventArgs e)
        {
           
                this.handlers = default(discordRPC.EventHandlers);
            discordRPC.Initialize("831055177330851851", ref this.handlers, true, null);
                this.presence.details = "Yükleniyor";
                this.presence.state = "Zaytron";
            this.presence.largeImageKey = "zaytron";
            this.presence.smallImageKey = "zaytron";
            this.presence.largeImageText = "Zaytron";
            this.presence.smallImageText = "Zaytron";
            this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            discordRPC.UpdatePresence(ref this.presence);
            
        }






        private void button1_Click(object sender, EventArgs e)
        {

         
        }

            private void timer1_Tick(object sender, EventArgs e)
        {
            Username form2 = new Username();
            form2.Show();  // form2 göster diyoruz
            this.Hide();   // bu yani form1 gizle diyoruz
            timer1.Stop();

        }

        private void dgr_TextChanged(object sender, EventArgs e)
        {
        
        }
    }


}
