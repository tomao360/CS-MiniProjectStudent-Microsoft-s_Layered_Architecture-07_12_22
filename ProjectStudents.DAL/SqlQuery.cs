using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ProjectStudents.DAL
{
    public class SqlQuery
    {
        //Delegate Opption 1
        public delegate void SetDataReader_delegate(SqlDataReader reader);

        //Delegate Option 2
        public delegate object SetResultDataReader_delegate(SqlDataReader reader);

        //Void Function to get Data from SQL
        public static void RunCommand(string sqlQuery, SetDataReader_delegate func)
        {
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = sqlQuery;

                //Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        func(reader);
                    }
                }
            }
        }

        //Function to get Data from SQL and return an Object
        public static object RunCommandResult(string sqlQuery, SetResultDataReader_delegate func)
        {
            object ret = null;
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = sqlQuery;

                //Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        ret = func(reader);
                    }
                }
            }

            return ret;
        }

        //Function to Insert/Update Data into DB (SQL)
        public static void RunNonQuery(string sqlQuery)
        {
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = sqlQuery;

                //Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();    
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
