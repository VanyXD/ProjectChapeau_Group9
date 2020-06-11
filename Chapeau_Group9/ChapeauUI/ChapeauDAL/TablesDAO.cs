using ChapeauModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ChapeauDAL
{
    public class TablesDAO : Base
    {
        private SqlConnection dbConnection;
        public TablesDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
        public List<Tables> GetALLTables()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT table_id,TableStatus,table_number FROM tables", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Tables> tables = new List<Tables>();
            while (reader.Read())
            {
                Tables table = ReadTables(reader);
                tables.Add(table);
            }
            reader.Close();
            dbConnection.Close();
            return tables;
        }
        private Tables ReadTables(SqlDataReader reader)
        {


            int TableID = (int)reader["table_id"];
            TableStatus Status = (TableStatus)reader["TableStatus"];
            int TableNumber = (int)reader["table_number"];

            return new Tables(TableID, Status, TableNumber);
        }
        public void UpdateTableStatus(Tables table)
        {


            SqlCommand cmd = new SqlCommand("update [tables] set Tablestatus = @stat where table_id = @id", conn);

            cmd.Parameters.AddWithValue("@id", table.TableID); // fuck elias
            cmd.Parameters.AddWithValue("@stat", table.Status); // it never does fuck u anyway akhrus

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }
    }
}






