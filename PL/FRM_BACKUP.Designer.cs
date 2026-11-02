namespace Products_Management.PL
{
    partial class FRM_BACKUP
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
            txtFileName = new TextBox();
            btnBrowse = new Button();
            btnCancel = new Button();
            btnCreate = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(232, 20);
            label1.TabIndex = 0;
            label1.Text = "الرجاء تحديد مسار النسخة الاحتياطية";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(31, 75);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(517, 27);
            txtFileName.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(567, 75);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = ". . . ";
            btnBrowse.TextAlign = ContentAlignment.TopCenter;
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(567, 149);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(359, 149);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(158, 29);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "انشاء نسخة احتياطية";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += button3_Click;
            // 
            // FRM_BACKUP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 209);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(btnBrowse);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_BACKUP";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "انشاء نسخة احتياطية";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFileName;
        private Button btnBrowse;
        private Button btnCancel;
        private Button btnCreate;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}