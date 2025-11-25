using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace HovSedhep.Helper
{
    internal class DBHelper
    {
        public static readonly string connectionString = "Server=HOSHIMI-MIYABI\\SQLEXPRESS;Database=HovSedhepDatabase;Integrated Security=true;TrustServerCertificate=true";

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameter)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if(parameter!=null) cmd.Parameters.AddRange(parameter);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to Execution: "+e.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public static object ExecuteScalar(string query, params SqlParameter[] parameter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameter != null) cmd.Parameters.AddRange(parameter);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to Return Value: "+e.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameter != null) cmd.Parameters.AddRange(parameter);
                    conn.Open();
                    using(SqlDataAdapter da =  new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to Load Data: "+e.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
        public static List<T> ExecuteReader<T>(string query, Func<SqlDataReader, T> func, params SqlParameter[] parameter)
        {
            List<T> list = new List<T>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameter != null) cmd.Parameters.AddRange(parameter);
                    conn.Open();
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(func(dr));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to Read Data: "+e.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }
    }
}
