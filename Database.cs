using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace GYM_SYS
{
    class Database
    {
        
        private const string connectionString =
                 "User Id=C##USER;Password=Oracle;" +
                    "Data Source=(DESCRIPTION=" +
                     "(ADDRESS=(PROTOCOL=TCP)(HOST=EMXlaptop1)(PORT=1521))" +
                        "(CONNECT_DATA=(SERVICE_NAME=orcl)))";
        //https://docs.oracle.com/en/database/oracle/oracle-database/26/odpnt/OracleConnectionClass.html#GUID-A8BFA792-97D6-423B-9548-80CA0652174E
        // As i was for the majority using my home laptop , i did some debugging and found ou that i must switch my connection string as i made a 'C##USER' user in my local database which needed a data source query as a service name isntead of the regular orcl
        //I also found that instead of using local host i can use the Name of my laptop which is EMXlaptop1 and it worked fine.



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
            OracleConnection conn = OpenConnection();
             //Formulate the DB request

            OracleCommand cmd = new OracleCommand(query, conn);
            //Use an OracleDataAdapter as a bridge between the DB and an in-memory

            //data structure (a DataSet in this case)
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //Create the DataSet to hold results of the query

            DataSet ds = new DataSet();
            //Populate the DataSet with the results of the query

            da.Fill(ds);

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