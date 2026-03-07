using GYMSYS;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMSYS
{
    internal class Classes
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int InstructorID { get; set; }
        public decimal ClassPrice { get; set; }
        public DateTime ClassDate { get; set; }
        public string ClassTime { get; set; }
        public string Room { get; set; }
        public string TypeCode { get; set; }

        public Classes(int id, string name, int instructorID, decimal price,
            DateTime date, string time, string room, string typeCode)
        {
            ClassID = id;
            ClassName = name;
            InstructorID = instructorID;
            ClassPrice = price;
            ClassDate = date;
            ClassTime = time;
            Room = room;
            TypeCode = typeCode;
        }


        public override string ToString()  // to display class information
            {
            return "Class ID: " + ClassID +
                   ", Class Name: " + ClassName +
                   ", Instructor ID: " + InstructorID +
                   ", Class Price: " + ClassPrice +
                   ", Class Date: " + ClassDate.ToShortDateString() +
                   ", Class Time: " + ClassTime +
                   ", Room: " + Room;
        }

        public static DataSet GetAllClasses()
        {   
            string sqlQuery = "SELECT CLASSID, CLASSNAME, INSTRUCTORID, PRICE, CLASSDATE, CLASSTIME, ROOM, TYPECODE " +
                "FROM CLASSES " +
                "WHERE Status = 'Active' " +
                "ORDER BY CLASSID";

            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }

        public static Classes GetClass (int id)
        {
            string sqlQuery = "SELECT CLASSID, CLASSNAME, INSTRUCTORID, PRICE, CLASSDATE, CLASSTIME, ROOM, TYPECODE " +
                "FROM CLASSES " +
                "WHERE CLASSID = " + id;

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            if (!dr.Read())
            {
                MessageBox.Show("Class with ID " + id + " not found.");
                dr.Close();
                return null;
            }

            else
            {

                string name = dr.GetString(1);
                int instructorID = dr.GetInt32(2);
                decimal price = dr.GetDecimal(3);
                DateTime date = dr.GetDateTime(4);
                string time = dr.GetString(5);
                string room = dr.GetString(6);
                string typeCode = dr.GetString(7);

                dr.Close();

                return new Classes(id, name, instructorID, price, date, time, room, typeCode);

            }

        }

        public void AddClass()
        {
            string sqlQuery = "INSERT INTO CLASSES VALUES (" +
                ClassID + ", '" +
                ClassName + "', " +
                InstructorID + ", " +
                ClassPrice + ", TO_DATE('" +
                ClassDate.ToString("dd-MM-yyyy") + "', 'dd-MM-yyyy'), '" +
                ClassTime + "', '" +
                Room + "', '" +
                TypeCode + "', 'Active')";


            Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public void UpdateClass()
        {
            string sqlQuery = "UPDATE CLASSES SET " +
                "CLASSNAME = '" + ClassName + "', " +
                "INSTRUCTORID = " + InstructorID + ", " +
                "PRICE = " + ClassPrice + ", " +
                "CLASSDATE = TO_DATE('" + ClassDate.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), " +
                "CLASSTIME = '" + ClassTime + "', " +
                "ROOM = '" + Room + "' " +
                "TYPECODE = '" + TypeCode + "' " +
                "WHERE CLASSID = " + ClassID;

            Database.ExecuteMultiRowQuery(sqlQuery);
        }
         public void DeleteClass()
        {
            string sqlQuery = "UPDATE CLASSES SET Status = 'Inactive' WHERE CLASSID = " + ClassID;
            Database.ExecuteMultiRowQuery(sqlQuery);
        }




    }
}
