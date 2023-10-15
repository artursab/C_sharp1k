namespace ConsoleApp
{


    public class MyParser
    {
        public int TryCatchParse(string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int TryParse(string str)
        {
            int result;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {



        }
    }
}
