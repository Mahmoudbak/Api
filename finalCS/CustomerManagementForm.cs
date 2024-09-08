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
    public partial class CustomerManagementForm : Form
    {
        private readonly MyDbContext _context;
        public CustomerManagementForm(MyDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            var customers = _context.Customers.ToList();
            dataGridView_Customers.DataSource = customers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newCustomer = new Customer
            {
                FirstName = textBox_Name.Text,
                LastName = textBox_Name.Text,
                Email = textBox_Email.Text,
                PhoneNumber = textBox_phone.Text
            };
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            LoadCustomers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
