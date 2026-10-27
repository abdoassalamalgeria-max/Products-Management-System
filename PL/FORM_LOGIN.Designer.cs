namespace Products_Management.PL
{
    partial class FORM_LOGIN
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
            btnEnter = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtPWD = new TextBox();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(130, 240);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(94, 29);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "الدخول";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(301, 240);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 61);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 2;
            label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 147);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "كلمة المرور";
            // 
            // txtID
            // 
            txtID.Location = new Point(197, 61);
            txtID.Name = "txtID";
            txtID.Size = new Size(198, 27);
            txtID.TabIndex = 4;
            // 
            // txtPWD
            // 
            txtPWD.Location = new Point(197, 147);
            txtPWD.Name = "txtPWD";
            txtPWD.PasswordChar = '*';
            txtPWD.Size = new Size(198, 27);
            txtPWD.TabIndex = 5;
            // 
            // FORM_LOGIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 376);
            Controls.Add(txtPWD);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnEnter);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FORM_LOGIN";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtPWD;
    }
}