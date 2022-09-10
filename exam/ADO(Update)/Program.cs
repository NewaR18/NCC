using System;
using System.Data.SqlClient;
using System.Text;
namespace tryADO
{
    class Updating
    {
        static void Update()
        {
            SqlConnection conn = null;
            try
            {
                string ConnectionString = "data source=NEWAR-PC; database=Sudip; integrated security=SSPI";
                conn = new SqlConnection(ConnectionString);
                string query = "Update FIrstTable set Address='Kathmandu' where Id=12";
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                int n = sqlcmd.ExecuteNonQuery();
                Console.WriteLine(n + " Updated Successfully");
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
            Update();
        }
    }
}