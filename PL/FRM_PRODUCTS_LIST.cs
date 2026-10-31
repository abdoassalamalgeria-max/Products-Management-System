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
    public partial class FRM_PRODUCTS_LIST : Form
    {
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();

        public FRM_PRODUCTS_LIST()
        {
            InitializeComponent();
        }

        private void dgvProductList_Click(object sender, EventArgs e)
        {
        }

        private void FRM_PRODUCTS_LIST_Load(object sender, EventArgs e)
        {
            this.dgvProductList.DataSource = prd.Get_ALL_PRODUCTS();
        }

        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
