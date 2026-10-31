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

namespace Products_Management.PL
{
    public partial class FRM_CUSTOMERS_LIST : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        public FRM_CUSTOMERS_LIST()
        {
            InitializeComponent();
        }

        private void FRM_CUSTOMERS_LIST_Load(object sender, EventArgs e)
        {
            this.DgvGetAllCust.DataSource = cust.Get_ALL_Custmers();
            this.DgvGetAllCust.Columns[0].Visible = false; //لا نريد للأيدي أن يظهر
            this.DgvGetAllCust.Columns[5].Visible = false; //لانريد للصورة ان تظهر
        }

        private void DgGetAllCustomers_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
