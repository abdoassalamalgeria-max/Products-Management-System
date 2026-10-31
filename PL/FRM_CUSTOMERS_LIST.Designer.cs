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
            DgGetAllCust = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgGetAllCust).BeginInit();
            SuspendLayout();
            // 
            // DgGetAllCust
            // 
            DgGetAllCust.AllowUserToAddRows = false;
            DgGetAllCust.AllowUserToDeleteRows = false;
            DgGetAllCust.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgGetAllCust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgGetAllCust.Dock = DockStyle.Fill;
            DgGetAllCust.Location = new Point(0, 0);
            DgGetAllCust.Name = "DgGetAllCust";
            DgGetAllCust.ReadOnly = true;
            DgGetAllCust.RightToLeft = RightToLeft.Yes;
            DgGetAllCust.RowHeadersWidth = 51;
            DgGetAllCust.RowTemplate.Height = 29;
            DgGetAllCust.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgGetAllCust.Size = new Size(800, 450);
            DgGetAllCust.TabIndex = 0;
            DgGetAllCust.Click += DgGetAllCustomers_Click;
            // 
            // FRM_CUSTOMERS_LIST
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgGetAllCust);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_CUSTOMERS_LIST";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة جميع العملاء";
            Load += FRM_CUSTOMERS_LIST_Load;
            ((System.ComponentModel.ISupportInitialize)DgGetAllCust).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView DgGetAllCust;
    }
}