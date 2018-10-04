using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.LoggerLibrary.Common
{
    public static class Logger
    {
        /// <summary>
        /// Logs errors on txt file by displaying the method name, exception and stack trace
        /// </summary>
        /// <param name="MethodName">Method name</param>
        /// <param name="Exception">Exception fired</param>
        /// <param name="StackTrace">Stack trace</param>
        public static void Log(string MethodName, string Exception, string StackTrace)
        {
            string fileName, fullPath, log;
            try
            {
                fileName = string.Format("LOGS_{0}_{1}_{2}.txt", DateTime.Today.Month.ToString("00"), DateTime.Today.Day.ToString("00"), DateTime.Today.Year);
                fullPath = Path.Combine(ConstantValues._LogFilePath, fileName);

                //Manually create the directories if path or part of the path does not exist
                if (!Directory.Exists(ConstantValues._LogFilePath))
                    Directory.CreateDirectory(ConstantValues._LogFilePath);

                //Automatically create the file if does not exist and write/append log to it
                using (StreamWriter file = new StreamWriter(fullPath, true))
                {
                    log = string.Format(@"At {0}  Method: {1} - Exception: {2} - Stack Trace: {3}.", DateTime.Now.ToString(@"HH:mm"), MethodName, Exception, StackTrace);
                    file.WriteLine(log);
                    file.WriteLine();
                }
            }
            catch (Exception)
            { throw; }
        }

        /// <summary>
        /// Gets the current method name
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentMethod()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(1);
            return stackFrame.GetMethod().Name;
        }

        /// <summary>
        /// Gets the current asynchronous method name
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentAsyncMethod([CallerMemberName]string name = "")
        {
            return name;
        }

    }
}
