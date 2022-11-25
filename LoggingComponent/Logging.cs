using System.Diagnostics;
namespace LoggingComponent;
public class Logging
{
          [Obsolete("Pls make use of the log to file method")]
          public static void LogToScreen(string message)
          {
                    System.Console.WriteLine(message);
          }
          public static void LogToFile(string message)
          {
                    System.Console.WriteLine($"logging to file.........{message}");
          }
}
