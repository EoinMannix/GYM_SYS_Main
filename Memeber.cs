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
                "FROM MEMBERS ORDER BY MEMBERID";
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


                dr.Close();

                return new Member(id, forename, surename, dob, phone, email, "");
            }
        }

        /*DataReader Method for later use
          public static void GetAllMembersDR()
        {
            string sql = "SELECT * FROM MEMBERS";

           OracleDataReader dr = Database.ExecuteSingleRowQuery(sql);

            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string forename = dr.GetString(1);
                string surename = dr.GetString(2);
                DateTime dob = dr.GetDateTime(3);
                string phone = dr.GetString(4);
                string email = dr.GetString(5);
                Console.WriteLine("ID: " + id + ", Forename: " + forename + ", Surename: " + surename +
                    ", DOB: " + dob.ToShortDateString() + ", Phone: " + phone + ", Email: " + email);
            }
        }
        */


        public void AddMember()
        {
           Debug.WriteLine(this);

            string sqlQuery = "INSERT INTO MEMBERS Values (" +
                MemberID + ", '" +
                MemberForename + "', '" +
                MemberSurename + "', TO_DATE('" +
                MemberDOB.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY'), '" +
                MemberPhone + "', '" +
                MemberEmail + "', '" +
                MemberGender + "')";

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

    }
}
