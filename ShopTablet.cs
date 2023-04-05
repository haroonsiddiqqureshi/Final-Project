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
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Project
{
    public partial class ShopTablet : Form
    {
        public string name;
        public string color;
        public string storage;
        public string connectivity;
        public string screen_size;
        public ShopTablet()
        {
            InitializeComponent();
            comboStorage.Items.Add("64GB");
            comboStorage.Items.Add("265GB");
            comboScreen.Items.Add("11Inch");
            comboScreen.Items.Add("12.9Inch");
            string[] option = { "Space Gray", "Starlight", "Pink", "Purple", "Blue" };
            comboColor.Items.AddRange(option);
            string[] option1 = { "Space Gray", "Silver" };
            comboColor2.Items.AddRange(option1);
            string[] option2 = { "128GB", "256GB", "512GB", "1TB", "2TB" };
            comboStorage2.Items.AddRange(option2);
            string[] option3 = { "Wifi", "Wifi + Cellular" };
            comboCon.Items.AddRange(option3);
            comboCon2.Items.AddRange(option3);
        }

        private void addToCart2_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            name = this.tablet1.Text;
            screen_size= "10.9Inch";
            color = this.comboColor.SelectedItem.ToString();
            storage = this.comboStorage.SelectedItem.ToString();
            connectivity = this.comboCon.SelectedItem.ToString();
            Tablet tablet = new Tablet(name, 19000, screen_size, color, storage, connectivity);
            var message = $"คุณสั่งชื้อ {tablet.getName()} \nโดยมี \nScreen Size: {tablet.getScreen_size()} \nColor: {tablet.getColor()} \nStorage: {tablet.getStorage()} \nConnectivity: {tablet.getConnectivity()} \nในราคา: {tablet.getPrice()}";
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

        private void addToCart3_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            name = this.tablet2.Text;
            screen_size = this.comboScreen.SelectedItem.ToString();
            color = this.comboColor2.SelectedItem.ToString();
            storage = this.comboStorage2.SelectedItem.ToString();
            connectivity = this.comboCon2.SelectedItem.ToString();
            Tablet tablet = new Tablet(name, 19000, screen_size, color, storage, connectivity);
            var message = $"คุณสั่งชื้อ {tablet.getName()} \nโดยมี \nScreen Size: {tablet.getScreen_size()} \nColor: {tablet.getColor()} \nStorage: {tablet.getStorage()} \nConnectivity: {tablet.getConnectivity()} \nในราคา: {tablet.getPrice()}";
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
