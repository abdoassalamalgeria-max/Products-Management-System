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
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtServerName.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            if (rbSql.Checked == true)
            {
                Properties.Settings.Default.Mode = "SQL";
            }
            else if (rbWindows.Checked == true)
            {
                Properties.Settings.Default.Mode = "Windows";
            }
            Properties.Settings.Default.ID = txtID.Text;
            Properties.Settings.Default.Password = txtPWD.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("لقد تم حفظ المعلومات بنجاح");
        }

        private void FRM_CONFIG_Load(object sender, EventArgs e)
        {
            txtServerName.Text = Properties.Settings.Default.Server;
            txtDatabase.Text = Properties.Settings.Default.Database;
            if (Properties.Settings.Default.Mode == "Windows")
            {
                rbWindows.Checked = true;
                txtID.Clear();
                txtPWD.Clear();
                txtID.ReadOnly = true;
                txtPWD.ReadOnly = true;
            }
            else if(Properties.Settings.Default.Mode == "SQL")
            {
                rbSql.Checked = true;
                txtID.Text = Properties.Settings.Default.ID;
                txtPWD.Text = Properties.Settings.Default.Password;
            }

        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Clear();
            txtPWD.Clear();
            txtID.ReadOnly = true;
            txtPWD.ReadOnly = true;
        }

        private void rbSql_CheckedChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            txtPWD.ReadOnly = false;
        }
    }
}
