using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMSYS
{
    internal class Admin
    {

        public static List<double> GetRevenue()
        {
            List<double> data = new List<double>();

            string sqlQuery = "SELECT price FROM Classes WHERE Status = 'Active'";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            while (dr.Read())
            {
                data.Add(dr.GetDouble(0));
            }

            dr.Close();

            return data;

        }

        public static List<int> GetClassCounts()
        {
            List<int> data = new List<int>();

            string sqlQuery = "SELECT COUNT(*) FROM Classes GROUP BY TypeCode";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            while (dr.Read())
            {
                data.Add(dr.GetInt32(0));
            }

            dr.Close();

            return data;

        }

    }
}
