using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLogger
{
    /// <summary>
    /// Class For ILog Interface Implementation.
    /// </summary>
    public class LogNLog : ILog
    {
        /// <summary>
        /// Setting Up ILogger Using NLog. 
        /// </summary>
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Empty Class Constructor.
        /// </summary>
        public LogNLog()
        {

        }

        /// <summary>
        /// Function For Logging Debug.
        /// </summary>
        /// <param name="message"></param>
        public void Debug(string message)
        {
            logger.Debug(message);
        }

        /// <summary>
        /// Function For Logging Debug.
        /// </summary>
        /// <param name="message"></param>
        public void Error(string message)
        {
            logger.Error(message);
        }

        /// <summary>
        /// Function For Logging Information.
        /// </summary>
        /// <param name="message"></param>
        public void Information(string message)
        {
            logger.Info(message);
        }

        /// <summary>
        /// Function For Logging Warning.
        /// </summary>
        /// <param name="message"></param>
        public void Warning(string message)
        {
            logger.Warn(message);
        }
    }
}
