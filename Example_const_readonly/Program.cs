
namespace Example
{

    class MyLogger
    {
        public void Info(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|INFO|\t{message}");
        }

        public void Error(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|ERROR|\t{message}");
        }

        public void warn(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|WARN|\t{message}");
        }

    }



    class Car
    {
        private const string ENGINE_IS_STARTED_MESSAGE = "ENGINE IS STARTED!";
        private const string ATTEMPT_TO_START_MESSAGE = "ENGINE ATTEMPT TO START!";
        private const string ENGINE_HAS_ALREADY_STARTED_MESSAGE = "ENGINE HAS ALREADY STARTED!";
        private const string ATTEMPT_TO_DRIVE_MESSAGE = "ATTEMPT TO DRIVE!";
        private const string DRIVE_MESSAGE = "MEN'S DRIVE!";
        private const string DRIVE_ERROR_MESSAGE = "BRO, START ENGINE!";

        private readonly MyLogger _myLogger;

        private bool isEngineStarted;

        public Car(MyLogger myLogger)
        {
            _myLogger = myLogger;
        }



        public void StartEngine()
        {
            _myLogger.Info(ATTEMPT_TO_START_MESSAGE);
                if (isEngineStarted)
                {
                _myLogger.warn(ENGINE_HAS_ALREADY_STARTED_MESSAGE);
                }
            else
            {
                isEngineStarted = true;
                _myLogger.Info(ENGINE_IS_STARTED_MESSAGE);
            }
        }

        public void Drive()
        {
            _myLogger.Info(ATTEMPT_TO_DRIVE_MESSAGE);
            if (isEngineStarted)
            {
                _myLogger.Info(DRIVE_MESSAGE);
            }
            else 
                _myLogger.Error(DRIVE_ERROR_MESSAGE);
        }

    }




    class Program
    {

        static void Main(string[] args)
        {
            Car car = new Car(new MyLogger());
            car.Drive();
            car.StartEngine();
            car.StartEngine();
            car.Drive();
        }
    }
}