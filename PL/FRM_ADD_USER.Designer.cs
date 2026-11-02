namespace Products_Management.PL
{
    partial class FRM_ADD_USER
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
            cmbType = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtPWDConfirm = new TextBox();
            label3 = new Label();
            txtPWD = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbType);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPWDConfirm);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPWD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtID);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المستخدم";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Adminstrator", "User" });
            cmbType.Location = new Point(40, 217);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(245, 28);
            cmbType.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(290, 217);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 9;
            label5.Text = "صنف المستخدم";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(297, 169);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 7;
            label4.Text = "تأكيد كلمة السر";
            // 
            // txtPWDConfirm
            // 
            txtPWDConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPWDConfirm.Location = new Point(40, 169);
            txtPWDConfirm.Name = "txtPWDConfirm";
            txtPWDConfirm.PasswordChar = '*';
            txtPWDConfirm.Size = new Size(245, 27);
            txtPWDConfirm.TabIndex = 3;
            txtPWDConfirm.Validated += txtPWDConfirm_Validated;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(331, 123);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "كلمة السر";
            label3.Click += label3_Click;
            // 
            // txtPWD
            // 
            txtPWD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPWD.Location = new Point(40, 123);
            txtPWD.Name = "txtPWD";
            txtPWD.PasswordChar = '*';
            txtPWD.Size = new Size(245, 27);
            txtPWD.TabIndex = 2;
            txtPWD.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(312, 78);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 3;
            label2.Text = "الاسم الكامل";
            label2.Click += label2_Click;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtFullName.Location = new Point(40, 78);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(245, 27);
            txtFullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(299, 39);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 1;
            label1.Text = "اسم المستخدم";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtID.Location = new Point(40, 39);
            txtID.Name = "txtID";
            txtID.Size = new Size(245, 27);
            txtID.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(93, 333);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "حفظ المستخدم";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(299, 333);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "خروج";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FRM_ADD_USER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 396);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_ADD_USER";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtID;
        private Label label3;
        private TextBox txtPWD;
        private Label label2;
        private TextBox txtFullName;
        private Label label1;
        private ComboBox cmbType;
        private Label label5;
        private Label label4;
        private TextBox txtPWDConfirm;
        private Button button1;
        private Button button2;
    }
}