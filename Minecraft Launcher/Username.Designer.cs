namespace Minecraft_Launcher
{
    partial class Username
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usern = new System.Windows.Forms.TextBox();
            this.play = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vers = new System.Windows.Forms.ComboBox();
            this.log = new System.Windows.Forms.ListBox();
            this.settings = new System.Windows.Forms.PictureBox();
            this.ram1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dasdsa = new System.Windows.Forms.Label();
            this.wid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hei = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kpt = new System.Windows.Forms.Label();
            this.kpt1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zaytron Launcher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Minecraft_Launcher.Properties.Resources.zaytron_logo;
            this.pictureBox1.Location = new System.Drawing.Point(79, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // usern
            // 
            this.usern.Location = new System.Drawing.Point(70, 218);
            this.usern.Name = "usern";
            this.usern.ShortcutsEnabled = false;
            this.usern.Size = new System.Drawing.Size(178, 23);
            this.usern.TabIndex = 4;
            this.usern.TextChanged += new System.EventHandler(this.user_TextChanged);
            this.usern.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.ForeColor = System.Drawing.Color.Lime;
            this.play.Location = new System.Drawing.Point(99, 436);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(114, 29);
            this.play.TabIndex = 5;
            this.play.Text = "OYNA";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // vers
            // 
            this.vers.FormattingEnabled = true;
            this.vers.Location = new System.Drawing.Point(70, 262);
            this.vers.Name = "vers";
            this.vers.Size = new System.Drawing.Size(178, 23);
            this.vers.TabIndex = 7;
            // 
            // log
            // 
            this.log.FormattingEnabled = true;
            this.log.ItemHeight = 15;
            this.log.Location = new System.Drawing.Point(33, 291);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(248, 139);
            this.log.TabIndex = 8;
            this.log.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.Image = global::Minecraft_Launcher.Properties.Resources.setting;
            this.settings.Location = new System.Drawing.Point(259, 436);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(44, 41);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settings.TabIndex = 9;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ram1
            // 
            this.ram1.Location = new System.Drawing.Point(330, 77);
            this.ram1.Name = "ram1";
            this.ram1.Size = new System.Drawing.Size(124, 23);
            this.ram1.TabIndex = 10;
            this.ram1.Text = "2048";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat ExtraBold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(330, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ayarlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(330, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ram";
            // 
            // dasdsa
            // 
            this.dasdsa.AutoSize = true;
            this.dasdsa.BackColor = System.Drawing.Color.Transparent;
            this.dasdsa.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dasdsa.ForeColor = System.Drawing.Color.White;
            this.dasdsa.Location = new System.Drawing.Point(330, 117);
            this.dasdsa.Name = "dasdsa";
            this.dasdsa.Size = new System.Drawing.Size(63, 18);
            this.dasdsa.TabIndex = 14;
            this.dasdsa.Text = "Genişlik";
            // 
            // wid
            // 
            this.wid.Location = new System.Drawing.Point(330, 140);
            this.wid.Name = "wid";
            this.wid.Size = new System.Drawing.Size(124, 23);
            this.wid.TabIndex = 13;
            this.wid.Text = "1600";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(330, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Yükseklik";
            // 
            // hei
            // 
            this.hei.Location = new System.Drawing.Point(330, 211);
            this.hei.Name = "hei";
            this.hei.Size = new System.Drawing.Size(124, 23);
            this.hei.TabIndex = 15;
            this.hei.Text = "900";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(330, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Arda Demir tarafından kodlanmıştır";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // kpt
            // 
            this.kpt.AutoSize = true;
            this.kpt.BackColor = System.Drawing.Color.Transparent;
            this.kpt.Font = new System.Drawing.Font("Montserrat ExtraBold", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.kpt.ForeColor = System.Drawing.Color.White;
            this.kpt.Location = new System.Drawing.Point(275, 12);
            this.kpt.Name = "kpt";
            this.kpt.Size = new System.Drawing.Size(16, 16);
            this.kpt.TabIndex = 18;
            this.kpt.Text = "X";
            this.kpt.Click += new System.EventHandler(this.kpt_Click);
            // 
            // kpt1
            // 
            this.kpt1.AutoSize = true;
            this.kpt1.BackColor = System.Drawing.Color.Transparent;
            this.kpt1.Font = new System.Drawing.Font("Montserrat ExtraBold", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.kpt1.ForeColor = System.Drawing.Color.White;
            this.kpt1.Location = new System.Drawing.Point(618, 9);
            this.kpt1.Name = "kpt1";
            this.kpt1.Size = new System.Drawing.Size(16, 16);
            this.kpt1.TabIndex = 19;
            this.kpt1.Text = "X";
            this.kpt1.Click += new System.EventHandler(this.kpt1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(70, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Sürüm";
            // 
            // Username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Minecraft_Launcher.Properties.Resources.Mcl1;
            this.ClientSize = new System.Drawing.Size(303, 477);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kpt1);
            this.Controls.Add(this.kpt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hei);
            this.Controls.Add(this.dasdsa);
            this.Controls.Add(this.wid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ram1);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.log);
            this.Controls.Add(this.vers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.play);
            this.Controls.Add(this.usern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Username";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Username";
            this.Load += new System.EventHandler(this.Username_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usern;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vers;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.TextBox ram1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dasdsa;
        private System.Windows.Forms.TextBox wid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hei;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label kpt;
        private System.Windows.Forms.Label kpt1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
    }
}