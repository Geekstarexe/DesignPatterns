using System.Data.Common;

namespace BuilderPattern
{
    public class OleDatabase : Database
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;  

        public override string DatabaseType { get; set; }

        public override DbCommand Command { get; set; }

        public override DbConnection Connection { get; set; }
    }
}