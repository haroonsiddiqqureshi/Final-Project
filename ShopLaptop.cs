using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;

namespace Final_Project
{

    public partial class ShopLaptop : Form
    {
        public string name;
        public string cpu;
        public string ram;
        public string disk;
        public string gpu;
        public string chip;
        public string color;
        public ShopLaptop()
        {
            InitializeComponent();
            comboCpu.Items.Add("Intel core I5 gen 9");
            comboCpu.Items.Add("Intel core I5 gen 10");
            comboCpu.Items.Add("AMD Ryzen 5");
            comboRam.Items.Add("8GB");
            comboRam.Items.Add("16GB");
            comboDisk.Items.Add("512GB SSD");
            comboDisk.Items.Add("1TB SSD");
            comboGraphic.Items.Add("NVIDIA GeForce GTX 1650");
            comboGraphic.Items.Add("NVIDIA GeForce RTX 2060");
            comboChip.Items.Add("Macbook Air M1");
            comboChip.Items.Add("Macbook Air M2");
            comboColor.Items.Add("Midnight");
            comboColor.Items.Add("Starlight");
            comboColor.Items.Add("Space Gray");
            comboColor.Items.Add("Silver");
        }
     
        private void addToCart2_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            name = this.laptop2.Text;
            cpu = this.comboCpu.SelectedItem.ToString();
            ram = this.comboRam.SelectedItem.ToString();
            disk = this.comboDisk.SelectedItem.ToString();
            gpu = this.comboGraphic.SelectedItem.ToString();
            Laptop laptop = new Laptop(name, 35000, cpu, ram, disk, gpu);
            var message = $"คุณสั่งชื้อ {laptop.getName()} \nโดยมี \ncpu: {laptop.getCPU()} \nram: {laptop.getRam()} \ndisk: {laptop.getDisk()} \ngpu:{laptop.getGPU()} \nในราคา: {laptop.getPrice()}";

            using (var package = new ExcelPackage(new FileInfo(@"C:\Users\lenovo\Desktop\Workshop\Visual Studio\Final Project\bin\Debug\data.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet does not exist");
                }
                int lastUsedRow = worksheet.Dimension.End.Row;

                ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                cell.Value = message;

                package.Save();
            }
            this.DialogResult = DialogResult.OK;
            this.Hide();
            MessageBox.Show(message);
        }

        private void addToCart5_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            name = this.laptop5.Text;
            chip = this.comboChip.SelectedItem.ToString();
            color = this.comboColor.SelectedItem.ToString();
            Macbook macbook = new Macbook(name, 55000, chip , color);
            var message = $"คุณสั่งชื้อ {macbook.getName()} \nโดยมี \nChip: {macbook.getChip()} \nColor: {macbook.getColor()} \nในราคา: {macbook.getPrice()}";
            
            using (var package = new ExcelPackage(new FileInfo(@"C:\Users\lenovo\Desktop\Workshop\Visual Studio\Final Project\bin\Debug\data.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet does not exist");
                }
                int lastUsedRow = worksheet.Dimension.End.Row;

                ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                cell.Value = message;

                package.Save();
            }
            this.DialogResult = DialogResult.OK;
            this.Hide();
            MessageBox.Show(message);
        }
    }
}
