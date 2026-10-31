using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Products_Management.PL
{
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        DataTable dt = new DataTable();

        void CalculateAmount()
        {
            if (txtProductPrice.Text != string.Empty && txtProductPrice.Text != string.Empty)
            {
                double Amount = Convert.ToDouble(txtProductPrice.Text) * Convert.ToDouble(txtProductQte.Text);
                txtProductMoney.Text = Convert.ToString(Amount);
            }
        }
        void CalculateTotal()
        {
            if (txtProductMoney.Text != string.Empty && txtProductTax.Text != string.Empty)
            {
                double Total = Convert.ToDouble(txtProductMoney.Text) * Convert.ToDouble(txtProductTax.Text);
                txtProductTotal.Text = Convert.ToString(Total);
            }
        }

        void CreateDatatable()
        {
            dt.Columns.Add("معرف المنتوج");
            dt.Columns.Add("اسم المنتوج");
            dt.Columns.Add("ثمن منتج واحد");
            dt.Columns.Add("كمية المنتوج");
            dt.Columns.Add("مبلغ كل المنتجات");
            dt.Columns.Add("نسبة الخصم % ");
            dt.Columns.Add("المبلغ الاجمالي");

            this.dgvProducts.DataSource = dt;

            //add button to datagridview
            /* DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "اختيار منتج";
            btn.Text = "البحث";
            btn.UseColumnTextForButtonValue = true;
            this.dgvProducts.Columns.Insert(0, btn); */


        }

        void ResizeDGV()
        {
            this.dgvProducts.RowHeadersWidth = 67;
            this.dgvProducts.Columns[0].Width = 111;
            this.dgvProducts.Columns[1].Width = 183;
            this.dgvProducts.Columns[2].Width = 96;
            this.dgvProducts.Columns[3].Width = 131;
            this.dgvProducts.Columns[4].Width = 131;
            this.dgvProducts.Columns[5].Width = 131;
            this.dgvProducts.Columns[6].Width = 131;
        }

        void ClearBoxes()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtProductPrice.Clear();
            txtProductQte.Clear();
            txtProductPrice.Clear();
            txtProductTax.Clear();
            txtProductTotal.Clear();
            btnSearch.Focus();
        }
        public FRM_ORDERS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                this.txtOrderID.Text = order.GET_LAST_ORDER_ID().Rows[0][0].ToString();
                btnNEw.Enabled = false;
                btnSave.Enabled = true;
                btnDeleteAll.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PL.FRM_CUSTOMERS_LIST frm = new PL.FRM_CUSTOMERS_LIST();
            frm.ShowDialog();
            if (frm.DgvGetAllCust.CurrentRow.Cells[5].Value is DBNull)
            {
                this.txtID.Text = frm.DgvGetAllCust.CurrentRow.Cells[0].Value.ToString();
                this.txtFirstName.Text = frm.DgvGetAllCust.CurrentRow.Cells[1].Value.ToString();
                this.txtLastName.Text = frm.DgvGetAllCust.CurrentRow.Cells[2].Value.ToString();
                this.txtTel.Text = frm.DgvGetAllCust.CurrentRow.Cells[3].Value.ToString();
                this.txtEmail.Text = frm.DgvGetAllCust.CurrentRow.Cells[4].Value.ToString();
                return;
            }
            this.txtID.Text = frm.DgvGetAllCust.CurrentRow.Cells[0].Value.ToString();
            this.txtFirstName.Text = frm.DgvGetAllCust.CurrentRow.Cells[1].Value.ToString();
            this.txtLastName.Text = frm.DgvGetAllCust.CurrentRow.Cells[2].Value.ToString();
            this.txtTel.Text = frm.DgvGetAllCust.CurrentRow.Cells[3].Value.ToString();
            this.txtEmail.Text = frm.DgvGetAllCust.CurrentRow.Cells[4].Value.ToString();
            byte[] custPicture = (byte[])frm.DgvGetAllCust.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(custPicture);
            this.pbCust.Image = Image.FromStream(ms);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {
            txtSalesMan.Text = Program.SalesMan;
            txtDateOrder.Text = DateTime.Now.ToString("yyyy/MM/dd");
            CreateDatatable();
            ResizeDGV();
            btnSelectClient.Focus();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearBoxes();

            PL.FRM_PRODUCTS_LIST frm = new PL.FRM_PRODUCTS_LIST();
            frm.ShowDialog();

            this.txtProductID.Text = frm.dgvProductList.CurrentRow.Cells[0].Value.ToString();
            this.txtProductName.Text = frm.dgvProductList.CurrentRow.Cells[1].Value.ToString();
            this.txtProductPrice.Text = frm.dgvProductList.CurrentRow.Cells[3].Value.ToString();
            this.txtProductQte.Focus();
        }

        private void txtProductQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txtProductTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtProductPrice.Text != string.Empty)
            {
                txtProductQte.Focus();
                txtProductQte.SelectAll();
            }
        }

        private void txtProductQte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtProductQte.Text != string.Empty)
            {
                txtProductTax.Focus();
                txtProductTax.SelectAll();
            }
        }

        private void txtProductQte_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void txtProductTax_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotal();
        }

        private void txtProductTotal_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtProductTax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
                {
                    if (dgvProducts.Rows[i].Cells[0].Value.ToString() == txtProductID.Text)
                    {
                        MessageBox.Show("هذا المنتج موجود", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                DataRow dr = dt.NewRow();
                dr[0] = txtProductID.Text;
                dr[1] = txtProductName.Text;
                dr[2] = txtProductPrice.Text;
                dr[3] = txtProductQte.Text;
                dr[4] = txtProductPrice.Text;
                dr[5] = txtProductTax.Text;
                dr[6] = txtProductTotal.Text;

                dt.Rows.Add(dr);

                dgvProducts.DataSource = dt;

                ClearBoxes();

                btnSearch.Focus();

                //هذه طريقة لينك في العمل
                /*
                 شرحها: فروم أنشأنا راو من داتا غريد وإين معناه يمثل كل الروات في الديجيفيبروداكت
                واار حيث تكون الخانة السادسة من الورات لا تكون فارغة
                سيلاكت فقم بتحديد الخانات السادسة وأجمعها كلها صام
                 */
                txtSumToals.Text =
                    (from DataGridViewRow row in dgvProducts.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtProductID.Text = this.dgvProducts.CurrentRow.Cells[0].Value.ToString();
                txtProductName.Text = this.dgvProducts.CurrentRow.Cells[1].Value.ToString();
                txtProductPrice.Text = this.dgvProducts.CurrentRow.Cells[2].Value.ToString();
                txtProductQte.Text = this.dgvProducts.CurrentRow.Cells[3].Value.ToString();
                txtProductPrice.Text = this.dgvProducts.CurrentRow.Cells[4].Value.ToString();
                txtProductTax.Text = this.dgvProducts.CurrentRow.Cells[5].Value.ToString();
                txtProductTotal.Text = this.dgvProducts.CurrentRow.Cells[6].Value.ToString();

                dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
                txtProductQte.Focus();
            }
            catch
            {
                return;
            }

        }

        private void dgvProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtSumToals.Text =
                  (from DataGridViewRow row in dgvProducts.Rows
                   where row.Cells[6].FormattedValue.ToString() != string.Empty
                   select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgvProducts_DoubleClick(sender, e);
        }

        private void btnDeleteCurrent_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dgvProducts.Refresh();
            btnSearch.Focus();
        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvProducts_DoubleClick(sender, e);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dgvProducts.Refresh();
            btnSearch.Focus();
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProducts_DoubleClick(sender, e);
        }

        private void حذفالسطرالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
            {
                dgvProducts.Rows.RemoveAt(dgvProducts.Rows[i].Index);
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //اضافة معلومات الفاتورة
            order.ADD_ORDER(Convert.ToInt32(txtOrderID.Text), Convert.ToDateTime(txtDateOrder.Text), Convert.ToInt32(txtID.Text), txtDescOrder.Text, txtSalesMan.Text); ;

            //اضافة المنتجات المدخلة
            MessageBox.Show("تمت عملية الحفظ بنجاح", "رسالة حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for(int i = 0; i < dgvProducts.Rows.Count-1; i++)
            {
                order.ADD_ORDER_DETAILS(
                    Convert.ToInt32(dgvProducts.Rows[i].Cells[0].Value),
                    Convert.ToInt32(txtOrderID.Text),
                    Convert.ToInt32(dgvProducts.Rows[i].Cells[3].Value),
                    dgvProducts.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToInt32(dgvProducts.Rows[i].Cells[5].Value),
                    dgvProducts.Rows[i].Cells[4].Value.ToString(),
                    dgvProducts.Rows[i].Cells[6].Value.ToString());
            }

            btnSave.Enabled = false;
            btnNEw.Enabled = true;

        }
    }
}