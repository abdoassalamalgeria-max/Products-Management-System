using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Products_Management.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public string state = "add";

        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            cmbCategories.DataSource = prd.Get_ALL_Categories();
            cmbCategories.DisplayMember = "DESCRIPTION_CAT"; //العنصر الذي نريده أن يظهر في الكومبوبوكس
            cmbCategories.ValueMember = "ID_CAT";  //قيمة الحقل الرئسي
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.JPG; *.JPEG; *.PNG; *.BMP; *.GIF"; //لتحديد انواع الصور المسموح بها
            if (ofd.ShowDialog() == DialogResult.OK) // اذا اختار الملف وضغط على اوكي
            {
                pbox.Image = Image.FromFile(ofd.FileName);
                //لا ننسى أن نغير خاصية السايز مود في البيكتشاربوكس لتظهر كامل الصورة
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                if (cmbCategories.SelectedValue == null)
                {
                    MessageBox.Show("الرجاء اختيار تصنيف أولاً");
                    return;
                }

                if (!int.TryParse(txtQnt.Text, out int qnt) || qnt < 0)
                {
                    MessageBox.Show("الرجاء إدخال كمية صحيحة");
                    return;
                }

                byte[] byteImage = null;
                if (pbox.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        pbox.Image.Save(ms, pbox.Image.RawFormat);
                        byteImage = ms.ToArray();
                    }
                }

                int idCat = Convert.ToInt32(cmbCategories.SelectedValue);

                try
                {
                    prd.ADD_PRODUCT(idCat, txtRef.Text, txtDes.Text, qnt, txtPrice.Text, byteImage);
                    MessageBox.Show("تمت إضافة المنتج", "تمت العملية بنجاح",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("هناك خطأ، يرجى إعادة التحقق من إدخال منتوج صحيح");
                }
            }
            else
            {
                if (cmbCategories.SelectedValue == null)
                {
                    MessageBox.Show("الرجاء اختيار تصنيف أولاً");
                    return;
                }

                if (!int.TryParse(txtQnt.Text, out int qnt) || qnt < 0)
                {
                    MessageBox.Show("الرجاء إدخال كمية صحيحة");
                    return;
                }

                byte[] byteImage = null;
                if (pbox.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        pbox.Image.Save(ms, pbox.Image.RawFormat);
                        byteImage = ms.ToArray();
                    }
                }

                int idCat = Convert.ToInt32(cmbCategories.SelectedValue);

                try
                {
                    prd.UPDATE_PRODUCT(idCat, txtRef.Text, txtDes.Text, qnt, txtPrice.Text, byteImage);
                    MessageBox.Show("تم تحديث المنتج", "تمت العملية بنجاح",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("هناك خطأ، يرجى إعادة التحقق من إدخال المنتوج صحيح");
                }
            }
            FRM_PRODUCTS.getMainForm.dataGridView1.DataSource = prd.Get_ALL_PRODUCTS();

        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            if(state == "add")
            {
                DataTable dt = new DataTable();
                if (dt.Rows.Count > 0)
                {
                    dt = prd.VerifyIdProduct(Convert.ToInt32(txtRef.Text));
                    MessageBox.Show("هذا المعرف موجود مسبقا");
                    txtRef.Focus();
                }
                //لجعل مؤشر الكتابة على هذا الحقل
                txtRef.SelectionStart = 0;  //لجعل النص المكتوب في وضع التحديد
                txtRef.SelectionLength = txtRef.TextLength;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
