namespace Interface_and_polimorph
{

    interface IDataProvider
    {
        string GetData();
    }

    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }

    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class FileDataProvider : IDataProvider 
    {
        public string GetData()
        {
            return "Data from files";
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from db";
        }
    }

    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from api";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());
        }
    }
}