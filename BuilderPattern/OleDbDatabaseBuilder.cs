using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace BuilderPattern
{
    public class OleDbDatabaseBuilder : IDatabaseBuilder
    {
        private Database _database = null;

        public Database Database { get { return _database; } }
        
        public OleDbDatabaseBuilder()
        {
            _database = new OleDatabase();
        }

        public void BuildCommand()
        {
            _database.Command = new OleDbCommand();
            _database.Command.Connection = _database.Connection;
        }

        public void BuildConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ToString();
            _database.Connection = new SqlConnection(connectionString);
        }

        public void SetSettings()
        {
            _database.DatabaseType = "OleDb Baby!";
        }

        
    }
}
