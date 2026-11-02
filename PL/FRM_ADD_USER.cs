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
    public partial class FRM_ADD_USER : Form
    {
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == string.Empty || txtFullName.Text == string.Empty || txtPWD.Text == string.Empty ||
                     txtPWDConfirm.Text == string.Empty)
                {
                    MessageBox.Show("من فضلك قم بملأ  الحقول الضرورية أولا");
                    return;
                }

                if (txtPWD.Text != txtPWDConfirm.Text)
                {
                    MessageBox.Show("كلمة المرور غير متطابقة مع كلمة المرور التي أدخلتها");
                    return;
                }

                if(btnSave.Text == "حفظ المستخدم")
                {
                    BL.CLS_Login user = new BL.CLS_Login();
                    user.ADD_USER(txtID.Text, txtPWD.Text, cmbType.Text, txtFullName.Text);
                    MessageBox.Show("تم إضافة المستخدم بنجاح");
                }
                else if (btnSave.Text == "تعديل المستخدم")
                {
                    BL.CLS_Login user = new BL.CLS_Login();
                    user.EDIT_USER(txtID.Text, txtPWD.Text, cmbType.Text, txtFullName.Text);
                    MessageBox.Show("تم تعديل المستخدم بنجاح");
                }

                txtID.Clear();
                txtFullName.Clear();
                txtPWD.Clear();
                txtPWDConfirm.Clear();
                cmbType.ResetText();
                txtID.Focus();
            }
            catch
            {
                MessageBox.Show("هناك خطأ قم بالتحقق أولا");
                return;
            }
        }

        private void txtPWDConfirm_Validated(object sender, EventArgs e)
        {
            if (txtPWD.Text != txtPWDConfirm.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة مع كلمة المرور التي أدخلتها");
                return;
            }
        }
    }
}
