namespace finalCS
{
    partial class MainDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_ProductManagement = new Button();
            button_TransactionRecording = new Button();
            button_InventoryStatus = new Button();
            button_Reports = new Button();
            SuspendLayout();
            // 
            // button_ProductManagement
            // 
            button_ProductManagement.Location = new Point(142, 33);
            button_ProductManagement.Name = "button_ProductManagement";
            button_ProductManagement.Size = new Size(208, 29);
            button_ProductManagement.TabIndex = 0;
            button_ProductManagement.Text = "ProductManagement";
            button_ProductManagement.UseVisualStyleBackColor = true;
            button_ProductManagement.Click += button_ProductManagement_Click;
            // 
            // button_TransactionRecording
            // 
            button_TransactionRecording.Location = new Point(142, 95);
            button_TransactionRecording.Name = "button_TransactionRecording";
            button_TransactionRecording.Size = new Size(208, 29);
            button_TransactionRecording.TabIndex = 1;
            button_TransactionRecording.Text = "TransactionRecording";
            button_TransactionRecording.UseVisualStyleBackColor = true;
            button_TransactionRecording.Click += button_TransactionRecording_Click;
            // 
            // button_InventoryStatus
            // 
            button_InventoryStatus.Location = new Point(142, 152);
            button_InventoryStatus.Name = "button_InventoryStatus";
            button_InventoryStatus.Size = new Size(208, 29);
            button_InventoryStatus.TabIndex = 2;
            button_InventoryStatus.Text = "InventoryStatus";
            button_InventoryStatus.UseVisualStyleBackColor = true;
            button_InventoryStatus.Click += button_InventoryStatus_Click;
            // 
            // button_Reports
            // 
            button_Reports.Location = new Point(142, 217);
            button_Reports.Name = "button_Reports";
            button_Reports.Size = new Size(208, 29);
            button_Reports.TabIndex = 3;
            button_Reports.Text = "Reports";
            button_Reports.UseVisualStyleBackColor = true;
            button_Reports.Click += button_Reports_Click;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 288);
            Controls.Add(button_Reports);
            Controls.Add(button_InventoryStatus);
            Controls.Add(button_TransactionRecording);
            Controls.Add(button_ProductManagement);
            Name = "MainDashboard";
            Text = "MainDashboard";
            Load += MainDashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_ProductManagement;
        private Button button_TransactionRecording;
        private Button button_InventoryStatus;
        private Button button_Reports;
    }
}
