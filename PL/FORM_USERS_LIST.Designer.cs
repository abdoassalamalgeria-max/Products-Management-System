namespace Products_Management.PL
{
    partial class FORM_USERS_LIST
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
            button2 = new Button();
            dgvUsersList = new DataGridView();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(668, 467);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "خروج";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgvUsersList
            // 
            dgvUsersList.AllowUserToAddRows = false;
            dgvUsersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsersList.Location = new Point(6, 26);
            dgvUsersList.MultiSelect = false;
            dgvUsersList.Name = "dgvUsersList";
            dgvUsersList.RowHeadersWidth = 51;
            dgvUsersList.RowTemplate.Height = 29;
            dgvUsersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsersList.Size = new Size(795, 393);
            dgvUsersList.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvUsersList);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(807, 425);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "قائمة المستخدمين";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(388, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(291, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 11);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 5;
            label1.Text = "قم بإدخال الكلمة المراد البحث عنها";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(73, 467);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(164, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "إضافة مستخدم جديد";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(243, 467);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(175, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "تعديل المستخدم المحدد";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button3_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(424, 467);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "حذف المستخدم المحدد";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FORM_USERS_LIST
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 508);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FORM_USERS_LIST";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة المستخدمين";
            Load += FORM_USERS_LIST_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        public DataGridView dgvUsersList;
    }
}