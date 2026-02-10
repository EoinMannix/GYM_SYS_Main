using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GYM_SYS
{
    internal class Member
    {

        public int MemberID { get; set; }
        public string MemberForename { get; set; }
        public string MemberSurename { get; set; }
        public DateTime MemberDOB { get; set; }
        public string MemberPhone { get; set; }
        public String MemberEmail { get; set; }
        public string MemberGender { get; set; }


        public Member (int id, string forename, string surename,
            DateTime dob, string phone, string email, string gender )
        {
            MemberID = id;
            MemberForename = forename;
            MemberSurename = surename;
            MemberDOB = dob;
            MemberPhone = phone;
            MemberEmail = email;
            MemberGender = gender;

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
            string sqlQuery = "SELECT MEMBERID, FORENAME, SURENAME, DOB, PHONE, EMAIL, GENDER " +
                "FROM MEMBERS " +
                "WHERE Status = 'Active' " +
                "ORDER BY MEMBERID";
            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }

        public static Member GetMembers(int id)
        {

            string sqlQuery = "SELECT * FROM MEMBERS WHERE MEMBERID = " + id;


            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);


            if (!dr.Read())
            {
                MessageBox.Show("Member not found.");
                dr.Close();
                return null;
            }

            else
            {
                string forename = dr.GetString(1);
                string surename = dr.GetString(2);
                DateTime dob = dr.GetDateTime(3);
                string phone = dr.GetString(4);
                string email = dr.GetString(5);
                string gender = dr.GetString(6);


                dr.Close();

                return new Member(id, forename, surename, dob, phone, email, "");
            }
        }

        public void AddMember()
        {
            string sqlQuery = "INSERT INTO Members VALUES (" +
                MemberID + ", '" +
                MemberForename + "', '" +
                MemberSurename + "', TO_DATE('" +
                MemberDOB.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY'), '" +
                MemberPhone + "', '" +
                MemberEmail + "', '" +
                MemberGender + "' , 'Active')";

            Database.ExecuteNonQuery(sqlQuery);
        }

        public void UpdateMember()
        {
            string sqlQuery = "UPDATE MEMBERS SET " +
                "FORENAME = '" + MemberForename + "', " +
                "SURENAME = '" + MemberSurename + "', " +
                "DOB = TO_DATE('" + MemberDOB.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY'), " +
                "PHONE = '" + MemberPhone + "', " +
                "EMAIL = '" + MemberEmail + "', " +
                "GENDER = '" + MemberGender + "' " +
                "WHERE MEMBERID = " + MemberID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindMembers(string MemberForename)
        {
            string sqlQuery = "SELECT MEMBERID, FORENAME, SURENAME, DOB," +
                " PHONE, EMAIL, GENDER " +
                "FROM MEMBERS " +
                "WHERE FORENAME LIKE '%" + MemberForename + "%' " +
                "ORDER BY MEMBERID";

            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }

        public void DeleteMember()
        {
            string sqlQuery = "UPDATE MEMBERS SET Status = 'Inactive' " +
                "WHERE MemberID = " + MemberID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static int GetNextMemberID()
        {
            
            string sqlQuery = "SELECT MAX(MEMBERID) FROM MEMBERS";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery); //an example of the data reader being used

            int nextID = 1001; // Default to 1 if there are no members

            if (dr.Read() && !dr.IsDBNull(0))
            {
                nextID = dr.GetInt32(0) + 1;
            }

            dr.Close();

            return nextID;

        }

    }
}
