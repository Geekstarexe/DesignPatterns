namespace FactoryPattern
{
    class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType databaseType)
        {
            switch (databaseType)
            {
                //This is where you could use a builder if you had a more complicated object
                case DatabaseType.OleDb:
                    return new OleDbDatabase();
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase();
                default:
                    return  new SqlServerDatabase();
            }
        }
    }
}