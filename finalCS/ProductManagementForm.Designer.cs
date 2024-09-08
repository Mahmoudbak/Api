namespace finalCS
{
    partial class ProductManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_Products = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            textBox_Name = new TextBox();
            comboBox_Category = new ComboBox();
            button_AddProduct = new Button();
            label4 = new Label();
            textBox_Description = new TextBox();
            label3 = new Label();
            textBox_Price = new TextBox();
            label2 = new Label();
            textBox_StockQuantity = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Products).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Products
            // 
            dataGridView_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Products.Location = new Point(240, 0);
            dataGridView_Products.Name = "dataGridView_Products";
            dataGridView_Products.RowHeadersWidth = 51;
            dataGridView_Products.Size = new Size(980, 471);
            dataGridView_Products.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox_Name);
            panel1.Controls.Add(comboBox_Category);
            panel1.Controls.Add(button_AddProduct);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_Description);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox_Price);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_StockQuantity);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 471);
            panel1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 271);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 23;
            label5.Text = "CategoryID ";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(12, 32);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(205, 27);
            textBox_Name.TabIndex = 14;
            // 
            // comboBox_Category
            // 
            comboBox_Category.FormattingEnabled = true;
            comboBox_Category.Location = new Point(11, 298);
            comboBox_Category.Name = "comboBox_Category";
            comboBox_Category.Size = new Size(204, 28);
            comboBox_Category.TabIndex = 22;
            // 
            // button_AddProduct
            // 
            button_AddProduct.Location = new Point(123, 416);
            button_AddProduct.Name = "button_AddProduct";
            button_AddProduct.Size = new Size(94, 29);
            button_AddProduct.TabIndex = 13;
            button_AddProduct.Text = "Add";
            button_AddProduct.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 360);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 21;
            label4.Text = "StockQuantity";
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(12, 123);
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(205, 27);
            textBox_Description.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 193);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 20;
            label3.Text = "Price";
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(12, 218);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(205, 27);
            textBox_Price.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 98);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 19;
            label2.Text = "Description";
            // 
            // textBox_StockQuantity
            // 
            textBox_StockQuantity.Location = new Point(10, 383);
            textBox_StockQuantity.Name = "textBox_StockQuantity";
            textBox_StockQuantity.Size = new Size(205, 27);
            textBox_StockQuantity.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 18;
            label1.Text = "Name";
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 471);
            Controls.Add(panel1);
            Controls.Add(dataGridView_Products);
            Name = "ProductManagementForm";
            Text = "ProductManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Products).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Products;
        private Panel panel1;
        private Label label5;
        private TextBox textBox_Name;
        private ComboBox comboBox_Category;
        private Button button_AddProduct;
        private Label label4;
        private TextBox textBox_Description;
        private Label label3;
        private TextBox textBox_Price;
        private Label label2;
        private TextBox textBox_StockQuantity;
        private Label label1;
    }
}