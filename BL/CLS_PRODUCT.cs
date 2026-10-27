using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Products_Management.BL
{
    internal class CLS_PRODUCT
    {
        //دالة تجلب كل الاصناف من قاعدة البيانات
        public DataTable Get_ALL_Categories()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = dal.SelectData("Get_ALL_Categories", null);

            dal.Close();

            return dt;
        }

        //functin that add product from data base
        public void ADD_PRODUCT(int ID_CAT,string ID_Product, string Label_Product, 
                                int Qte, string Price, byte[] img)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_CAT;
            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.Int);
            param[1].Value = ID_Product;
            param[2] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.VarChar, 50);
            param[2].Value = Label_Product;
            param[3] = new SqlParameter("@QTE_IN_STOCK", SqlDbType.Int);
            param[3].Value = Qte;
            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = Price;
            param[5] = new SqlParameter("@IMAGE_PRODUCT", SqlDbType.Image);
            param[5].Value = img;


            dal.ExecuteCommand("ADD_PRODUCT", param);

            dal.Close();
        }

        //function that verify id product
        public DataTable VerifyIdProduct(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id;

            DataTable dt = dal.SelectData("VerifyProductID", param);

            dal.Close();

            return dt;
        }

        //دالة تجلب كل المنتجات من قاعدة البيانات
        public DataTable Get_ALL_PRODUCTS()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            DataTable dt = dal.SelectData("Get_ALL_PRODUCTS", null);

            dal.Close();

            return dt;
        }

        //function that search for product
        public DataTable SearchProduct(string id)
        {
            var dal = new DAL.DataAccessLayer();
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50) { Value = id ?? "" };

                return dal.SelectData("SearchProduct", param);
            }
            finally
            {
                dal.Close();
            }
        }

        //function that delete a product from database
        public void DeleteProduct(string id)
        {
            var dal = new DAL.DataAccessLayer();
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50) { Value = id ?? "" };

                dal.SelectData("DeleteProduct", param);
            }
            finally
            {
                dal.Close();
            }
        }

        //function that get image of product from db by ID product
        public DataTable GET_IMAGE_PRODUCT(string id)
        {
            var dal = new DAL.DataAccessLayer();
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.VarChar) { Value = id ?? "" };

                return dal.SelectData("GET_IMAGE_PRODUCT", param);
            }
            finally
            {
                dal.Close();
            }
        }

        //functin that add UPDATE_PRODUCT in data base
        public void UPDATE_PRODUCT(int ID_CAT, string ID_Product, string Label_Product,
                                int Qte, string Price, byte[] img)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_CAT;
            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.Int);
            param[1].Value = ID_Product;
            param[2] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.VarChar, 50);
            param[2].Value = Label_Product;
            param[3] = new SqlParameter("@QTE_IN_STOCK", SqlDbType.Int);
            param[3].Value = Qte;
            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = Price;
            param[5] = new SqlParameter("@IMAGE_PRODUCT", SqlDbType.Image);
            param[5].Value = img;


            dal.ExecuteCommand("UPDATE_PRODUCT", param);

            dal.Close();
        }
    }
}

