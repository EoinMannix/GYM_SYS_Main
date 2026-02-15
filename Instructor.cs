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
        public string InstructorPhone { get; set; }
        public string InstructorEmail { get; set; }
        public string InstructorGender { get; set; }
        public string InstructorClassName { get; set; }
        public string InstructorWorkdays { get; set; }


        public Instructor(int id, string Forename, string Surname,
            DateTime DOB, string Phone, string Email, string instructorGender,
            string ClassName, string Workdays)
        {
            InstructorID = id;
            InstructorForename = Forename;
            InstructorSurname = Surname;
            InstructorDOB = DOB;
            InstructorPhone = Phone;
            InstructorEmail = Email;
            InstructorGender = instructorGender;
            InstructorClassName = ClassName;
            InstructorWorkdays = Workdays;
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
            string phone = dr.GetString(4);
            string email = dr.GetString(5);

            dr.Close();

            return new Instructor(id, forename, surname, dob, phone, email, "", "", "");
        }

        public void AddInstructor()
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
                              "FORENAME = '" + InstructorForename + "', " +
                              "SURENAME = '" + InstructorSurname + "', " +
                              "DOB = TO_DATE('" + InstructorDOB.ToString("dd-MM-yyyy") + "', 'DD-MM-YYYY'), " +
                              "PHONE = " + InstructorPhone + ", " +
                              "EMAIL = '" + InstructorEmail + "' " +
                              "WHERE InstructorID = " + InstructorID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindInstructors(string InstructorForename)
        {
            string sqlQuery = "SELECT InstructorID, InstructorForename, InstructorSurname," +
                              " InstructorDOB, InstructorPhone, InstructorEmail " +
                              "FROM Instructors " +
                              "WHERE InstructorForename LIKE '%" + InstructorForename + "%' " +
                              "ORDER BY InstructorID";

            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }


        public static int GetNextInstructorID()
        {

            string sqlQuery = "SELECT MAX(INSTRUCTORID) FROM INSTRUCTORS";

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


