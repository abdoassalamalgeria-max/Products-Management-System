using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management.BL
{
    internal class CLS_ORDERS
    {
        //دالة تجلب كل الطلبات من قاعدة البيانات
        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = dal.SelectData("GET_LAST_ORDER_ID", null);

            dal.Close();

            return dt;
        }

        //functin that add CUSTOMER from data base
        public void ADD_ORDER(int ID_ORDER, DateTime DATE_ORDER,
                                int ID_CUSTOMER, string DESCRIPTION_ORDER, string SALESMAN)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_Order", SqlDbType.Int);
            param[0].Value = ID_ORDER;
            param[1] = new SqlParameter("@Date_Order", SqlDbType.DateTime);
            param[1].Value = DATE_ORDER;
            param[2] = new SqlParameter("@Customer_ID", SqlDbType.Int);
            param[2].Value = ID_CUSTOMER;
            param[3] = new SqlParameter("@Description_Order", SqlDbType.VarChar, 250);
            param[3].Value = DESCRIPTION_ORDER;
            param[4] = new SqlParameter("@SalesMan", SqlDbType.VarChar, 75);
            param[4].Value = SALESMAN;

            dal.ExecuteCommand("ADD_ORDER", param);

            dal.Close();
        }


    }
}
