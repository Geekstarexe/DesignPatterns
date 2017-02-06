using System.Configuration;
using System.Data.SqlClient;

namespace BuilderPattern
{
    public class SqlServerDatabaseBuilder : IDatabaseBuilder
    {
        private Database _database = null;

        public Database Database { get { return _database; } }

        public SqlServerDatabaseBuilder()
        {
            _database = new SqlServer();
        }

        public void BuildCommand()
        {
            _database.Command = new SqlCommand();
            _database.Command.Connection = _database.Connection;
        }

        public void BuildConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ToString();
            _database.Connection = new SqlConnection(connectionString);
        }

        public void SetSettings()
        {
            _database.DatabaseType = "M$ Sql Server";
        }
    }
}
