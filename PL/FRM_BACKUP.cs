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
using Products_Management.DAL;

namespace Products_Management.PL
{
    public partial class FRM_BACKUP : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-1QJGK5R\SQLEXPRESS; DataBase=Products_DB; Integrated Security=true");
        SqlCommand cmd = new SqlCommand();

        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtFileName.Text + "\\Products_DB" + DateTime.Now.ToString("_yyyy_MM_dd_HH_mm_ss").Replace("\\", "_");
                string strQuery = "Backup DataBase Products_DB to disk = '" + fileName + ".bak'";
                cmd = new SqlCommand(strQuery, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("تم انشاء النسخة الاحتياطية بنجاح");

            }
            catch
            {
                return;
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
