using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            //gathering all information about the students present in table 'Student'
            string query = "SELECT * FROM [Student] INNER JOIN Person ON Student.PersonID = Person.PersonID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //storing all information about students from database to a list of students
        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    PersonID = (int)dr["PersonID"],
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    PhoneNumber = dr["PhoneNumber"].ToString(),
                    StudentNumber = (int)dr["StudentNumber"],
                    Class = dr["Class"].ToString(),
                    VoucherCredit = (int)dr["VoucherCredit"],
                    RoomID = (int)dr["RoomID"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}