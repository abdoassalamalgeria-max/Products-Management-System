using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Products_Management.DAL
{
   
    internal class DataAccessLayer
    {
        SqlConnection sqlConnection; //create object "sqlConnection" from class "SqlConnection"
        //this constructor initialize the connection object
        public DataAccessLayer()
        {
            sqlConnection = new SqlConnection(@"Server=DESKTOP-1QJGK5R\SQLEXPRESS; DataBase=Products_DB; Integrated Security=true");
        }
        
        //method to open the connection
        public void Open()
        {
            if(sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        //method to Close the connection
        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        //method read data from database
        //this function type is DataTable, and its receive two parameters: stored_procedure and param.
        //هذا الاجراء دوره قراءة البيانات الموجودة في قاعدة البيانات عبر الاجراءات المخزنة التي يستقبلها
        //مع بارامتراتها
        //ولتنفيذ الاجراءات المخزنة يجب ربطها مع أسكيوالكوماند
          
        public DataTable SelectData(String stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand(); // أنشأناه من أجل تنفيذ الاجراء المخزن
            sqlcmd.Connection = sqlConnection; // للربط بالاتصال
            sqlcmd.CommandType = CommandType.StoredProcedure; // لتبيين نوع الكوماند انه اجراء مخزن
            sqlcmd.CommandText = stored_procedure; // ونص هذا الكوماند هو نفسه نص الاجراء المخزن

            //ستحقق هل هذا الاجراء فيه بارامترات أم لا
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);// معناه يضيف البارامترات في المصفوفة بارام
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd); //هذا الداتاأذابتر مكلف بتنفيذ الاسكيولكوماند
            DataTable dt = new DataTable(); //ننشأ جدول فارغ لاحتواء البيانات فيه
            da.Fill(dt); //نملأ الجدول بالبانات التي تم تنفيذها من قبل الداتاأدابتر
            return dt; //معناه النتيجة أصبحت عندنا جاهزة
        }
        //method to insert or delete or update data from database
        public void ExecuteCommand(String stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand(); // أنشأناه من أجل تنفيذ الاجراء المخزن
            sqlcmd.Connection = sqlConnection; //للربط بالاتصال
            sqlcmd.CommandType = CommandType.StoredProcedure; // لتبيين نوع الكوماند انه اجراء مخزن
            sqlcmd.CommandText = stored_procedure; // ونص هذا الكوماند هو نفسه نص الاجراء المخزن

            //ستحقق هل هذا الاجراء فيه بارامترات أم لا
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);// معناه يضيف البارامترات في المصفوفة بارام
            }
            sqlcmd.ExecuteNonQuery(); //معناه نفذ لي نص الاجراء كما هو ولا تعيد لي اي شيء

        }

    }
}
