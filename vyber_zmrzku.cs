using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zmrzlina {
    public partial class vyber_zmrzku : Form {
        public vyber_zmrzku() {
            InitializeComponent();
        }
        private void vyber_zmrzku_Load(object sender, EventArgs e) {
            timer_cas.Start();
            StripStatusLabel_trackbarPosition.Text = trackBar_disk.Value.ToString();
        }
        private void timer_cas_Tick(object sender, EventArgs e) {
            StripStatusLabel_cas.Text = DateTime.Now.ToLongTimeString();
            if (progressBar_instalace.Value >= progressBar_instalace.Maximum) progressBar_instalace.Value += -timer_cas.Interval + timer_cas.Interval;
            else progressBar_instalace.Value += timer_cas.Interval;
        }

        private void button_zmrzka_Click(object sender, EventArgs e) {
            this.Close();  
        }

        private void trackBar_disk_Scroll(object sender, EventArgs e) {
            StripStatusLabel_trackbarPosition.Text = trackBar_disk.Value.ToString();
        }
    }
}
