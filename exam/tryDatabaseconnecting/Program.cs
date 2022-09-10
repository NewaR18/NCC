using System;
using System.Data.SqlClient;
using System.Text;
namespace tryADO
{
    class Inserting
    {
        static void Insert()
        {
            SqlConnection conn = null;
            try
            {
                string ConnectionString = "data source=NEWAR-PC; database=Sudip; integrated security=SSPI";
                conn = new SqlConnection(ConnectionString);
                int id = 1;
                string name = "Sudip Shrestha";
                string address = "Kathmandu";
                long phone = 9861141726;
                string query = "Insert into FIrstTable VALUES(" + id + ",'" + name + "','" + address + "'," + phone + ")";
                SqlCommand sqlcmd=new SqlCommand(query, conn);
                conn.Open();
                int n=sqlcmd.ExecuteNonQuery();
                Console.WriteLine(n + " Inserted Successfully");
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
            Insert();
        }
    }
}