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

namespace Products_Management.PL
{
    public partial class FRM_CUSTOMERS : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();

        public FRM_CUSTOMERS()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] picture_array = ms.ToArray();
                cust.ADD_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture_array);
                MessageBox.Show("Added Succesfully", "Add Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error Message");
            }

        }

        private void pbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور | *.JPG; *.JPEG; *.BMP; *.PNG";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
