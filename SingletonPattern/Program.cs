using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Patters - Creation Pattern - , most widely used");
            Console.WriteLine("");
            Console.WriteLine("Used for a single instance of an object throughout the application");
            Console.WriteLine("If you needed to code accessing one computer port, plug, logging method");
            Console.WriteLine("we do this using a private static member with a private constructor");


            //in theory these could be two forms or errors happeing on different pages coming from different users
            try
            {
                throw  new Exception("We did something bad here");
            }
            catch (Exception ex)
            {
                ExceptionHandler.Instance.WriteExceptionLog(ex);
            }



            try
            {
              throw new Exception("We did something else bad here");
            }
            catch (Exception ex)
            {
                ExceptionHandler.Instance.WriteExceptionLog(ex);
            }

            Console.WriteLine("It is done");
            System.Threading.Thread.Sleep(5000);
        }
    }
}
