using System;
using System.Configuration;
using System.Data.SqlClient;
namespace DI.Services
{
    public class SqlInjectionService : ISqlInjectionService
    {
        private string GetConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SqlExpress"].ConnectionString;

            return connectionString;
        }

        public string Classic(string param)
        {
            string result = "";
            string query = "SELECT * from [dbo].[USER] WHERE NAME = '" + param + "';";

            using (SqlConnection connection = new SqlConnection(
               GetConnectionString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result += String.Format("{0}", reader[0]);
                }
            }

            return result;
        }

        public string ClassicWithFormatString(string param)
        {
            string result = "";
            string query = String.Format("SELECT * from [dbo].[USER] WHERE NAME = '{0}';", param);

            using (SqlConnection connection = new SqlConnection(
               GetConnectionString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result += String.Format("{0}", reader[0]);
                }
            }

            return result;
        }

        public string Blind(string param)
        {
            string result = "not found";
            string query = "SELECT * from [dbo].[USER] WHERE NAME = '" + param + "';";

            using (SqlConnection connection = new SqlConnection(
               GetConnectionString()))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        result = "found";
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }

            return result;
        }

        public void BlindSecond(string param)
        {
            string query = "SELECT * from [dbo].[USER] WHERE NAME = '" + param + "';";

            using (SqlConnection connection = new SqlConnection(
               GetConnectionString()))
            {
                try 
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        System.Diagnostics.Debug.WriteLine(String.Format("{0}", reader[0]));
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
    }
}
