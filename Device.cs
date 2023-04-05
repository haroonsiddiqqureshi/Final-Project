using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Device
    {
        private string name;
        private string color;
        private int price;

        public Device(string name, string color, int price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }
        public string getName() 
        {
            return name;
        }
        public string getColor()
        {
            return color;
        }
        public int getPrice()
        {
            return price;
        }
    }
}
