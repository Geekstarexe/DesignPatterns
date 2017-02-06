using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Factory Pattern - Creation Pattern");

            IDatabase database;
            DatabaseType databaseType;

            string command = null;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "ole")
                {
                    databaseType = DatabaseType.OleDb;
                }
                else
                {
                    databaseType = DatabaseType.SqlServer;
                }

                database = DatabaseFactory.CreateDatabase(databaseType);
                Console.WriteLine(database.Type);
            }

        }
    }
}
