using System;
using System.Configuration;
using System.Data;
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

        public string UnionBased(string param)
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
                    result += String.Format("{0} {1}", reader[0], reader[1]);
                }
            }

            return result;
        }

        public string UnionBasedWithFormatString(string param)
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
                    result += String.Format("{0} {1}", reader[0], reader[1]);
                }
            }

            return result;
        }

        public string UnionBasedSqlDataAdapter(string param)
        {
            string result = "";
            string query = "SELECT * from [dbo].[USER] WHERE NAME = '" + param + "';";

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetConnectionString());

                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    result += row["Name"];
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }

            return result;
        }

        public void ErrorBased(string param)
        {
            string query = "SELECT * from [dbo].[USER] WHERE NAME = '" + param + "';";

            using (SqlConnection connection = new SqlConnection(
               GetConnectionString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    System.Diagnostics.Debug.WriteLine(String.Format("{0}", reader[0]));
                }
            }

        }

        public void ErrorBasedWithFormatString(string param)
        {
            string query = String.Format("SELECT * from [dbo].[USER] WHERE NAME = '{0}';", param);

            using (SqlConnection connection = new SqlConnection(
               GetConnectionString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    System.Diagnostics.Debug.WriteLine(String.Format("{0}", reader[0]));
                }
            }

        }

        public void ErrorBasedSqlDataAdapter(string param)
        {
            string query = "SELECT * from [dbo].[USER] WHERE NAME = '" + param + "';";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetConnectionString());

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                System.Diagnostics.Debug.WriteLine(row["Name"]);
            }
        }

        public string BooleanBased(string param)
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

        public string BooleanBasedWithFormatString(string param)
        {
            string result = "not found";
            string query = String.Format("SELECT * from [dbo].[USER] WHERE NAME = '{0}';", param);

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

        public string BooleanBasedSqlDataAdapter(string param)
        {
            string result = "not found";
            string query = "SELECT * from [dbo].[USER] WHERE NAME = '" + param + "';";

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetConnectionString());

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    result = "found";
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }

            return result;
        }

        public void TimeBased(string param)
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

        public void TimeBasedWithFormatString(string param)
        {
            string query = String.Format("SELECT * from [dbo].[USER] WHERE NAME = '{0}';", param);

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

        public void TimeBasedSqlDataAdapter(string param)
        {
            string query = "SELECT * from [dbo].[USER] WHERE NAME = '" + param + "';";

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetConnectionString());

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    System.Diagnostics.Debug.WriteLine(row["Name"]);
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
    }
}
