namespace Products_Management.PL
{
    partial class FRM_PREVIEW
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
            pboxPreview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxPreview).BeginInit();
            SuspendLayout();
            // 
            // pboxPreview
            // 
            pboxPreview.Location = new Point(12, 12);
            pboxPreview.Name = "pboxPreview";
            pboxPreview.Size = new Size(776, 426);
            pboxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxPreview.TabIndex = 0;
            pboxPreview.TabStop = false;
            // 
            // FRM_PREVIEW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pboxPreview);
            Name = "FRM_PREVIEW";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صورة المنتوج";
            ((System.ComponentModel.ISupportInitialize)pboxPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pboxPreview;
    }
}