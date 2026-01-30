using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace GYMSYS
{
    class Database
    {
        public const string connectionString = "Data Source = localhost/orcl; User Id = C##USER; Password = Oracle;";

        //public const string connectionString = "Data Source = studentoracle:1521/orcl; User Id = ... ; Password = **********;";

        public static OracleConnection OpenConnection()
        {
            //Open an Oracle DB connection
            OracleConnection conn = new OracleConnection(Database.connectionString);

            conn.Open();

            return conn;
        }

        public static DataSet ExecuteMultiRowQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Use an OracleDataAdapter as a bridge between the DB and an in-memory
            //data structure (a DataSet in this case)
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Create the DataSet to hold results of the query
            DataSet ds = new DataSet();

            //Populate the DataSet with the results of the query

            //Note that Fill() will use the OracleCommand object to execute query
            da.Fill(ds);

            //Close DB connection
            conn.Close();
            return ds;
        }


        public static OracleDataReader ExecuteSingleRowQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Execute the query and atore the results in an OracleDataReader
            OracleDataReader dr = cmd.ExecuteReader();

            return dr;

        }

        public static void ExecuteNonQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Execute the DB non-query
            cmd.ExecuteNonQuery();

            //Close the DB connection
            conn.Close();

        }
    }
}