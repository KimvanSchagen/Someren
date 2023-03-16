using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            SqlConnection dbConnection;

            string connString = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;

            dbConnection = new SqlConnection(connString);

            dbConnection.Open();
            dbConnection.Close();
          


        }
    }
}