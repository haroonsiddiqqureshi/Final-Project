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
        private string color;
        public Macbook(string name,int price, string chip, string color) : base(name,price)
        {
            this.chip = chip;
            this.color = color;
        }
        public string getChip()
        {
            return chip;
        }
        public string getColor()
        {
            return color;
        }
    }
}
