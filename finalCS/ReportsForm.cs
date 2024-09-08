using finalCS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalCS
{
    public partial class ReportsForm : Form
    {
        private readonly MyDbContext _context;
        public ReportsForm()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var reportGenerator = new ReportGenerator(_context);
            await reportGenerator.GenerateInventoryStatusReport(dataGridView1);
        }
    }
    public class ReportGenerator
    {
        private readonly MyDbContext _context;

        public ReportGenerator(MyDbContext context)
        {
            _context = context;
        }

        public async Task GenerateInventoryStatusReport(DataGridView dataGridView)
        {
            var reportData = await _context.Products
                .Select(p => new
                {
                    p.ProductID,
                    p.Name,
                    p.Description,
                    p.Price,
                    p.StockQuantity,
                    CategoryName = p.Category.CategoryName
                })
                .ToListAsync();

            dataGridView.DataSource = reportData;

            dataGridView.Columns["ProductID"].HeaderText = "Product ID";
            dataGridView.Columns["Name"].HeaderText = "Product Name";
            dataGridView.Columns["Description"].HeaderText = "Description";
            dataGridView.Columns["Price"].HeaderText = "Price";
            dataGridView.Columns["StockQuantity"].HeaderText = "Stock Quantity";
            dataGridView.Columns["CategoryName"].HeaderText = "Category";
        }
    }

}
