using System;
using System.Data.SqlClient;
using System.Text;
namespace tauke
{
    public class ghantauke
    {
        static void TaukeInsert()
        {
            SqlConnection conn = null;
            try
            {
                string ConStr = "data source=NEWAR-PC ; database= Sudip ; Integrated security= SSPI ";
                conn = new SqlConnection(ConStr);
                string query = "select* from FIrstTable";
                SqlCommand sql = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader= sql.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]+"/t/t/t"+reader[1]+"/t/t/t"+reader[2]+"/t/t/t"+reader[3]);
                }
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
        public static void Main(string[] args)
        {
            TaukeInsert();
        }
    }
}