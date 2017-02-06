using System.Data;
using System.Data.OleDb;

namespace FactoryPattern
{
    public class OleDbDatabase : IDatabase
    {
        private OleDbConnection _connection;
        private OleDbCommand _command;

        public IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    //set _connection
                    _connection = new OleDbConnection();
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
                    _command = new OleDbCommand();
                }
                return _command;
            }
        }

        public string Type
        {
            get { return "OleDB"; }
        }

    }
}