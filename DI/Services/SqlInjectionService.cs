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
            var connectionString = ConfigurationManager.ConnectionStrings["MsSql"].ConnectionString;

            return connectionString;
        }

        #region Union Based

        public string UnionBased(string param)
        {
            string result = "";
            string query = "SELECT * from [dbo].[USER] WHERE NAME = '" + param + "';";

            try
            {
                using (SqlConnection connection = new SqlConnection(
                   GetConnectionString()))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            result += String.Format("Username: {0} Role: {1}", reader["NAME"], reader["ROLE"]);
                        }
                    }
            } catch(Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        public string UnionBasedWithFormatString(string param)
        {
            string result = "";
            string query = String.Format("SELECT * from [dbo].[USER] WHERE NAME = '{0}';", param);

            try
            {
                using (SqlConnection connection = new SqlConnection(
                   GetConnectionString()))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            result += String.Format("Username: {0} Role: {1}", reader["NAME"], reader["ROLE"]);
                        }
                    }
            } catch(Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        public string UnionBasedWithSqlDataAdapter(string param)
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
                    result += String.Format("Username: {0} Role: {1}", row["NAME"], row["ROLE"]);
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        #endregion

        #region Error Based

        public string ErrorBased(string param)
        {
            string result;
            string query = "INSERT INTO [dbo].[PRODUCT] (NAME) VALUES ('" + param + "');";

            try
            {
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

                result = "Product was added";

            } catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        public string ErrorBasedWithFormatString(string param)
        {
            string result;
            string query = String.Format("INSERT INTO [dbo].[PRODUCT] (NAME) VALUES ('{0}');", param);

            try 
            {
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

                result = "Product was added";

            } catch(Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        public string ErrorBasedWithSqlDataAdapter(string param)
        {
            string result;
            string query = "INSERT INTO [dbo].[PRODUCT] (NAME) VALUES ('" + param + "');";

            try 
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetConnectionString());

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    System.Diagnostics.Debug.WriteLine(row["Name"]);
                }

                result = "Product was added";

            } catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        #endregion

        #region Boolean Based

        public string BooleanBased(string param)
        {
            string result = "not found";
            string query = "SELECT * from [dbo].[VULN_NETFRAMEWORK_USER] WHERE NAME = '" + param + "';";

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

        public string BooleanBasedWithSqlDataAdapter(string param)
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

        #endregion

        #region Time Based

        public string TimeBased(string param)
        {
            string query = "INSERT INTO [dbo].[PRODUCT] (NAME) VALUES ('" + param + "');";

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

            return "Done!";
        }

        public string TimeBasedWithFormatString(string param)
        {
            string query = "INSERT INTO [dbo].[PRODUCT] (NAME) VALUES ('" + param + "');";

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

            return "Done!";
        }

        public string TimeBasedWithSqlDataAdapter(string param)
        {
            string query = "INSERT INTO [dbo].[PRODUCT] (NAME) VALUES ('" + param + "');";

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

            return "Done!";
        }

        #endregion
    }
}
