using System;
using System.Data.SqlClient;
using System.Text;
namespace tryADO
{
    class Inserting
    {
        static void ConnectAndInser()
        {
            SqlConnection conn = null;
            try
            {
                string ConnectionString = "data source=NEWAR-PC; database=Sudip; integrated security=SSPI";
                conn = new SqlConnection(ConnectionString);
                string query = "Select* from FIrstTable";
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                SqlDataReader sdr = sqlcmd.ExecuteReader();
                Console.WriteLine("Id \t\t\t Name \t\t\t Address \t\t\t Phone number");
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["Id"] + "\t\t\t" + sdr["Name"] + "\t\t\t" + sdr["Address"] + "\t\t\t " + sdr["Phone No"]);
                }
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
            ConnectAndInser();
        }
    }
}