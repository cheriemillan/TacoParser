using System;
namespace LoggingKata
{
    public interface ILog
    {
        // Logs a fatal error with an optional exception
        void LogFatal(string log, Exception exception = null);
        
        // Logs an error with an optional exception
        void LogError(string log, Exception exception = null);
        
        // Logs a warning message
        void LogWarning(string log);
        
        // Logs an informational message
        void LogInfo(string log);
        
        // Logs a debug message
        void LogDebug(string log);
    }
}
