using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns.Decorator
{
    public class SqlProductRetriever : IProductRetriever
    {
        private readonly string _dbConnectionString;

        public SqlProductRetriever(string dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
        }

        public IEnumerable<string> GetProductIds()
        {
            var productIds = new List<string>();

            using (var conn = new SqlConnection(_dbConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID, Name From Product", conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        productIds.Add(reader["ID"].ToString());
                    }
                }
            }

            return productIds;
        }

        public string GetProductIdByName(string name)
        {
            string id = string.Empty;

            using (var conn = new SqlConnection(_dbConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID From Product WHERE Name = @Name", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar)).Value = name;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        id = reader[0].ToString();
                    }
                }
            }

            return id;
        }
    }
}
