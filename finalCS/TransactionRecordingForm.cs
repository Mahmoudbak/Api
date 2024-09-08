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

namespace finalCS
{
    public partial class TransactionRecordingForm : Form
    {
        private readonly MyDbContext _context;
        public TransactionRecordingForm()
        {
            InitializeComponent();
            _context = new MyDbContext();
            LoadProducts();
        }
        private void LoadProducts()
        {
            var products = _context.Products.ToList();
            comboBox_Products.DataSource = products;
            comboBox_Products.DisplayMember = "Name";
            comboBox_Products.ValueMember = "ProductID";
        }

        

        private void button_RecordTransaction_Click(object sender, EventArgs e)
        {
            var transaction = new Transaction
            {
                ProductID = (int)comboBox_ProductID.SelectedValue,
                Date = dateTimePicker_Date.Value,
                Quantity = int.Parse(textBox_Quantity.Text),
                Type = comboBox_Type.SelectedItem.ToString(),
                Notes = textBox_Notes.Text
            };
            _context.Transactions.Add(transaction);
            _context.SaveChanges();

        }
    }
}
