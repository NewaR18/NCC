using DemoWebApp.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DemoWebApp.Repository
{
    public class EmployeeRepo
    {
        string conStr = ConfigurationBinder.GetConnectionString("MyConnection");
        public void AddEmployee(Employee emp)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string insertQuery = $"INSERT INTO Table_1 VALUES(" + $"{ emp.EmpId},'{emp.Name}','{emp.Department}','{emp.Address}','{emp.Salary}')";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            List<Employee> emplist = new List<Employee>();
            using (SqlConnection con =new SqlConnection(conStr))
            {
                con.Open();
                string querry = "'Select * From employyes WHERE EmpID='"+id +"'";
                SqlCommand cmd = new SqlCommand(sqlQuerry, con);
                con.Open();
                SqlDataAdapter rdr = cm.ExecuteReader();
                while (rdr.Read())
                {
                    emp.ID = Convert.ToInt32(rdr["EmpID"]);
                    emp.Name = rdr["Name"].ToString();
                    emp.Address = rdr["Address"].ToString();
                    emp.Department = Convert.ToInt64(rdr["Department"]);
                }
                con.Close();
            }
            return emp;
        }
        public void UpdateEmployee(Employee emp,int id)
        {
            using (SqlConnection con=new SqlConnection(conStr))
            {
                string updateQuery = $"Update employee SET Name='{emp.Name}',Address='{emp.Address}',Department='{emp.Department}' where EmpID='{id}'";
                using (SqlCommand cmd= new SqlCommand(updateQuery, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public void DeleteEmployee(Employee emp,int id)
        {
            using(SqlConnection con=new SqlConnection(conStr))
            {
                string updateQuery = $"DELETE FROM employees WHERE EmpID='{id}'";
                using (SqlCommand cmd=new SqlCommand(updateQuery, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}