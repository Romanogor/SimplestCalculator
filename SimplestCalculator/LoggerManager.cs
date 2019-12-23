using System;
using System.IO;

namespace SimplestCalculator
{
    public class LoggerManager : ILoggerManager
    {
        //public void LogMessage(string message)
        //{
        //    //TODO: add impflementation to write message in class
        //    Console.WriteLine("Logger message:" + message);
        //}

        public void LogMessage(string message)
        {
            //TODO: add impflementation to write message in class
            //Console.WriteLine("Logger message:" + message);

            using (StreamWriter writer = new StreamWriter("Log.txt", true))
            {
                //writer.Write("Word ");
                writer.WriteLine("Logger message: ");
                writer.WriteLine(message);
            }
        }
    }
}
