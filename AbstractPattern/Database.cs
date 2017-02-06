using System.Data.Common;

namespace AbstractPattern
{
    public abstract class Database
    {
        public virtual DbConnection Connection { get; set; }
        public virtual DbCommand Command { get; set; }
        public virtual string DatabaseType { get; set; }
    }
}