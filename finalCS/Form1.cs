using finalCS.Data;

namespace finalCS
{
    public partial class MainDashboard : Form
    {
        private readonly MyDbContext _context;
        public MainDashboard()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button_ProductManagement_Click(object sender, EventArgs e)
        {
            var productForm = new ProductManagementForm();
            productForm.Show();
        }

        private void button_TransactionRecording_Click(object sender, EventArgs e)
        {
            var transactionForm = new TransactionRecordingForm();
            transactionForm.Show();
        }

        private void button_InventoryStatus_Click(object sender, EventArgs e)
        {
            var transactionForm = new TransactionRecordingForm();
            transactionForm.Show();
        }

        private void button_Reports_Click(object sender, EventArgs e)
        {
            var reportsForm = new ReportsForm();
            reportsForm.Show();
        }
    }
}
