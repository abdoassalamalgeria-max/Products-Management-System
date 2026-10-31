namespace Products_Management.PL
{
    partial class FRM_CUSTOMERS_LIST
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
            DgvGetAllCust = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvGetAllCust).BeginInit();
            SuspendLayout();
            // 
            // DgvGetAllCust
            // 
            DgvGetAllCust.AllowUserToAddRows = false;
            DgvGetAllCust.AllowUserToDeleteRows = false;
            DgvGetAllCust.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvGetAllCust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvGetAllCust.Dock = DockStyle.Fill;
            DgvGetAllCust.Location = new Point(0, 0);
            DgvGetAllCust.Name = "DgvGetAllCust";
            DgvGetAllCust.ReadOnly = true;
            DgvGetAllCust.RightToLeft = RightToLeft.Yes;
            DgvGetAllCust.RowHeadersWidth = 51;
            DgvGetAllCust.RowTemplate.Height = 29;
            DgvGetAllCust.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvGetAllCust.Size = new Size(800, 450);
            DgvGetAllCust.TabIndex = 0;
            DgvGetAllCust.Click += DgGetAllCustomers_Click;
            // 
            // FRM_CUSTOMERS_LIST
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvGetAllCust);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_CUSTOMERS_LIST";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة جميع العملاء";
            Load += FRM_CUSTOMERS_LIST_Load;
            ((System.ComponentModel.ISupportInitialize)DgvGetAllCust).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView DgvGetAllCust;
    }
}