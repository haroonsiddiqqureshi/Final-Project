using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Final_Project
{

    public partial class Form1 : Form
    {
        private BindingList<string> itemLists = new BindingList<string>();
        public Form1()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(@"C:\Users\lenovo\Desktop\Workshop\Visual Studio\Final Project\bin\Debug\data.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int lastUsedRow = worksheet.Dimension.End.Row;
                for (int row = 1; row <= lastUsedRow; row++)
                {
                    string value = worksheet.Cells[row, 1].Value?.ToString();
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.dataGridView1.Rows.Add(value);
                    }
                }
            }
        }

        private void addLaptopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopLaptop shopLaptop = new ShopLaptop();
            shopLaptop.ShowDialog();
            if (shopLaptop.DialogResult == DialogResult.OK)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
                using (ExcelPackage package = new ExcelPackage(new FileInfo(@"C:\Users\lenovo\Desktop\Workshop\Visual Studio\Final Project\bin\Debug\data.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                    int lastUsedRow = worksheet.Dimension.End.Row;
                    string value = worksheet.Cells[lastUsedRow, 1].Value?.ToString();
                    this.dataGridView1.Rows.Add(value);
                }
            }
        }

        private void addTabletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopTablet shopTablet = new ShopTablet();
            shopTablet.ShowDialog();
            if (shopTablet.DialogResult == DialogResult.OK)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
                using (ExcelPackage package = new ExcelPackage(new FileInfo(@"C:\Users\lenovo\Desktop\Workshop\Visual Studio\Final Project\bin\Debug\data.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                    int lastUsedRow = worksheet.Dimension.End.Row;
                    string value = worksheet.Cells[lastUsedRow, 1].Value?.ToString();
                    this.dataGridView1.Rows.Add(value);
                }
            }
        }
    }
}
