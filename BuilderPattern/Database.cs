using System.Data.Common;

namespace BuilderPattern
{
    public abstract class Database
    {
        public virtual DbConnection Connection { get; set; }
        public virtual DbCommand Command { get; set; }
        public virtual string DatabaseType { get; set; }
    }
}