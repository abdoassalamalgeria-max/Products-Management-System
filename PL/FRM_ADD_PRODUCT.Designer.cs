namespace Products_Management.PL
{
    partial class FRM_ADD_PRODUCT
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
            groupBox1 = new GroupBox();
            cmbCategories = new ComboBox();
            btnCancel = new Button();
            btnOk = new Button();
            btnImage = new Button();
            pbox = new PictureBox();
            label6 = new Label();
            txtPrice = new TextBox();
            txtQnt = new TextBox();
            txtDes = new TextBox();
            txtRef = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbCategories);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnOk);
            groupBox1.Controls.Add(btnImage);
            groupBox1.Controls.Add(pbox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtQnt);
            groupBox1.Controls.Add(txtDes);
            groupBox1.Controls.Add(txtRef);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 605);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(29, 29);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(267, 28);
            cmbCategories.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(29, 553);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(148, 553);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 13;
            btnOk.Text = "موافق";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(29, 501);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(267, 29);
            btnImage.TabIndex = 4;
            btnImage.Text = "تحديد ملف الصورة";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += button1_Click;
            // 
            // pbox
            // 
            pbox.Image = Properties.Resources.pexels_zett_foto_194587_672142;
            pbox.Location = new Point(29, 328);
            pbox.Name = "pbox";
            pbox.Size = new Size(267, 157);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.TabIndex = 11;
            pbox.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 328);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 10;
            label6.Text = "صورة المنتوج";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(29, 275);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(267, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtQnt
            // 
            txtQnt.Location = new Point(29, 222);
            txtQnt.Name = "txtQnt";
            txtQnt.Size = new Size(267, 27);
            txtQnt.TabIndex = 2;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(29, 127);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.ScrollBars = ScrollBars.Vertical;
            txtDes.Size = new Size(267, 74);
            txtDes.TabIndex = 1;
            // 
            // txtRef
            // 
            txtRef.Location = new Point(29, 77);
            txtRef.Name = "txtRef";
            txtRef.Size = new Size(267, 27);
            txtRef.TabIndex = 0;
            txtRef.Validated += txtRef_Validated;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 275);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "ثمن المنتوج";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 222);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "الكمية المخزنة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 127);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "وصف المنتوج";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 77);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "معرف المنتوج";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 29);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "صنف المنتوج";
            // 
            // FRM_ADD_PRODUCT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 629);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FRM_ADD_PRODUCT";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إضافة منتوج جديد";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button btnCancel;
        public TextBox txtPrice;
        public TextBox txtQnt;
        public TextBox txtDes;
        public TextBox txtRef;
        public Button btnImage;
        public PictureBox pbox;
        public Button btnOk;
        public ComboBox cmbCategories;
    }
}