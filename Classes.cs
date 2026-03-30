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
        public int RoomId { get; set; }
        public string TypeCode { get; set; }

        public Classes(int id, string name, int instructorID, decimal price,
            DateTime date, string time, int roomId, string typeCode)
        {
            ClassID = id;
            ClassName = name;
            InstructorID = instructorID;
            ClassPrice = price;
            ClassDate = date;
            ClassTime = time;
            RoomId = roomId;
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
                   ", RoomID: " + RoomId;
        }

        public static DataSet GetAllClasses()
        {
            string sqlQuery = "SELECT CLASSID, CLASSNAME, INSTRUCTORID, PRICE, CLASSDATE, CLASSTIME, ROOMID, TYPECODE " +
                "FROM CLASSES " +
                "WHERE Status = 'Active' " +
                "ORDER BY CLASSID";

            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }

        public static Classes GetClass(int id)
        {
            string sqlQuery = "SELECT CLASSID, CLASSNAME, INSTRUCTORID, PRICE, CLASSDATE, CLASSTIME, ROOMID, TYPECODE " +
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
                int roomId = dr.GetInt32(6);
                string typeCode = dr.GetString(7);

                dr.Close();

                return new Classes(id, name, instructorID, price, date, time, roomId, typeCode);

            }

        }

        public void AddClass()
        {
            string sqlQuery = "INSERT INTO CLASSES VALUES (" +
                ClassID + ", '" +
                ClassName + "', " +
                InstructorID + ", " +
                ClassPrice + ", TO_DATE('" +
                ClassDate.ToString("yyyy-MM-dd") + "', 'yyyy-MM-dd'), '" +
                ClassTime + "', " +
                RoomId + ", '" +
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
                "ROOMID = " + RoomId + ", " +
                "TYPECODE = '" + TypeCode + "' " +
                "WHERE CLASSID = " + ClassID;

            Database.ExecuteMultiRowQuery(sqlQuery);
        }
        public void DeleteClass()
        {
            string sqlQuery = "UPDATE CLASSES SET Status = 'Inactive' WHERE CLASSID = " + ClassID;
            Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static string GetRoomName(int roomID)
        {
            string sqlQuery = "SELECT ROOMNAME FROM ROOMS WHERE ROOMID = " + roomID;

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            if (!dr.Read())
            {
                MessageBox.Show("Room with ID " + roomID + " not found.");
                dr.Close();
                return null;
            }
            else
            {
                string roomName = dr.GetString(0);
                dr.Close();
                return roomName;
            }
        }

        public static int GetNextClassID()
        {
            string sqlQuery = "SELECT MAX(CLASSID) FROM CLASSES";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            int nextID = 1; // Default to 1 if there are no classes

            if (dr.Read() && !dr.IsDBNull(0))
            {
                nextID = dr.GetInt32(0) + 1;
            }

            dr.Close();

            return nextID;

        }

        public static bool ClassExists(int roomId, DateTime date, string time)
        {
            string sqlQuery = "SELECT COUNT(*) FROM CLASSES WHERE ROOMID = " + roomId +
                " AND CLASSDATE = TO_DATE('" + date.ToString("yyyy-MM-dd") + "', 'yyyy-MM-dd')" +
                " AND CLASSTIME = '" + time.Trim() + "'";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            int count = 0;

            if (dr.Read())
            {

                count = dr.GetInt32(0);

            }

            dr.Close();

            return count > 0;
        }


    }

    
}
