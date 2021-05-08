using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace WebApp.Models
{
    public class SqlQueries
    {

        public void OldEncryption()
        {
            using (TripleDES encAlg = TripleDES.Create())
            {
                encAlg.CreateEncryptor();
            }
        }

        public void ExampleMethod(Random random)
        {
            var sensitiveVariable = random.Next();
        }

        public object UnsafeQuery(
           string connection, string name, string password)
        {
            SqlConnection someConnection = new SqlConnection(connection);
            SqlCommand someCommand = new SqlCommand();
            someCommand.Connection = someConnection;

            someCommand.CommandText = "SELECT AccountNumber FROM Users " +
               "WHERE Username='" + name +
               "' AND Password='" + password + "'";

            someConnection.Open();
            object accountNumber = someCommand.ExecuteScalar();
            someConnection.Close();
            return accountNumber;
        }

        public object SaferQuery(
           string connection, string name, string password)
        {
            SqlConnection someConnection = new SqlConnection(connection);
            SqlCommand someCommand = new SqlCommand();
            someCommand.Connection = someConnection;

            someCommand.Parameters.Add(
               "@username", SqlDbType.NChar).Value = name;
            someCommand.Parameters.Add(
               "@password", SqlDbType.NChar).Value = password;
            someCommand.CommandText = "SELECT AccountNumber FROM Users " +
               "WHERE Username=@username AND Password=@password";

            someConnection.Open();
            object accountNumber = someCommand.ExecuteScalar();
            someConnection.Close();
            return accountNumber;
        }
    }
}
