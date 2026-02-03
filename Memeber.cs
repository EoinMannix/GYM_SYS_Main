using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_SYS
{
    internal class Member
    {

        public int MemberID { get; set; }
        public string MemberForename { get; set; }
        public string MemberSurename { get; set; }
        public DateTime MemberDOB { get; set; }
        public int MemberPhone { get; set; }
        public String MemberEmail { get; set; }
        public string MemberGender { get; set; }


        public Member (int memberID, string memberForename, string memberSurename,
            DateTime memberDOB, int memberPhone, string memberEmail, string memberGender )
        {
            MemberID = memberID;
            MemberForename = memberForename;
            MemberSurename = memberSurename;
            MemberDOB = memberDOB;
            MemberPhone = memberPhone;
            MemberEmail = memberEmail;
            MemberGender = memberGender;

        }

        public override string ToString()  // to display member information
        {
            return "Member ID: " + MemberID +
                   ", Forename: " + MemberForename +
                   ", Surename: " + MemberSurename +
                   ", Date of Birth: " + MemberDOB.ToShortDateString() +
                   ", Phone: " + MemberPhone +
                   ", Email: " + MemberEmail;
        }

        public static DataSet GetAllMembers()
        {
            string sqlQuery = "SELECT * FROM Members ORDER BY MemberID";
            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }

        public static Member GetMember(int id)
        {

            string sqlQuery = "SELECT * FROM Member WHERE MemberID = " + id;

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            dr.Read();

            string forename = dr.GetString(1);
            string surename = dr.GetString(2);
            DateTime dob = dr.GetDateTime(3);
            int phone = dr.GetInt32(4);
            string email = dr.GetString(5);

            dr.Close();

            return new Member(id, forename, surename, dob, phone, email, "");

        }

        public void AddMember()
        {
           Debug.WriteLine(this);

            string sqlQuery = "INSERT INTO Members Values (" +
                MemberID + ", '" +
                MemberForename + "', '" +
                MemberSurename + "', TO_DATE('" +
                MemberDOB.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY'), " +
                MemberPhone + ", '" +
                MemberEmail + "', '" +
                MemberGender + "')";

            Database.ExecuteNonQuery(sqlQuery);
        }

        public void UpdateMember()
        {
            string sqlQuery = "UPDATE Members SET " +
                "MemberForename = '" + MemberForename + "', " +
                "MemberSurename = '" + MemberSurename + "', " +
                "MemberDOB = TO_DATE('" + MemberDOB.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY'), " +
                "MemberPhone = " + MemberPhone + ", " +
                "MemberEmail = '" + MemberEmail + "', " +
                "MemberGender = '" + MemberGender + "' " +
                "WHERE MemberID = " + MemberID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindMembers(string MemberForename)
        {
            string sqlQuery = "SELECT MemberID, MemberForename, MemberSurename, MemberDOB," +
                " MemberPhone, MemberEmail, MemberGender " +
                "FROM Members " +
                "WHERE MemberForename LIKE '%" + MemberForename + "%' " +
                "ORDER BY MemberID";

            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }

    }
}
