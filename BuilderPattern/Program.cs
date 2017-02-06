using System;

namespace BuilderPattern
{

    /*
     * The builder pattern is used when you have difficult or complex objects to instantiate because of lots of setting or sub objects you have to create
     * the builder pattern can use the abstract pattern to help hydrate the objects by creating builder interfaces or abstract classes
     * Unlike the abstract patter the classes that inherit from the abstract class don't have an logic in them they are place holders
     * director classes use builder classes to create the objects and hides creation details from the rest of the application
     * builder classes hold the logic to populate the abstract derived classes. These normally have set of methods that are ment to be call seqentially
     * director classes usually have some method called "Build" to create the object
     * the build metod called the methods in the build class in the correct order to hydrate the object. 
     */

    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Builder Patterns - Creation Pattern");

            Director director = new Director();
            IDatabaseBuilder builder;

            string command = null;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "ole")
                {
                    builder = new OleDbDatabaseBuilder();
                }
                else
                {
                    builder = new SqlServerDatabaseBuilder();
                }
                
                director.Build(builder);
                Database db = builder.Database;
                
                Console.WriteLine(db.DatabaseType);
            }


        }
    }
}
