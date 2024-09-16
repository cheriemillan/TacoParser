using System;

namespace LoggingKata
{
    // The TacoLogger class implements the ILog interface.
    // This class provides different levels of logging: Fatal, Error, Warning, Info, and Debug.
    public class TacoLogger : ILog
    {
        // Logs a fatal error message along with an optional exception.
        public void LogFatal(string log, Exception exception = null)
        {
            // Output the fatal log message and exception details to the console.
            Console.WriteLine($"Fatal: {log}, Exception {exception}");
        }
        
        // Logs an error message along with an optional exception.
        public void LogError(string log, Exception exception = null)
        {
            // Output the error log message and exception details to the console.
            Console.WriteLine($"Error: {log}, Exception {exception}");
        }

        // Logs a warning message.
        public void LogWarning(string log)
        {
            // Output the warning log message to the console.
            Console.WriteLine($"Warning: {log}");
        }

        // Logs an informational message.
        public void LogInfo(string log)
        {
            // Output the informational log message to the console.
            Console.WriteLine($"Info: {log}");
        }

        // Logs a debug message.
        public void LogDebug(string log)
        {
            // Output the debug log message to the console.
            Console.WriteLine($"Debug: {log}");
        }
    }
}
