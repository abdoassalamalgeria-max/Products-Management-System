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
    public partial class FRM_PRODUCTS : Form
    {
        //single instance methode
        private static FRM_PRODUCTS frm;

        //create handler (event) that open when the form get opened
        //هذا الحدث يقوم بتصفير المتغير الذي انشاناه بعد تطبيقه
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null; // معناه هدم الاجراء أفأرأم
        }
        //انشاء خاصية للتحقق من قيمة الفورم فان كانت معدومة يقوم من انشائه من جديد
        public static FRM_PRODUCTS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCTS();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                    //هذا السطر يقول ببساطة: "عندما تُغلق النافذة frm، نفّذ الدالة frm_FormClosed."

                }
                return frm;
            }
        }


        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public FRM_PRODUCTS()
        {
            InitializeComponent();

            if (frm == null)
                frm = this;

            this.dataGridView1.DataSource = prd.Get_ALL_PRODUCTS();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.SearchProduct(txtSearch.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT fRM = new FRM_ADD_PRODUCT();
            fRM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المنتوج المحدد؟", "رسالة حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    prd.DeleteProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تم حذف المنتج بنجاح", "رسالة حذف منتج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = prd.Get_ALL_PRODUCTS(); // لعملية تحديث البيانات بعد نجاح عملية الحذف
                }
                catch
                {
                    MessageBox.Show("رسالة خطأ، لم يتم حذف المنتج");
                }
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_PRODUCT frm = new PL.FRM_ADD_PRODUCT();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQnt.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = ": تحديث المنتوج" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnOk.Text = " تحديث ";
            frm.txtRef.ReadOnly = true;
            frm.state = "update";

            byte[] img_array = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0]; //معناها القيمة المجلوبة من طرف الدالة غاتايميج نحولها الى مصفوفة
            MemoryStream ms = new MemoryStream(img_array);
            frm.pbox.Image = Image.FromStream(ms);
            frm.ShowDialog();
            this.dataGridView1.DataSource = prd.Get_ALL_PRODUCTS(); // لعملية تحديث البيانات بعد نجاح عملية الحذف

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PL.FRM_PREVIEW frmp = new PL.FRM_PREVIEW();

            byte[] img_array = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0]; //معناها القيمة المجلوبة من طرف الدالة غاتايميج نحولها الى مصفوفة
            MemoryStream ms = new MemoryStream(img_array);
            frmp.pboxPreview.Image = Image.FromStream(ms);

            frmp.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
