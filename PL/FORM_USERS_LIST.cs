using Microsoft.VisualBasic.Logging;
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
    public partial class FORM_USERS_LIST : Form
    {
        BL.CLS_Login login = new BL.CLS_Login();

        public FORM_USERS_LIST()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_USER frm = new PL.FRM_ADD_USER();
            frm.btnSave.Text = "حفظ المستخدم";
            frm.ShowDialog();

            dgvUsersList.DataSource = login.SearchUsers("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_USER frm = new PL.FRM_ADD_USER();
            frm.btnSave.Text = "تعديل المستخدم";

            frm.txtID.Text = dgvUsersList.CurrentRow.Cells[0].Value.ToString();
            frm.txtPWD.Text = dgvUsersList.CurrentRow.Cells[1].Value.ToString();
            frm.txtPWDConfirm.Text = dgvUsersList.CurrentRow.Cells[1].Value.ToString();
            frm.cmbType.Text = dgvUsersList.CurrentRow.Cells[2].Value.ToString();
            frm.txtFullName.Text = dgvUsersList.CurrentRow.Cells[3].Value.ToString();

            frm.ShowDialog();
            dgvUsersList.DataSource = login.SearchUsers("");
        }

        private void FORM_USERS_LIST_Load(object sender, EventArgs e)
        {
            dgvUsersList.DataSource = login.SearchUsers("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvUsersList.DataSource = login.SearchUsers(txtSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا المستخدم", "رسالة جذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                login.DELETE_USER(dgvUsersList.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم الحذف بنجاح");
                dgvUsersList.DataSource = login.SearchUsers("");
            }

        }
    }
}
