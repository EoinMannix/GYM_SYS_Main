using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_SYS
{
    internal class Instructor
    {

        public int InstructorID { get; set; }
        public string InstructorForename { get; set; }
        public string InstructorSurname { get; set; }
        public DateTime InstructorDOB { get; set; }
        public int InstructorPhone { get; set; }
        public String InstructorEmail { get; set; }
        public String InstructorGender { get; set; }
        public String InstructorClassName { get; set; }
        public String InstructorWorkdays { get; set; }


        public Instructor(int instructorID, string instructorForename, string instructorSurname,
            DateTime instructorDOB, int instructorPhone, string instructorEmail, string instructorGender,
            string instructorClassName, string instructorWorkdays)
        {
            InstructorID = instructorID;
            InstructorForename = instructorForename;
            InstructorSurname = instructorSurname;
            InstructorDOB = instructorDOB;
            InstructorPhone = instructorPhone;
            InstructorEmail = instructorEmail;
            InstructorGender = instructorGender;
            InstructorClassName = instructorClassName;
            InstructorWorkdays = instructorWorkdays;
        }


        public override string ToString()  // to display instructor information
        {
            return "Instructor ID: " + InstructorID +
                   ", Forename: " + InstructorForename +
                   ", Surname: " + InstructorSurname +
                   ", Date of Birth: " + InstructorDOB.ToShortDateString() +
                   ", Phone: " + InstructorPhone +
                   ", Email: " + InstructorEmail;
        }

        public static DataSet GetAllInstructors()
        {
            string sqlQuery = "SELECT * FROM Instructors ORDER BY InstructorID";
            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }

        public static Instructor GetInstructor (int id)
        {

            string sqlQuery = "SELECT * FROM Instructors WHERE InstructorID = " + id;

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            dr.Read();

            string forename = dr.GetString(1);
            string surname = dr.GetString(2);
            DateTime dob = dr.GetDateTime(3);
            int phone = dr.GetInt32(4);
            string email = dr.GetString(5);

            dr.Close();

            return new Instructor(id, forename, surname, dob, phone, email, "", "", "");
        }

        public void AddProduct()
        {
            Debug.WriteLine(this);

            string sqlQuery = "INSERT INTO Instructors Values (" +
                              InstructorID + ", '" +
                              InstructorForename + "', '" +
                              InstructorSurname + "', TO_DATE('" +
                              InstructorDOB.ToString("dd-MM-yyyy") + "', 'DD-MM-YYYY'), " +
                              InstructorPhone + ", '" +
                              InstructorEmail + "')";

            Database.ExecuteNonQuery(sqlQuery);
        }

        public void UpdateInstructor()
        {
            string sqlQuery = "UPDATE Instructors SET " +
                              "InstructorForename = '" + InstructorForename + "', " +
                              "InstructorSurname = '" + InstructorSurname + "', " +
                              "InstructorDOB = TO_DATE('" + InstructorDOB.ToString("dd-MM-yyyy") +
                              "', 'DD-MM-YYYY'), " +
                              "InstructorPhone = " + InstructorPhone + ", " +
                              "InstructorEmail = '" + InstructorEmail + "' " +
                              "WHERE InstructorID = " + InstructorID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindInstructors(string InstructorForename)
        {
            string sqlQuery = "SELECT InstructorID, InstructorForename, InstructorSurname, InstructorDOB, InstructorPhone, InstructorEmail " +
                              "FROM Instructors " +
                              "WHERE InstructorForename LIKE '%" + InstructorForename + "%' " +
                              "ORDER BY InstructorID";

            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }

    }
}


