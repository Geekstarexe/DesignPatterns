using System.Data;

namespace FactoryPattern
{
    public interface IDatabase
    {
        IDbCommand Command { get;  }
        IDbConnection Connection { get;  }
        string  Type { get; }
    }
}