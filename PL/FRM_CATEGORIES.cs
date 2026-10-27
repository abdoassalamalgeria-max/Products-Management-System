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
    public partial class FRM_CATEGORIES : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Server=DESKTOP-1QJGK5R\SQLEXPRESS; DataBase=Products_DB; Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public FRM_CATEGORIES()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select ID_CAT as 'المعرف', DESCRIPTION_CAT as 'الوصف' from Categories", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;

            txtID.DataBindings.Add("text", dt, "المعرف");
            txtDes.DataBindings.Add("text", dt, "الوصف");

        }


        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
