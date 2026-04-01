using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Status=status;
        }

        public override string ToString()
        {
            return "Booking ID: " + BookingID +
                   ", Member ID: " + MemberID +
                   ", Class ID: " + ClassID +
                   ", Booking Date: " + BookingDate.ToShortDateString() +
                   ", Status: " + Status;
        }

        public void AddBoking()
        {
            string sqlQuery = "INSERT INTO BOOKINGS VALUES (" +
                BookingID + ", " +
                MemberID + ", " +
                ClassID + ", '" +
                BookingDate.ToString("dd/MM/yyyy") + "', 'DD/)" +
                Status + "')";

        }


    }


}
