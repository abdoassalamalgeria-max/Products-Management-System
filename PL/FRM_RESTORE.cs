using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Products_Management.PL
{
    public partial class FRM_RESTORE : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-1QJGK5R\SQLEXPRESS; DataBase=Products_DB; Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        public FRM_RESTORE()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string strQuery = "Alter Database Products_DB Set Offline With Rollback Immediate; Restore DataBase Products_DB From disk = '" + txtFileName.Text + "'";
                cmd = new SqlCommand(strQuery, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "هناك خطأ");
            }
        }
    }
}
