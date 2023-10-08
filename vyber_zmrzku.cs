using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        string ret;
        string ret1 = "Vanilková";
        string ret2= " posypaná oříšky";
        string ret3 = " 1 kopeček";
        string ret4 = " normální";
        
        private void vyber_zmrzku_Load(object sender, EventArgs e) {
            timer_cas.Start();
            StripStatusLabel_trackbarPosition.Text = trackBar_disk.Value.ToString();
            ret = ret1 + ret2 + ret3 + ret4;
            label_summaryVyber.Text = ret;
            comboBox_tuky.SelectedIndex = 1;
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

        private void radioButton_vanilkova_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_vanilkova.Checked) {
                ret1 = "Vanilková";
                ret = ret1 + ret2 + ret3 + ret4;
                label_summaryVyber.Text = ret;
            }            
        }

        private void radioButton_cokoladova_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_cokoladova.Checked) {
                ret1 = "Čokoládová";
                ret = ret1 + ret2 + ret3 + ret4;
                label_summaryVyber.Text = ret;
            }
        }

        private void radioButton_michana_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_michana.Checked) {
                ret1 = "Míchaná";
                ret = ret1 + ret2 + ret3 + ret4;
                label_summaryVyber.Text = ret;
            }
        }

        private void checkBox_orisky_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_orisky.Checked) {
                ret2 = " posypaná oříšky";
            }
            else ret2 = "";
            ret = ret1 + ret2 + ret3 + ret4;
            label_summaryVyber.Text = ret;
        }

        private void numericUpDown_kopecky_ValueChanged(object sender, EventArgs e) {
            if (numericUpDown_kopecky.Value ==1) {
                ret3 = " 1 kopeček";
            }
            else ret3 = " " + numericUpDown_kopecky.Value.ToString() + " kopečky";
            ret = ret1 + ret2 + ret3 + ret4;
            label_summaryVyber.Text = ret;
        }

        private void comboBox_tuky_SelectedIndexChanged(object sender, EventArgs e) {
            ret4 = " " + comboBox_tuky.SelectedItem.ToString();
            ret = ret1 + ret2 + ret3 + ret4;
            label_summaryVyber.Text = ret;
        }
    }
}
