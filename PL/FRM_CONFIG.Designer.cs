namespace Products_Management.PL
{
    partial class FRM_CONFIG
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
            txtServerName = new TextBox();
            label1 = new Label();
            rbWindows = new RadioButton();
            btnSave = new Button();
            rbSql = new RadioButton();
            txtDatabase = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPWD = new TextBox();
            label4 = new Label();
            txtID = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(384, 375);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 33);
            btnClose.TabIndex = 0;
            btnClose.Text = "خروج";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // txtServerName
            // 
            txtServerName.Location = new Point(172, 37);
            txtServerName.Margin = new Padding(4, 3, 4, 3);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(328, 30);
            txtServerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 2;
            label1.Text = "اسم السيرفر";
            // 
            // rbWindows
            // 
            rbWindows.AutoSize = true;
            rbWindows.Checked = true;
            rbWindows.Location = new Point(172, 148);
            rbWindows.Margin = new Padding(4, 3, 4, 3);
            rbWindows.Name = "rbWindows";
            rbWindows.Size = new Size(229, 27);
            rbWindows.TabIndex = 3;
            rbWindows.TabStop = true;
            rbWindows.Text = "Windows Authentication";
            rbWindows.UseVisualStyleBackColor = true;
            rbWindows.CheckedChanged += rbWindows_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(172, 375);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 33);
            btnSave.TabIndex = 4;
            btnSave.Text = "حفظ الاعدادت";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rbSql
            // 
            rbSql.AutoSize = true;
            rbSql.Location = new Point(172, 197);
            rbSql.Margin = new Padding(4, 3, 4, 3);
            rbSql.Name = "rbSql";
            rbSql.Size = new Size(238, 27);
            rbSql.TabIndex = 5;
            rbSql.Text = "Sql Server Authentication";
            rbSql.UseVisualStyleBackColor = true;
            rbSql.CheckedChanged += rbSql_CheckedChanged;
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(172, 83);
            txtDatabase.Margin = new Padding(4, 3, 4, 3);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(328, 30);
            txtDatabase.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 7;
            label2.Text = "قاعدة البيانات";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 293);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 11;
            label3.Text = "كلمة المروو";
            // 
            // txtPWD
            // 
            txtPWD.Location = new Point(172, 293);
            txtPWD.Margin = new Padding(4, 3, 4, 3);
            txtPWD.Name = "txtPWD";
            txtPWD.Size = new Size(328, 30);
            txtPWD.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 148);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 9;
            label4.Text = "طريقة الدخول";
            // 
            // txtID
            // 
            txtID.Location = new Point(172, 245);
            txtID.Margin = new Padding(4, 3, 4, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(328, 30);
            txtID.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 253);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 23);
            label5.TabIndex = 12;
            label5.Text = "اسم المستخدم";
            // 
            // FRM_CONFIG
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 444);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtPWD);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(txtDatabase);
            Controls.Add(rbSql);
            Controls.Add(btnSave);
            Controls.Add(rbWindows);
            Controls.Add(label1);
            Controls.Add(txtServerName);
            Controls.Add(btnClose);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_CONFIG";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إعدادات الاتصال بالسيرفر";
            Load += FRM_CONFIG_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private TextBox txtServerName;
        private Label label1;
        private RadioButton rbWindows;
        private Button btnSave;
        private RadioButton rbSql;
        private TextBox txtDatabase;
        private Label label2;
        private Label label3;
        private TextBox txtPWD;
        private Label label4;
        private TextBox txtID;
        private Label label5;
    }
}