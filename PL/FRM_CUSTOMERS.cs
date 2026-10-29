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
using System.Net.Http.Headers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Threading.Tasks.Dataflow;

namespace Products_Management.PL
{
    public partial class FRM_CUSTOMERS : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        int ID;
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cust.Get_ALL_Custmers();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] picture_array;
                if (pbox.Image == null)
                {
                    picture_array = new byte[0];
                    cust.ADD_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture_array, "without_image");
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    picture_array = ms.ToArray();
                    cust.ADD_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture_array, "with_image");
                }
                MessageBox.Show("Added Succesfully", "Add Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cust.Get_ALL_Custmers();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور|*.JPG;*.JPEG;*.BMP;*.PNG";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            pbox.Image = null;
            txtFirstName.Focus();

        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLastName.Focus();
                txtLastName.SelectAll();
            }
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTel.Focus();
                txtTel.SelectAll();
            }
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_CUSTOMERS_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                pbox.Image = null;
                ID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                this.txtFirstName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtLastName.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txtTel.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtEmail.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

                byte[] picture_array = (byte[])this.dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(picture_array);
                pbox.Image = Image.FromStream(ms);

            }
            catch
            {
                return;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] picture_array;
                if (pbox.Image == null)
                {
                    picture_array = new byte[0];
                    cust.EDIT_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture_array, "without_image", ID);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    picture_array = ms.ToArray();
                    cust.EDIT_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture_array, "with_image", ID);
                }
                MessageBox.Show("Edited Succesfully", "Edit Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cust.Get_ALL_Custmers();
            }
            catch
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف العميل المحدد؟", "رسالة حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    cust.DeleteCustomer(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تم حذف العميل بنجاح", "رسالة حذف العميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.Get_ALL_Custmers(); // لعملية تحديث البيانات بعد نجاح عملية الحذف
                }
                catch
                {
                    MessageBox.Show("رسالة خطأ، لم يتم حذف العميل");
                }
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cust.Search_Customer(txtSearch.Text);

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //معناه تنفيذ الحدث في حالة الضغط على إينتور
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
