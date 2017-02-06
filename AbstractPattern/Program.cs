using System;

namespace AbstractPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory Pattern - Creation Pattern");
            string command = null;
            Database db = null;

            /*
             * The Abstract pattern allows you to hide implimentation details by creating one generic abstract class that is implimented by other classes. 
             * in list case Database is our abstract class that bot Ole and Sql classes are derived from. 
             */


            while (true)
            {
                command = Console.ReadLine();
                if (command == "ole")
                    db = new OleDbServerConnection();

                if (command == "sql")
                    db = new SqlServerConnection();

                Console.WriteLine(db.DatabaseType);
            }
            

            
        }
    }
}