using System;
using System.Data.SqlClient;
using DatabaseUsingMVC.Models;
using System.Collections.Generic;
namespace DatabaseUsingMVC.Repository
{
    public class StudentRepo
    {
        string ConnectionString = "data source=NEWAR-PC; database=StudentDatabase; integrated security=SSPI";
        public void AddStudent(Student std)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "Insert into StudentTable VALUES(" + std.Id + ",'" + std.Name + "','" + std.Address + "'," + std.PhoneNo + ")";
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                int n = sqlcmd.ExecuteNonQuery();
                Console.WriteLine(n + "Created Successfully");
            }
        }
        public IEnumerable<Student> CatchAll()
        {
            List<Student> stdL = new List<Student>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "Select* from StudentTable";
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                using(SqlDataReader rd = sqlcmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Student student = new Student();
                        student.Id = Convert.ToInt32(rd["Id"]);
                        student.Name = rd["Name"].ToString();
                        student.Address = rd["Address"].ToString();
                        student.PhoneNo = Convert.ToInt64(rd["PhoneNo"]);
                        stdL.Add(student);
                    }
                }
            }
            return stdL;
        }
        public Student GetStudentData(int id)
        {
            Student std=new Student();
            using(SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "Select* from StudentTable WHERE Id= '" + id + "'";
                SqlCommand cm=new SqlCommand(query, con);
                SqlDataReader rdr=cm.ExecuteReader();
                while (rdr.Read())
                {
                    std.Id = Convert.ToInt32(rdr["Id"]);
                    std.Name = Convert.ToString(rdr["Name"]);
                    std.Address = Convert.ToString(rdr["Address"]);
                    std.PhoneNo = Convert.ToInt64(rdr["PhoneNo"]);
                }
                con.Close();
            }
            return std;
        }
        public void UpdateStudent(Student std, int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "Update StudentTable SET Name='" + std.Name + "', Address= '" + std.Address + "', PhoneNo= " + std.PhoneNo+ "Where Id= "+ std.Id;
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void DeleteStudent(Student std, int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "Delete from StudentTable where Id=" + std.Id;
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
