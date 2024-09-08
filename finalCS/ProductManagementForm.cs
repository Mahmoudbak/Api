using finalCS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace finalCS
{
    public partial class ProductManagementForm : Form
    {
        private readonly MyDbContext _context;
        public ProductManagementForm()
        {
            InitializeComponent();
            _context = new MyDbContext();
            LoadProducts();
        }
        private void LoadProducts()
        {
            var products = _context.Products.ToList();
            dataGridView_Products.DataSource = products;
        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = textBox_Name.Text,
                Description = textBox_Description.Text,
                Price = decimal.Parse(textBox_Price.Text),
                CategoryID = (int)comboBox_Category.SelectedValue,
                StockQuantity = int.Parse(textBox_StockQuantity.Text)
            };
            _context.Products.Add(product);
            _context.SaveChanges();
            LoadProducts();
        }

      
    }
}
