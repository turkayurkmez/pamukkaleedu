using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
   public class DbHelper : IDisposable
    {
        private SqlConnection sqlConnection = null;
        public DbHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int ExecuteCommand(string commandText, Dictionary<string,object> parameters)
        {
            SqlCommand command = CreateCommand(commandText, parameters);
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

        private SqlCommand CreateCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            AddParametersToCommand(sqlCommand, parameters);
            return sqlCommand;
        }

        private void AddParametersToCommand(SqlCommand sqlCommand, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
        }

        public void Dispose()
        {
            sqlConnection.Dispose();
        }
    }
}
