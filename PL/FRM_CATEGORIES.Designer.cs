namespace Products_Management.PL
{
    partial class FRM_CATEGORIES
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
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtDes = new TextBox();
            btnFirst = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnLast = new Button();
            lblposition = new Label();
            groupBox2 = new GroupBox();
            btnNew = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dgList = new DataGridView();
            button13 = new Button();
            btnClose = new Button();
            btnPrintAll = new Button();
            exportToPdfCurrent = new Button();
            exportToPdfAll = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgList);
            groupBox1.Controls.Add(lblposition);
            groupBox1.Controls.Add(btnLast);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnFirst);
            groupBox1.Controls.Add(btnPrevious);
            groupBox1.Controls.Add(txtDes);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 236);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيانات الصنف";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(668, 22);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "معرف الصنف";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(668, 75);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "وصف الصنف";
            // 
            // txtID
            // 
            txtID.Location = new Point(413, 22);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(240, 27);
            txtID.TabIndex = 2;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(413, 75);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.ScrollBars = ScrollBars.Vertical;
            txtDes.Size = new Size(240, 88);
            txtDes.TabIndex = 3;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(697, 198);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(66, 29);
            btnFirst.TabIndex = 4;
            btnFirst.Text = "||<<";
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(621, 198);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(70, 29);
            btnNext.TabIndex = 5;
            btnNext.Text = "<<";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(480, 198);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(63, 29);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = ">>";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(413, 198);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(61, 29);
            btnLast.TabIndex = 7;
            btnLast.Text = ">>||";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // lblposition
            // 
            lblposition.AutoSize = true;
            lblposition.Location = new Point(564, 202);
            lblposition.Name = "lblposition";
            lblposition.Size = new Size(26, 20);
            lblposition.TabIndex = 9;
            lblposition.Text = "lbl";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(exportToPdfAll);
            groupBox2.Controls.Add(exportToPdfCurrent);
            groupBox2.Controls.Add(btnPrintAll);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(button13);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnNew);
            groupBox2.Location = new Point(12, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 115);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "العمليات المتاحة";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(613, 26);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 0;
            btnNew.Text = "جديد";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(488, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "إضافة";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(363, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(238, 26);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "تعديل";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Location = new Point(6, 22);
            dgList.Name = "dgList";
            dgList.RowHeadersWidth = 51;
            dgList.RowTemplate.Height = 29;
            dgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgList.Size = new Size(371, 200);
            dgList.TabIndex = 0;
            // 
            // button13
            // 
            button13.Location = new Point(49, 26);
            button13.Name = "button13";
            button13.Size = new Size(151, 29);
            button13.TabIndex = 4;
            button13.Text = "طباعة الصنف المحدد";
            button13.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(29, 69);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "خروج";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button14_Click;
            // 
            // btnPrintAll
            // 
            btnPrintAll.Location = new Point(613, 69);
            btnPrintAll.Name = "btnPrintAll";
            btnPrintAll.Size = new Size(151, 29);
            btnPrintAll.TabIndex = 6;
            btnPrintAll.Text = "طباعة كل الاصناف";
            btnPrintAll.UseVisualStyleBackColor = true;
            // 
            // exportToPdfCurrent
            // 
            exportToPdfCurrent.Location = new Point(399, 69);
            exportToPdfCurrent.Name = "exportToPdfCurrent";
            exportToPdfCurrent.Size = new Size(208, 29);
            exportToPdfCurrent.TabIndex = 7;
            exportToPdfCurrent.Text = "حفظ صنف محدد في PDF";
            exportToPdfCurrent.UseVisualStyleBackColor = true;
            // 
            // exportToPdfAll
            // 
            exportToPdfAll.Location = new Point(156, 69);
            exportToPdfAll.Name = "exportToPdfAll";
            exportToPdfAll.Size = new Size(208, 29);
            exportToPdfAll.TabIndex = 8;
            exportToPdfAll.Text = "حفظ كل الاصناف في PDF";
            exportToPdfAll.UseVisualStyleBackColor = true;
            // 
            // FRM_CATEGORIES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 385);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_CATEGORIES";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدراة الأصناف";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDes;
        private TextBox txtID;
        private Label label2;
        private Label label1;
        private Label lblposition;
        private Button btnLast;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnFirst;
        private GroupBox groupBox2;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnNew;
        private DataGridView dgList;
        private Button btnClose;
        private Button button13;
        private Button btnPrintAll;
        private Button exportToPdfAll;
        private Button exportToPdfCurrent;
    }
}