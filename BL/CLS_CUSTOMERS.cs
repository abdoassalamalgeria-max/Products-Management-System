using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Products_Management.BL
{
    internal class CLS_CUSTOMERS
    {
        //functin that add CUSTOMER from data base
        public void ADD_CUSTOMER(string FIRST_NAME, string LAST_NAME,
                                string TEL, string EMAIL, byte[] img)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar, 50);
            param[0].Value = FIRST_NAME;
            param[1] = new SqlParameter("@last_name", SqlDbType.VarChar, 50);
            param[1].Value = LAST_NAME;
            param[2] = new SqlParameter("@tel", SqlDbType.NChar, 15);
            param[2].Value = TEL;
            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            param[3].Value = EMAIL;
            param[4] = new SqlParameter("@picture", SqlDbType.Image);
            param[4].Value = img;


            dal.ExecuteCommand("ADD_CUSTOMER", param);

            dal.Close();
        }
    }
}
