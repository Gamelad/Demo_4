using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_4
{
    internal class db_Connect
    {
        /// <summary>
        /// строка для подключения 
        /// </summary>
        public static string con = "Data Source = localhost; Initial Catalog = Demo; Integrated Security = true";
        /// <summary>
        /// подключение к БД
        /// </summary>
        /// <returns></returns>
        public static SqlConnection sqlConnection()
        {
            return new SqlConnection (con);
        }
        /// <summary>
        /// метод для вызова данных из БД
        /// </summary>
        /// <param name="sql">запрос</param>
        /// <returns>данные</returns>
        public static DataTable fromDB (string sql)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection());
                DataSet ds = new DataSet ();
                sqlDataAdapter.Fill (ds);
                DataTable dataTable = new DataTable ();
                dataTable = ds.Tables[0];
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
                return null;
            }
        }
        /// <summary>
        /// метод для действий с данными
        /// </summary>
        /// <param name="sql">запрос</param>
        public static void toDB(string sql)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection());
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
            }
        }
    }
}
