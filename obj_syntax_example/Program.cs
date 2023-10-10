

namespace obj_syntax_example
{






    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person
            {
                FirstName = "TestFirst",
                LastName = "TestLast",
                Address = new Address
                {
                    Country = "USA",
                    Region = "Dalas",
                    City = "NewYork",
                }
            };


        }
    }
}
