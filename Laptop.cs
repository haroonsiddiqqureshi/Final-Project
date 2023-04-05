using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Laptop : Device
    {
        private string cpu;
        private string ram;
        private string disk;
        private string gpu;
        public Laptop(string name,int price,string cpu, string ram, string disk, string gpu) : base(name,price)
        {
            this.cpu = cpu;
            this.ram = ram;    
            this.disk = disk;
            this.gpu = gpu; 
        }
        public string getCPU() 
        {
            return cpu;
        }
        public string getRam()
        {
            return ram;
        }
        public string getDisk()
        {
            return disk;
        }
        public string getGPU()
        {
            return gpu;
        }
    }
}
