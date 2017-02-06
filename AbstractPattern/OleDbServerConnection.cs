using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace AbstractPattern
{
    public class OleDbServerConnection : Database
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;

        public override string DatabaseType
        {
            get { return "OleDb"; }
        }

        public override DbCommand Command
        {
            get
            {
                if (_command == null)
                {
                    _command = new SqlCommand();
                    _command.Connection = Connection;
                }
                return _command;
            }
            set
            {
                _command = value;
            }
        }


        public override DbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ToString();
                    _connection = new SqlConnection(connectionString);
                }
                return _connection;
            }
            set { _connection = value; }
        }
    }
}