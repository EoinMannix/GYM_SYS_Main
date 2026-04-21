using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GYMSYS
{
    internal class Booking
    {
        public int BookingID { get; set; }
        public int MemberID { get; set; }
        public int ClassID { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }


        public Booking(int bookingId, int memberId, int classId, DateTime bookingDate, string status)
        {
            BookingID = bookingId;
            MemberID = memberId;
            ClassID = classId;
            BookingDate = bookingDate;
            Status = status;
        }

        public override string ToString()
        {
            return "Booking ID: " + BookingID +
                   ", Member ID: " + MemberID +
                   ", Class ID: " + ClassID +
                   ", Booking Date: " + BookingDate.ToShortDateString() +
                   ", Status: " + Status;
        }

        public void AddBooking()
        {
            string sqlQuery = "INSERT INTO BOOKINGS VALUES (" +
                BookingID + ", " +
                MemberID + ", " +
                ClassID + ", TO_DATE('" +
                BookingDate.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY'), '" +
                Status + "')";

            Database.ExecuteNonQuery(sqlQuery);

        }

        public static int GetNextBookingID()
        {
            string sqlQuery = "SELECT MAX(BOOKINGID) FROM BOOKINGS";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery); //an example of the data reader being used

            int nextID = 1;

            if (dr.Read() && !dr.IsDBNull(0))
            {
                nextID = dr.GetInt32(0) + 1;
            }

            dr.Close();

            return nextID;

        }

        public void CancelBooking()
        {
            string sqlQuery = "UPDATE BOOKINGS SET STATUS = 'Cancelled' " +
                "WHERE BOOKINGID = " + BookingID;
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static Booking GetBooking(int id)
        {
            string sqlQuery = "SELECT * FROM BOOKINGS WHERE BOOKINGID = " + id;

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            if (!dr.Read())
            {
                dr.Close();
                return null;
            }

            else
            {
                int memberID = dr.GetInt32(1);
                int classID = dr.GetInt32(2);
                DateTime bookingDate = dr.GetDateTime(3);
                string status = dr.GetString(4);

                dr.Close();

                return new Booking(id, memberID, classID, bookingDate, status);
            }
        }

        public static DataSet GetAllBookings()
        {
            string sqlQuery = "SELECT BOOKINGID, MEMBERID, CLASSID, BOOKINGDATE, STATUS " +
                "FROM BOOKINGS " +
                "WHERE STATUS = 'Active' " +
                "ORDER BY BOOKINGID";

            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }

        public static DataSet GetBookingsByMember(int memberId)
        {
            string sqlQuery = "SELECT BOOKINGID, MEMBERID, CLASSID, BOOKINGDATE, STATUS " +
                "FROM BOOKINGS " +
                "WHERE MEMBERID = " + memberId + " AND STATUS = 'Active' " +
                "ORDER BY BOOKINGID";

            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;

        }

    }

}
