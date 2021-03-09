using SeleniumFramework.Configuration;
using System;
using System.IO;

namespace SeleniumFramework.Helpers
{
    public class LogHelpers
    {

        // Global Declaration
        private static string logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);

        private static StreamWriter streamWriter = null;


        public static void CreateLogFile()
        {
            string dir = Settings.LogPath;
            if (Directory.Exists(dir))
            {
                streamWriter = File.AppendText(dir + logFileName + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                streamWriter = File.AppendText(dir + logFileName + ".log");
            }
            
        }

        /// <summary>
        /// To write the log message into the file
        /// </summary>
        /// <param name="logMessage"></param>
        public static void WriteLog(string logMessage)
        {
            streamWriter.Write("{0}{1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            streamWriter.WriteLine(logMessage);
            streamWriter.Flush();
        }



    }
}
