using NLog;
using Oracle.ManagedDataAccess;
namespace Kway.Monitor
{
    /// <summary>
    /// NLog Test
    /// </summary>
    class Program
    { 
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Press <Enter> to exit... \r\n");
                Console.WriteLine($" {DateTime.Now.ToString("HH:mm:ss.fff")}  System is Starting!");
                logger.Trace("BAP Starting");
                //logger.Info("XBOS2 BAP System is Starting!");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                logger.Info("System is End!");
            }
            catch (Exception ex)
            { 
                logger.Error(ex.ToString());
            }

        }
    }
}
