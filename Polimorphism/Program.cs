

using System.Runtime.InteropServices;

namespace Polimorphism
{

    class Car
    {

        private void StartEngine()
        {
            Console.WriteLine("Engine started!");
        }
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("I'm car!");
        }
    }

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    class SportCar:Car
    {
        public override void Drive()
        {
            base.Drive();
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person();

            person.Drive(new SportCar());
        }
    }
}
