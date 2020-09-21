using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLogger
{
    /// <summary>
    /// ILog Interface For NLogger Implementation.
    /// </summary>
    public interface ILog
    {
        /// <summary>
        /// Abstract Function For Logging Information.
        /// </summary>
        /// <param name="message"></param>
        void Information(string message);

        /// <summary>
        /// Abstract Function For Logging Warning.
        /// </summary>
        /// <param name="message"></param>
        void Warning(string message);

        /// <summary>
        /// Abstract Function For Logging Debug.
        /// </summary>
        /// <param name="message"></param>
        void Debug(string message);

        /// <summary>
        /// Abstract Function For Logging.
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);
    }
}
