using System.Security.Principal;

namespace Inheritance_example
{
    class Program
    {

        static void Main(string[] args)
        {
            Teacher teacher = new Teacher { FirstName = "Martin", LastName = "Dagda"};
            Student student = new Student { FirstName = "Marta", LastName = "Adga"};
            Person[] people = {teacher, student};

            PrintPersons(people);
        }

        static void PrintPersons(Person[] people)
        {
            foreach (var person in people)
            {
                person.PrintFullName();
            }
        }
    }
}