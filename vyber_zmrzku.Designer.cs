namespace Zmrzlina {
    partial class vyber_zmrzku {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vyber_zmrzku));
            this.button_zmrzka = new System.Windows.Forms.Button();
            this.toolStrip_vyberTypu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.timer_cas = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusLabel_cas = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar_instalace = new System.Windows.Forms.ProgressBar();
            this.label_instalace = new System.Windows.Forms.Label();
            this.trackBar_disk = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.StripStatusLabel_trackbarPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip_vyberTypu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_disk)).BeginInit();
            this.SuspendLayout();
            // 
            // button_zmrzka
            // 
            this.button_zmrzka.Image = ((System.Drawing.Image)(resources.GetObject("button_zmrzka.Image")));
            this.button_zmrzka.Location = new System.Drawing.Point(695, 64);
            this.button_zmrzka.Name = "button_zmrzka";
            this.button_zmrzka.Size = new System.Drawing.Size(68, 57);
            this.button_zmrzka.TabIndex = 0;
            this.button_zmrzka.UseVisualStyleBackColor = true;
            this.button_zmrzka.Click += new System.EventHandler(this.button_zmrzka_Click);
            // 
            // toolStrip_vyberTypu
            // 
            this.toolStrip_vyberTypu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip_vyberTypu.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_vyberTypu.Name = "toolStrip_vyberTypu";
            this.toolStrip_vyberTypu.Size = new System.Drawing.Size(800, 25);
            this.toolStrip_vyberTypu.TabIndex = 1;
            this.toolStrip_vyberTypu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Na klacku";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Do kemílku";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Točená";
            // 
            // timer_cas
            // 
            this.timer_cas.Interval = 1;
            this.timer_cas.Tick += new System.EventHandler(this.timer_cas_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusLabel_cas,
            this.StripStatusLabel_trackbarPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusLabel_cas
            // 
            this.StripStatusLabel_cas.Name = "StripStatusLabel_cas";
            this.StripStatusLabel_cas.Size = new System.Drawing.Size(24, 17);
            this.StripStatusLabel_cas.Text = "cas";
            // 
            // progressBar_instalace
            // 
            this.progressBar_instalace.Location = new System.Drawing.Point(12, 346);
            this.progressBar_instalace.Maximum = 2000;
            this.progressBar_instalace.Name = "progressBar_instalace";
            this.progressBar_instalace.Size = new System.Drawing.Size(355, 36);
            this.progressBar_instalace.TabIndex = 3;
            // 
            // label_instalace
            // 
            this.label_instalace.AutoSize = true;
            this.label_instalace.Location = new System.Drawing.Point(119, 394);
            this.label_instalace.Name = "label_instalace";
            this.label_instalace.Size = new System.Drawing.Size(151, 13);
            this.label_instalace.TabIndex = 4;
            this.label_instalace.Text = "Instalace probíhá, čekejte (2s)";
            // 
            // trackBar_disk
            // 
            this.trackBar_disk.Location = new System.Drawing.Point(12, 291);
            this.trackBar_disk.Name = "trackBar_disk";
            this.trackBar_disk.Size = new System.Drawing.Size(354, 45);
            this.trackBar_disk.TabIndex = 5;
            this.trackBar_disk.Value = 4;
            this.trackBar_disk.Scroll += new System.EventHandler(this.trackBar_disk_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "% disku pro offline složky (viz status bar)\r\n";
            // 
            // StripStatusLabel_trackbarPosition
            // 
            this.StripStatusLabel_trackbarPosition.Name = "StripStatusLabel_trackbarPosition";
            this.StripStatusLabel_trackbarPosition.Size = new System.Drawing.Size(118, 17);
            this.StripStatusLabel_trackbarPosition.Text = "toolStripStatusLabel1";
            // 
            // vyber_zmrzku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_disk);
            this.Controls.Add(this.label_instalace);
            this.Controls.Add(this.progressBar_instalace);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip_vyberTypu);
            this.Controls.Add(this.button_zmrzka);
            this.Name = "vyber_zmrzku";
            this.Text = "vyber_zmrzku";
            this.Load += new System.EventHandler(this.vyber_zmrzku_Load);
            this.toolStrip_vyberTypu.ResumeLayout(false);
            this.toolStrip_vyberTypu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_disk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_zmrzka;
        private System.Windows.Forms.ToolStrip toolStrip_vyberTypu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Timer timer_cas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabel_cas;
        private System.Windows.Forms.ProgressBar progressBar_instalace;
        private System.Windows.Forms.Label label_instalace;
        private System.Windows.Forms.TrackBar trackBar_disk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabel_trackbarPosition;
    }
}