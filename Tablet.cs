﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Tablet : Device
    {
        private string storage;
        private string connectivity;
        private string screen_size;
        public Tablet(string name, int price, string screen_size, string color, string storage, string connectivity) : base(name, color, price)
        {
            this.screen_size = screen_size;
            this.storage = storage;
            this.connectivity = connectivity;
        }
        public string getStorage()
        {
            return this.storage;
        }
        public string getConnectivity()
        {
            return this.connectivity;
        }
        public string getScreen_size()
        {
            return this.screen_size;
        }
    }

    
}
