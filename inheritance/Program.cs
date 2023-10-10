namespace inheritance
{

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"My Name is: {FirstName}");
        }

    }


    class Student: Person
    {
        public void Learn()
        {
            Console.WriteLine("I'm learning!");
        }
    
    }


    class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Key",
                LastName = "Value"
            };
            person.PrintName();
            Student student = new Student();
            student.Learn();
        }
    }


}
