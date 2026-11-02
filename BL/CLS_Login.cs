using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Products_Management.BL
{
    internal class CLS_Login
    {
        public DataTable LOGIN(string ID, string PWD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, (50));
            param[0].Value = ID;
            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, (50));
            param[1].Value = PWD;

            DataTable dt = DAL.SelectData("SP_LOGIN", param);

            DAL.Close();

            return dt;  
        }

        public void ADD_USER(string ID, string PWD, string UserType, string FullName)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = PWD;
            param[2] = new SqlParameter("@userType", SqlDbType.VarChar, 50);
            param[2].Value = UserType;
            param[3] = new SqlParameter("@fullName", SqlDbType.VarChar, 50);
            param[3].Value = FullName;


            dal.ExecuteCommand("ADD_USER", param);

            dal.Close();
        }

    }
}


