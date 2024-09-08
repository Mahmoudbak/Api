namespace finalCS
{
    partial class TransactionRecordingForm
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
            comboBox_Products = new ComboBox();
            comboBox_ProductID = new ComboBox();
            comboBox_Type = new ComboBox();
            textBox_Quantity = new TextBox();
            textBox_Notes = new TextBox();
            dateTimePicker_Date = new DateTimePicker();
            label1 = new Label();
            label_ProductID = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button_RecordTransaction = new Button();
            SuspendLayout();
            // 
            // comboBox_Products
            // 
            comboBox_Products.FormattingEnabled = true;
            comboBox_Products.Location = new Point(4, 36);
            comboBox_Products.Name = "comboBox_Products";
            comboBox_Products.Size = new Size(248, 28);
            comboBox_Products.TabIndex = 0;
            // 
            // comboBox_ProductID
            // 
            comboBox_ProductID.FormattingEnabled = true;
            comboBox_ProductID.Location = new Point(4, 90);
            comboBox_ProductID.Name = "comboBox_ProductID";
            comboBox_ProductID.Size = new Size(248, 28);
            comboBox_ProductID.TabIndex = 3;
            // 
            // comboBox_Type
            // 
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Location = new Point(0, 250);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(261, 28);
            comboBox_Type.TabIndex = 4;
            // 
            // textBox_Quantity
            // 
            textBox_Quantity.Location = new Point(9, 197);
            textBox_Quantity.Name = "textBox_Quantity";
            textBox_Quantity.Size = new Size(252, 27);
            textBox_Quantity.TabIndex = 5;
            // 
            // textBox_Notes
            // 
            textBox_Notes.Location = new Point(0, 304);
            textBox_Notes.Name = "textBox_Notes";
            textBox_Notes.Size = new Size(261, 27);
            textBox_Notes.TabIndex = 6;
            // 
            // dateTimePicker_Date
            // 
            dateTimePicker_Date.Location = new Point(6, 144);
            dateTimePicker_Date.Name = "dateTimePicker_Date";
            dateTimePicker_Date.Size = new Size(250, 27);
            dateTimePicker_Date.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 13);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 8;
            label1.Text = "Products";
            // 
            // label_ProductID
            // 
            label_ProductID.AutoSize = true;
            label_ProductID.Location = new Point(4, 67);
            label_ProductID.Name = "label_ProductID";
            label_ProductID.Size = new Size(75, 20);
            label_ProductID.TabIndex = 11;
            label_ProductID.Text = "ProductID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 174);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 12;
            label5.Text = "Quantity ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 121);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 13;
            label6.Text = "Date ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 227);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 14;
            label7.Text = "Type ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 281);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 15;
            label8.Text = "Notes ";
            // 
            // button_RecordTransaction
            // 
            button_RecordTransaction.Location = new Point(107, 348);
            button_RecordTransaction.Name = "button_RecordTransaction";
            button_RecordTransaction.Size = new Size(154, 29);
            button_RecordTransaction.TabIndex = 16;
            button_RecordTransaction.Text = "RecordTransaction";
            button_RecordTransaction.UseVisualStyleBackColor = true;
            button_RecordTransaction.Click += button_RecordTransaction_Click;
            // 
            // TransactionRecordingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 412);
            Controls.Add(button_RecordTransaction);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label_ProductID);
            Controls.Add(label1);
            Controls.Add(dateTimePicker_Date);
            Controls.Add(textBox_Notes);
            Controls.Add(textBox_Quantity);
            Controls.Add(comboBox_Type);
            Controls.Add(comboBox_ProductID);
            Controls.Add(comboBox_Products);
            Name = "TransactionRecordingForm";
            Text = "TransactionRecordingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Products;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox_ProductID;
        private ComboBox comboBox_Type;
        private TextBox textBox_Quantity;
        private TextBox textBox_Notes;
        private DateTimePicker dateTimePicker_Date;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label_ProductID;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button_RecordTransaction;
    }
}