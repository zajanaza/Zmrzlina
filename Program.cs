using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zmrzlina {
    internal class Program {
        static void Main(string[] args) {
            //vyber_zmrzku formZmrka = new vyber_zmrzku();
            InputBox inputBox = new InputBox();
            inputBox.ShowDialog();
            //formZmrka.ShowDialog();            
        }
    }
}
