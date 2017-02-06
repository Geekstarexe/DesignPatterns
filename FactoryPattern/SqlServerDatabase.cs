using System.Data;
using System.Data.SqlClient;

namespace FactoryPattern
{
    public class SqlServerDatabase : IDatabase
    {
        private SqlConnection _connection = null;
        private SqlCommand _command = null;
    
        public IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    //get the connection from the db   
                    _connection = new SqlConnection();
                }
                return _connection;
            }
        }

        public IDbCommand Command
        {
            get
            {
                if (_command == null)
                {
                    _command.Connection = _connection;
                    _command = new SqlCommand();

                }
                return _command;

            }
        }

        public string Type
        {
            get { return "Sql Server"; }
        }

    }
}