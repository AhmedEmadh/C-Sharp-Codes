using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the source name for the event log
            string sourceName = "LoggingExampleApp";


            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
                Console.WriteLine("Event source created.");
            }


            // Log an information event
            EventLog.WriteEntry(sourceName, "This is an information event.", EventLogEntryType.Information);
            // Log a warning event
            EventLog.WriteEntry(sourceName, "This is a warning event.", EventLogEntryType.Warning);
            // Log an error event
            EventLog.WriteEntry(sourceName, "This is an error event.", EventLogEntryType.Error);

            Console.WriteLine("Event written to the log.");
        }
    }
}
