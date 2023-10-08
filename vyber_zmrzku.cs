using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zmrzlina {
    public partial class vyber_zmrzku : Form {
        public vyber_zmrzku() {
            InitializeComponent();
        }
        private void vyber_zmrzku_Load(object sender, EventArgs e) {
            timer_cas.Start();
        }
        private void timer_cas_Tick(object sender, EventArgs e) {
            StatusStripStatusLabel_cas.Text = DateTime.Now.ToLongTimeString();            
        }

        private void button_zmrzka_Click(object sender, EventArgs e) {
            this.Close();  
        }
    }
}
