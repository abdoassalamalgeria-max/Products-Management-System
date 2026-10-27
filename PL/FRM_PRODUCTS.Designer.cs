namespace Products_Management.PL
{
    partial class FRM_PRODUCTS
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
            label1 = new Label();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 19);
            label1.Name = "label1";
            label1.Size = new Size(246, 20);
            label1.TabIndex = 0;
            label1.Text = "البحث بإدخال الكلمة المراد البحث عنها:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(393, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(289, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(895, 328);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "قائمة المنتوجات";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(873, 296);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 394);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(895, 111);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "العمليات المتاحة";
            // 
            // button8
            // 
            button8.Location = new Point(428, 68);
            button8.Name = "button8";
            button8.Size = new Size(212, 29);
            button8.TabIndex = 7;
            button8.Text = "حفظ اللائحة في ملف إكسال";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(304, 68);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 6;
            button7.Text = "الخروج";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(23, 26);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "طباعة كل المنتوجات";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(145, 26);
            button5.Name = "button5";
            button5.Size = new Size(111, 29);
            button5.TabIndex = 4;
            button5.Text = "طباعة المنتوج المحدد";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(272, 26);
            button4.Name = "button4";
            button4.Size = new Size(109, 29);
            button4.TabIndex = 3;
            button4.Text = "صورة المنتوج";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(422, 26);
            button3.Name = "button3";
            button3.Size = new Size(146, 29);
            button3.TabIndex = 2;
            button3.Text = "تعديل بيانات المنتوج";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(574, 26);
            button2.Name = "button2";
            button2.Size = new Size(146, 29);
            button2.TabIndex = 1;
            button2.Text = "حذف المنتوج المحدد";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(741, 26);
            button1.Name = "button1";
            button1.Size = new Size(124, 29);
            button1.TabIndex = 0;
            button1.Text = "إضافة منتوج";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FRM_PRODUCTS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 517);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "FRM_PRODUCTS";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نافذة ادارة المنتوجات";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button8;
        private Button button7;
        public DataGridView dataGridView1;
    }
}