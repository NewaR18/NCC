using System;
using System.Data.SqlClient;
using System.Text;
namespace tryADO
{
    class Deleting
    {
        static void Delete()
        {
            SqlConnection conn = null;
            try
            {
                string ConnectionString = "data source=NEWAR-PC; database=Sudip; integrated security=SSPI";
                conn = new SqlConnection(ConnectionString);
                string query = "Delete from FIrstTable where Id=12";
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                int n = sqlcmd.ExecuteNonQuery();
                Console.WriteLine(n + " Deleted Successfully");
                Console.WriteLine("\n--------------------------");
                Console.WriteLine("Lab no: 21");
                Console.WriteLine("Name: Sudip Shrestha");
                Console.WriteLine("Roll No./Section : 20/A");
                Console.WriteLine("--------------------------");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        static void Main(string[] args)
        {
            Delete();
        }
    }
}