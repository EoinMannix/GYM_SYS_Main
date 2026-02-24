using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMSYS
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
        public string InstructorWorkdays { get; set; }


        public Instructor(int id, string Forename, string Surname,
            DateTime DOB, string Phone, string Email, string Gender,
            string Workdays)
        {
            InstructorID = id;
            InstructorForename = Forename;
            InstructorSurname = Surname;
            InstructorDOB = DOB;
            InstructorPhone = Phone;
            InstructorEmail = Email;
            InstructorGender = Gender;
            InstructorWorkdays = Workdays;
        }


        public override string ToString()  // to display instructor information
        {
            return "Instructor ID: " + InstructorID +
                   ", Forename: " + InstructorForename +
                   ", Surname: " + InstructorSurname +
                   ", Date of Birth: " + InstructorDOB.ToShortDateString() +
                   ", Phone: " + InstructorPhone +
                   ", Email: " + InstructorEmail +
                   ", Gender : " + InstructorGender +
                   ", Workdays: " + InstructorWorkdays;
        }

        public static DataSet GetAllInstructors()
        {
            string sqlQuery = "SELECT INSTRUCTORID, FORENAME, SURENAME, DOB, PHONE, EMAIL, GENDER, WORKDAYS " +
                "FROM INSTRUCTORS " +
                "WHERE Status = 'Active' " +
                "ORDER BY INSTRUCTORID";
            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }

        public static Instructor GetInstructor(int id)
        {

            string sqlQuery = "SELECT * FROM Instructors WHERE InstructorID = " + id;
                

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            if (!dr.Read())
            {
                MessageBox.Show("Instructor not found.");
                dr.Close();
                return null;
            }

            else
            {

                string forename = dr.GetString(1);
                string surname = dr.GetString(2);
                DateTime dob = dr.GetDateTime(3);
                string phone = dr.GetString(4);
                string email = dr.GetString(5);
                string gender = dr.GetString(6);
                string workdays = dr.GetString(7);

                dr.Close();

                return new Instructor(id, forename, surname, dob, phone, email, gender, workdays);
            }

        }

        public void AddInstructor()
        {
            Debug.WriteLine(this);

            string sqlQuery = "INSERT INTO Instructors VALUES (" +
                              InstructorID + ", '" +
                              InstructorForename + "', '" +
                              InstructorSurname + "', TO_DATE('" +
                              InstructorDOB.ToString("dd-MM-yyyy") + "', 'DD-MM-YYYY'), " +
                              InstructorPhone + ", '" +
                              InstructorEmail + "' , '" +
                              InstructorGender + "', '" +
                              InstructorWorkdays + "', 'Active')";

            Database.ExecuteNonQuery(sqlQuery);
        }

        public void UpdateInstructor()
        {
            string sqlQuery = "UPDATE Instructors SET " +
                              "FORENAME = '" + InstructorForename + "', " +
                              "SURENAME = '" + InstructorSurname + "', " +
                              "DOB = TO_DATE('" + InstructorDOB.ToString("dd-MM-yyyy") + "', 'DD-MM-YYYY'), " +
                              "PHONE = '" + InstructorPhone + "', " +
                              "EMAIL = '" + InstructorEmail + "', " +
                              "GENDER = '" + InstructorGender + "', " +
                              "WORKDAYS = '" + InstructorWorkdays + "' " +
                              "WHERE InstructorID = " + InstructorID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindInstructors(string InstructorForename)
        {
            string sqlQuery = "SELECT INSTRUCTORID, FORENAME, SURENAME, DOB, PHONE, EMAIL, GENDER, WORKDAYS " +
                "FROM INSTRUCTORS " +
                "WHERE FORENAME LIKE '%" + InstructorForename + "%' " +
                "ORDER BY INSTRUCTORID";

            DataSet ds = Database.ExecuteMultiRowQuery(sqlQuery);
            return ds;
        }


        public static int GetNextInstructorID()
        {

            string sqlQuery = "SELECT MAX(INSTRUCTORID) FROM INSTRUCTORS";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            int nextID = 2001; // Default to 1 if there are no members

            if (dr.Read() && !dr.IsDBNull(0))
            {
                nextID = dr.GetInt32(0) + 1;
            }

            dr.Close();

            return nextID;

        }

        public void DeleteInstructor()
        {
            string sqlQuery =
                "UPDATE Instructors SET Status = 'Inactive' " +
                "WHERE InstructorID = " + InstructorID;
            Database.ExecuteNonQuery(sqlQuery);


        }

    }
}


