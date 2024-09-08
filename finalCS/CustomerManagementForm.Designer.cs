namespace finalCS
{
    partial class CustomerManagementForm
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
            dataGridView_Customers = new DataGridView();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            textBox_phone = new TextBox();
            textBox_Email = new TextBox();
            button1 = new Button();
            textBox_Name = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBox_lastName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Customers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Customers
            // 
            dataGridView_Customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Customers.Dock = DockStyle.Right;
            dataGridView_Customers.Location = new Point(214, 0);
            dataGridView_Customers.Name = "dataGridView_Customers";
            dataGridView_Customers.RowHeadersWidth = 51;
            dataGridView_Customers.Size = new Size(586, 450);
            dataGridView_Customers.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_lastName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_phone);
            panel1.Controls.Add(textBox_Email);
            panel1.Controls.Add(textBox_Name);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 450);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 172);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 119);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(5, 195);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(202, 27);
            textBox_phone.TabIndex = 3;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(0, 142);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(205, 27);
            textBox_Email.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(98, 228);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(0, 32);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(212, 27);
            textBox_Name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 4;
            label1.Text = "FirstName";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 62);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "lastName";
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(3, 89);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(212, 27);
            textBox_lastName.TabIndex = 7;
            // 
            // CustomerManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView_Customers);
            Name = "CustomerManagementForm";
            Text = "CustomerManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Customers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Customers;
        private Panel panel1;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox_phone;
        private TextBox textBox_Email;
        private Label label4;
        private TextBox textBox_lastName;
        private Label label1;
        private TextBox textBox_Name;
    }
}