using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        PL.FRM_CUSTOMERS_LIST frm = new PL.FRM_CUSTOMERS_LIST();
        DataTable dt = new DataTable();

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
            btnSelectLine.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
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
            CreateDatatable();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
