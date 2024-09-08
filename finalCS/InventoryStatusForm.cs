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
    public partial class InventoryStatusForm : Form
    {
        private readonly MyDbContext _context;
        public InventoryStatusForm()
        {
            InitializeComponent();
            _context = new MyDbContext();
            LoadInventoryStatus();
        }
        private void LoadInventoryStatus()
        {
            var inventory = _context.Products.ToList();
            dataGridView_InventoryStatus.DataSource = inventory;
        }
    }
}
