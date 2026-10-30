namespace Products_Management.PL
{
    partial class FRM_CUSTOMERS
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
            groupBox2 = new GroupBox();
            btnClose = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnNew = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            pbox = new PictureBox();
            txtEmail = new TextBox();
            txtTel = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblposition = new Label();
            btnLast = new Button();
            btnNext = new Button();
            btnFirst = new Button();
            btnPrevious = new Button();
            label2 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnNew);
            groupBox2.Location = new Point(9, 264);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(561, 74);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "العمليات المتاحة";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(39, 28);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "خروج";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(139, 28);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "تعديل";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(239, 28);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(339, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "إضافة";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(439, 28);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 0;
            btnNew.Text = "جديد";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pbox);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblposition);
            groupBox1.Controls.Add(btnLast);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnFirst);
            groupBox1.Controls.Add(btnPrevious);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(561, 249);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيانات العميل";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 23);
            label6.Name = "label6";
            label6.Size = new Size(187, 20);
            label6.TabIndex = 18;
            label6.Text = "اضغط على الصورة لاضافتها";
            // 
            // pbox
            // 
            pbox.BackColor = SystemColors.ActiveCaption;
            pbox.Cursor = Cursors.Hand;
            pbox.Location = new Point(6, 56);
            pbox.Name = "pbox";
            pbox.Size = new Size(194, 184);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.TabIndex = 17;
            pbox.TabStop = false;
            pbox.Click += pbox_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(216, 158);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 27);
            txtEmail.TabIndex = 16;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(216, 118);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(207, 27);
            txtTel.TabIndex = 15;
            txtTel.KeyDown += txtTel_KeyDown;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(216, 75);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(207, 27);
            txtLastName.TabIndex = 14;
            txtLastName.KeyDown += txtLastName_KeyDown;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(216, 33);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(207, 27);
            txtFirstName.TabIndex = 13;
            txtFirstName.KeyDown += txtFirstName_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(465, 118);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 12;
            label5.Text = "رقم الهاتف";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 75);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 11;
            label4.Text = "الاسم العائلي";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 161);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 10;
            label3.Text = "البريد الالكتروني";
            // 
            // lblposition
            // 
            lblposition.AutoSize = true;
            lblposition.Location = new Point(345, 206);
            lblposition.Name = "lblposition";
            lblposition.Size = new Size(47, 20);
            lblposition.TabIndex = 9;
            lblposition.Text = "0 / 0  ";
            // 
            // btnLast
            // 
            btnLast.Location = new Point(206, 202);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(61, 29);
            btnLast.TabIndex = 7;
            btnLast.Text = ">>||";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(405, 202);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(70, 29);
            btnNext.TabIndex = 5;
            btnNext.Text = "<<";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(481, 202);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(66, 29);
            btnFirst.TabIndex = 4;
            btnFirst.Text = "||<<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(270, 202);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(63, 29);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = ">>";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 33);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "الاسم الشخصي";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(578, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = RightToLeft.Yes;
            groupBox3.Size = new Size(537, 329);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "لائحة جميع العملاء";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 57);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(525, 254);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(6, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "موافق";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(106, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(342, 27);
            txtSearch.TabIndex = 15;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 25);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 14;
            label1.Text = "ابحث هنا:";
            // 
            // FRM_CUSTOMERS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 347);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_CUSTOMERS";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FRM_CUSTOMERS_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnClose;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnNew;
        private GroupBox groupBox1;
        private Label lblposition;
        private Button btnLast;
        private Button btnNext;
        private Button btnFirst;
        private Button btnPrevious;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtTel;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pbox;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Label label6;
    }
}