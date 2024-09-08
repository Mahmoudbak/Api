namespace finalCS
{
    partial class InventoryStatusForm
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
            dataGridView_InventoryStatus = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_InventoryStatus).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_InventoryStatus
            // 
            dataGridView_InventoryStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_InventoryStatus.Dock = DockStyle.Fill;
            dataGridView_InventoryStatus.Location = new Point(0, 0);
            dataGridView_InventoryStatus.Name = "dataGridView_InventoryStatus";
            dataGridView_InventoryStatus.RowHeadersWidth = 51;
            dataGridView_InventoryStatus.Size = new Size(800, 450);
            dataGridView_InventoryStatus.TabIndex = 0;
            // 
            // InventoryStatusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_InventoryStatus);
            Name = "InventoryStatusForm";
            Text = "InventoryStatusForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_InventoryStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_InventoryStatus;
    }
}