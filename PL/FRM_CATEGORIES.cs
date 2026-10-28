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
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;

        public FRM_CATEGORIES()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select ID_CAT as 'المعرف', DESCRIPTION_CAT as 'الوصف' from Categories", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;

            txtID.DataBindings.Add("text", dt, "المعرف");
            txtDes.DataBindings.Add("text", dt, "الوصف");

            bmb = this.BindingContext[dt];
            lblposition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;

        }


        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblposition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblposition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblposition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblposition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtID.Text = id.ToString();
            txtDes.Focus();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Added successfully", "Add Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNew.Enabled = true;
            btnAdd.Enabled = false;
            lblposition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Deleted successfully", "Delete Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblposition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Eidted successfully", "Eidted Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblposition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
