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

    }
}
