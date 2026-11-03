namespace Products_Management.PL
{
    partial class FRM_RESTORE
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
            btnCreate = new Button();
            btnCancel = new Button();
            btnBrowse = new Button();
            txtFileName = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(346, 141);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(202, 29);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "استعادة نسخة احتياطية";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(567, 141);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(567, 67);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 7;
            btnBrowse.Text = ". . . ";
            btnBrowse.TextAlign = ContentAlignment.TopCenter;
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(31, 67);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(517, 27);
            txtFileName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(232, 20);
            label1.TabIndex = 5;
            label1.Text = "الرجاء تحديد مسار النسخة الاحتياطية";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FRM_RESTORE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 194);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(btnBrowse);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_RESTORE";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "استعادة نسخة احتياطية";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnCancel;
        private Button btnBrowse;
        private TextBox txtFileName;
        private Label label1;
        private OpenFileDialog openFileDialog1;
    }
}