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
                                string TEL, string EMAIL, byte[] img, string criterion)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[6];
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
            param[5] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[5].Value = criterion;

            dal.ExecuteCommand("ADD_CUSTOMER", param);

            dal.Close();
        }

        //دالة تجلب كل العملاء من قاعدة البيانات
        public DataTable Get_ALL_Custmers()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = dal.SelectData("Get_ALL_Custmers", null);

            dal.Close();

            return dt;
        }

        //functin that add EDIT_CUSTOMER in data base
        public void EDIT_CUSTOMER(string FIRST_NAME, string LAST_NAME,
                                string TEL, string EMAIL, byte[] img, string criterion, int ID_CUSTOMER)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[7];
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
            param[5] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[5].Value = criterion;
            param[6] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[6].Value = ID_CUSTOMER;

            dal.ExecuteCommand("EDIT_CUSTOMER", param);

            dal.Close();
        }

        //function that delete a customer from database
        public void DeleteCustomer(string id)
        {
            var dal = new DAL.DataAccessLayer();
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50) { Value = id ?? "" };

                dal.SelectData("DELETE_CUSTOMER", param);
            }
            finally
            {
                dal.Close();
            }
        }



    }
}
