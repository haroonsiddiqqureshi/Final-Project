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
        private int price;

        public Device(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string getName() 
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
    }
}
