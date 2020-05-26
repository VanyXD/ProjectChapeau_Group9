using ChapeauModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class TablesDAO : Base
    {
        public List<Tables> GetAllTabels()
        {
            string query = "SELECT table_id,TableStatus,table_number FROM [tables]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTabels(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Tables> ReadTabels(DataTable datatable)
        {
            List<Tables> TabelsList = new List<Tables>();
            foreach (DataRow dr in datatable.Rows)
            {
                Tables Table = new Tables()
                {
                    TableID = (int)dr["table_id"],
                    Status = (TableStatus)dr["TableStatus"],
                    TableNumber = (int)dr["table_number"]
                };
                TabelsList.Add(Table);
            }
            return TabelsList;
        }
    }
}


        

