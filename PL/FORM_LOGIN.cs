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
    public partial class FORM_LOGIN : Form
    {
        BL.CLS_Login log = new BL.CLS_Login();

        public FORM_LOGIN()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(txtID.Text, txtPWD.Text);
            if (dt.Rows.Count > 0)
            {
                //التحقق من نوع المستخدم هل هو مدير ام مستخدم عادي واعطائه الصلاحيات التي يستحقها
                if (dt.Rows[0][2].ToString() == "Administrator")
                {
                    FORM_MAIN.getMainForm.حفظنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    FORM_MAIN.getMainForm.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = true;

                    FORM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;

                    FORM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;

                    FORM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Enabled = true;
                    FORM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Visible = true;

                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                    this.Close();

                }else if (dt.Rows[0][2].ToString() == "User")
                {
                    FORM_MAIN.getMainForm.حفظنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    FORM_MAIN.getMainForm.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = true;

                    FORM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;

                    FORM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;

                    FORM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Enabled = false;
                    FORM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Visible = false;

                    Program.SalesMan = dt.Rows[0]["FullName"].ToString();
                    btnEnter.Enabled = false;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Loggin failed");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
