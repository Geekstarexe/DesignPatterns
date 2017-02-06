using System;
using System.IO;
using System.Text;

namespace SingletonPattern
{
    public class ExceptionHandler
    {
        private static ExceptionHandler _instance;
        private static readonly object _lock = new object();
        private StreamWriter _streamWriter;

        //you create and instance of this class be calling the "Instance" method
        public static ExceptionHandler Instance
        {
            get
            {
                //lock makes it thread safe
                lock (_lock)
                {
                    //lazy loading
                    if (_instance == null)
                    {
                        _instance = new ExceptionHandler();
                    }
                }

                return _instance;
            }
        }

        // you can not create an instance of the class externally
        private ExceptionHandler()
        {
            string execPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _streamWriter = new StreamWriter(Path.Combine(execPath, "PrototypeErrorLog.txt"));//logname should be incofig file
        }

        public void WriteExceptionLog(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"));
            sb.Append(": ");
            sb.Append(ex.Message);
            _streamWriter.WriteLine(sb.ToString());
            _streamWriter.Flush();
        }

    }
}