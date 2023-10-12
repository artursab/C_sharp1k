namespace default_interface_implemention
{


    class Program
    {

        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();

            logger.Log(LogLevel.Debug, "some event");
            logger.Log(LogLevel.Warning, "some warning");
            logger.Log(LogLevel.Fatal, "some error");
        }
    }
}
