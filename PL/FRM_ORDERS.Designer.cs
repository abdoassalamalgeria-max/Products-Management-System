namespace Products_Management.PL
{
    partial class FRM_ORDERS
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
            btnClose = new Button();
            btnPrint = new Button();
            btnSave = new Button();
            btnNEw = new Button();
            btnSelectLine = new Button();
            label1 = new Label();
            txtToal = new TextBox();
            dgvProducts = new DataGridView();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            label18 = new Label();
            txtProductTotal = new TextBox();
            txtProductTax = new TextBox();
            txtProductMoney = new TextBox();
            txtProductQte = new TextBox();
            txtProductPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox2 = new GroupBox();
            txtSalesMan = new TextBox();
            label7 = new Label();
            txtDate = new TextBox();
            label8 = new Label();
            txtDesc = new TextBox();
            label9 = new Label();
            txtOrderID = new TextBox();
            label10 = new Label();
            groupBox3 = new GroupBox();
            button6 = new Button();
            pbCust = new PictureBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtTel = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCust).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(724, 572);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 30);
            btnClose.TabIndex = 5;
            btnClose.Text = "خروج";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // btnPrint
            // 
            btnPrint.Enabled = false;
            btnPrint.Location = new Point(584, 572);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(108, 30);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "طباعة الفاتورة";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(435, 572);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 30);
            btnSave.TabIndex = 3;
            btnSave.Text = "حفظ البيعة";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNEw
            // 
            btnNEw.Location = new Point(273, 572);
            btnNEw.Margin = new Padding(3, 4, 3, 4);
            btnNEw.Name = "btnNEw";
            btnNEw.Size = new Size(127, 30);
            btnNEw.TabIndex = 2;
            btnNEw.Text = "البيعة الجديدة";
            btnNEw.UseVisualStyleBackColor = true;
            btnNEw.Click += button4_Click;
            // 
            // btnSelectLine
            // 
            btnSelectLine.Enabled = false;
            btnSelectLine.Location = new Point(17, 525);
            btnSelectLine.Margin = new Padding(3, 4, 3, 4);
            btnSelectLine.Name = "btnSelectLine";
            btnSelectLine.Size = new Size(241, 30);
            btnSelectLine.TabIndex = 0;
            btnSelectLine.Text = "جذف السطر المحدد";
            btnSelectLine.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(775, 523);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 5;
            label1.Text = "المجموع";
            // 
            // txtToal
            // 
            txtToal.Location = new Point(853, 523);
            txtToal.Margin = new Padding(3, 4, 3, 4);
            txtToal.Name = "txtToal";
            txtToal.ReadOnly = true;
            txtToal.Size = new Size(218, 28);
            txtToal.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ColumnHeadersVisible = false;
            dgvProducts.Location = new Point(9, 89);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1033, 166);
            dgvProducts.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(txtProductTotal);
            groupBox1.Controls.Add(txtProductTax);
            groupBox1.Controls.Add(txtProductMoney);
            groupBox1.Controls.Add(txtProductQte);
            groupBox1.Controls.Add(txtProductPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(dgvProducts);
            groupBox1.Location = new Point(17, 253);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1052, 262);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "المبيعات";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(975, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(66, 29);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "...";
            btnSearch.TextAlign = ContentAlignment.TopCenter;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label18
            // 
            label18.BackColor = SystemColors.ControlLight;
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Location = new Point(975, 25);
            label18.Name = "label18";
            label18.Size = new Size(67, 30);
            label18.TabIndex = 22;
            label18.Text = "بحث";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProductTotal
            // 
            txtProductTotal.Location = new Point(12, 59);
            txtProductTotal.Margin = new Padding(3, 4, 3, 4);
            txtProductTotal.Name = "txtProductTotal";
            txtProductTotal.Size = new Size(131, 28);
            txtProductTotal.TabIndex = 21;
            // 
            // txtProductTax
            // 
            txtProductTax.Location = new Point(149, 59);
            txtProductTax.Margin = new Padding(3, 4, 3, 4);
            txtProductTax.Name = "txtProductTax";
            txtProductTax.Size = new Size(131, 28);
            txtProductTax.TabIndex = 20;
            // 
            // txtProductMoney
            // 
            txtProductMoney.Location = new Point(290, 59);
            txtProductMoney.Margin = new Padding(3, 4, 3, 4);
            txtProductMoney.Name = "txtProductMoney";
            txtProductMoney.Size = new Size(131, 28);
            txtProductMoney.TabIndex = 19;
            // 
            // txtProductQte
            // 
            txtProductQte.Location = new Point(427, 59);
            txtProductQte.Margin = new Padding(3, 4, 3, 4);
            txtProductQte.Name = "txtProductQte";
            txtProductQte.Size = new Size(131, 28);
            txtProductQte.TabIndex = 18;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(564, 59);
            txtProductPrice.Margin = new Padding(3, 4, 3, 4);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(96, 28);
            txtProductPrice.TabIndex = 17;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(669, 59);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(183, 28);
            txtProductName.TabIndex = 16;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(858, 59);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(111, 28);
            txtProductID.TabIndex = 15;
            // 
            // label17
            // 
            label17.BackColor = SystemColors.ControlLight;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Location = new Point(12, 25);
            label17.Name = "label17";
            label17.Size = new Size(131, 30);
            label17.TabIndex = 14;
            label17.Text = "المبلغ الاجمالي";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.ControlLight;
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Location = new Point(149, 25);
            label16.Name = "label16";
            label16.Size = new Size(131, 30);
            label16.TabIndex = 13;
            label16.Text = "الخصم %";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.ControlLight;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Location = new Point(290, 25);
            label15.Name = "label15";
            label15.Size = new Size(131, 30);
            label15.TabIndex = 12;
            label15.Text = "المبلغ";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.BackColor = SystemColors.ControlLight;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Location = new Point(427, 25);
            label14.Name = "label14";
            label14.Size = new Size(131, 30);
            label14.TabIndex = 11;
            label14.Text = "الكمية";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = SystemColors.ControlLight;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Location = new Point(564, 25);
            label13.Name = "label13";
            label13.Size = new Size(96, 30);
            label13.TabIndex = 10;
            label13.Text = "الثمن";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.ControlLight;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Location = new Point(669, 25);
            label12.Name = "label12";
            label12.Size = new Size(183, 30);
            label12.TabIndex = 9;
            label12.Text = "اسم المنتج";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.ControlLight;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Location = new Point(858, 25);
            label11.Name = "label11";
            label11.Size = new Size(111, 30);
            label11.TabIndex = 8;
            label11.Text = "معرف المنتج";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSalesMan);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtDate);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtDesc);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtOrderID);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(17, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(461, 240);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "بيانات الفاتورة";
            // 
            // txtSalesMan
            // 
            txtSalesMan.Location = new Point(38, 198);
            txtSalesMan.Margin = new Padding(3, 4, 3, 4);
            txtSalesMan.Name = "txtSalesMan";
            txtSalesMan.ReadOnly = true;
            txtSalesMan.Size = new Size(286, 28);
            txtSalesMan.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 198);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 21;
            label7.Text = "اسم البائع";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(38, 163);
            txtDate.Margin = new Padding(3, 4, 3, 4);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(286, 28);
            txtDate.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 163);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 19;
            label8.Text = "تاريخ البيع";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(38, 68);
            txtDesc.Margin = new Padding(3, 4, 3, 4);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ScrollBars = ScrollBars.Vertical;
            txtDesc.Size = new Size(286, 89);
            txtDesc.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(335, 68);
            label9.Name = "label9";
            label9.Size = new Size(100, 21);
            label9.TabIndex = 17;
            label9.Text = "وصف الفاتورة";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(38, 33);
            txtOrderID.Margin = new Padding(3, 4, 3, 4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(286, 28);
            txtOrderID.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(345, 33);
            label10.Name = "label10";
            label10.Size = new Size(90, 21);
            label10.TabIndex = 15;
            label10.Text = "رقم الفاتورة";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(pbCust);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtTel);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtLastName);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtFirstName);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtID);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(485, 16);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(586, 240);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "بيانات العميل";
            // 
            // button6
            // 
            button6.Location = new Point(210, 29);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(87, 30);
            button6.TabIndex = 1;
            button6.Text = ".  .  .";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pbCust
            // 
            pbCust.BackColor = SystemColors.ActiveCaption;
            pbCust.Location = new Point(11, 28);
            pbCust.Margin = new Padding(3, 4, 3, 4);
            pbCust.Name = "pbCust";
            pbCust.Size = new Size(187, 201);
            pbCust.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCust.TabIndex = 17;
            pbCust.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(210, 202);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(219, 28);
            txtEmail.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(438, 204);
            label6.Name = "label6";
            label6.Size = new Size(121, 21);
            label6.TabIndex = 15;
            label6.Text = "البريد الالكتروني";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(210, 159);
            txtTel.Margin = new Padding(3, 4, 3, 4);
            txtTel.Name = "txtTel";
            txtTel.ReadOnly = true;
            txtTel.Size = new Size(219, 28);
            txtTel.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(476, 164);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 13;
            label5.Text = "رقم الهاتف";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(210, 117);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(219, 28);
            txtLastName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 119);
            label4.Name = "label4";
            label4.Size = new Size(108, 21);
            label4.TabIndex = 11;
            label4.Text = "الاسم العائلي";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(210, 72);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(219, 28);
            txtFirstName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 75);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 9;
            label3.Text = "الاسم الشخصي";
            // 
            // txtID
            // 
            txtID.Location = new Point(304, 29);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(126, 28);
            txtID.TabIndex = 0;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 31);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 7;
            label2.Text = "معرف العميل";
            // 
            // FRM_ORDERS
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 620);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtToal);
            Controls.Add(label1);
            Controls.Add(btnSelectLine);
            Controls.Add(btnNEw);
            Controls.Add(btnSave);
            Controls.Add(btnPrint);
            Controls.Add(btnClose);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_ORDERS";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الشاشة الرئيسية لعملية البيع";
            Load += FRM_ORDERS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCust).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnPrint;
        private Button btnSave;
        private Button btnNEw;
        private Button btnSelectLine;
        private Label label1;
        private TextBox txtToal;
        private DataGridView dgvProducts;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSalesMan;
        private Label label7;
        private TextBox txtDate;
        private Label label8;
        private TextBox txtDesc;
        private Label label9;
        private TextBox txtOrderID;
        private Label label10;
        private Button button6;
        public PictureBox pbCust;
        public TextBox txtEmail;
        public TextBox txtTel;
        public TextBox txtLastName;
        public TextBox txtFirstName;
        public TextBox txtID;
        private TextBox txtProductTotal;
        private TextBox txtProductTax;
        private TextBox txtProductMoney;
        private TextBox txtProductQte;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label18;
        private Button btnSearch;
    }
}