using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FORM_MAIN : Form
    {
        //single instance methode
        private static FORM_MAIN frm; //انشاء متغير ستاتيك  معناه مشترك بين كل الكلاصات نوعه الماين فورم

        //create handler (event) that open when the form get opened
        //هذا الحدث يقوم بتصفير المتغير الذي انشاناه بعد تطبيقه
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null; // معناه هدم الاجراء أفأرأم
        }

        //انشاء خاصية للتحقق من قيمة الفورم فان كانت معدومة يقوم من انشائه من جديد
        public static FORM_MAIN getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                    //هذا السطر يقول ببساطة: "عندما تُغلق النافذة frm، نفّذ الدالة frm_FormClosed."

                }
                return frm;
            }
        }

        public FORM_MAIN()
        {
            InitializeComponent();

            if (frm == null)
                frm = this;

            حفظنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            المنتوجاتToolStripMenuItem.Enabled = false;
            العملاءToolStripMenuItem.Enabled = false;
            المستخدمينToolStripMenuItem.Enabled = false;
        }

        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_LOGIN frmLogin = new FORM_LOGIN(); //أي كلاص لكي تستدعيه يجب أن تنسخ منه كائن أولا
            frmLogin.ShowDialog(); //لكي يظهر كعلبة الحوار فوق الفورم الرئيسي

        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            حفظنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            المنتوجاتToolStripMenuItem.Enabled = false;
            العملاءToolStripMenuItem.Enabled = false;
            المستخدمينToolStripMenuItem.Enabled = false;

        }

        private void اضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frmAdd = new FRM_ADD_PRODUCT())
            {
                frmAdd.ShowDialog();
            }

        }

        private void إدارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_PRODUCTS frm = new PL.FRM_PRODUCTS();
            frm.ShowDialog();
        }

        private void إدارةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_CATEGORIES frm = new PL.FRM_CATEGORIES();
            frm.ShowDialog();

        }

        private void إدارةالعملاءToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_CUSTOMERS frm = new PL.FRM_CUSTOMERS();
            frm.ShowDialog();
        }
    }
}
