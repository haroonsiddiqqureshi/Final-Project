using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final_Project
{
    internal class Macbook : Device
    {
        private string chip;
        public Macbook(string name, int price, string chip, string color) : base(name, color, price)
        {
            this.chip = chip;
        }
        public string getChip()
        {
            return chip;
        }
    }
}
