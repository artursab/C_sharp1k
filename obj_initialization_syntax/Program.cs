

namespace obj
{

    class Cat
    {

        public int Age { get; set; }
        public string Name { get; set; }

        public Cat()
            {

            }

        public Cat(string name)
        {
            Name = name;
        }
}


    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Age = 1;
            cat1.Name = "Kot";

            Cat cat2 = new Cat
            {
                Age = 1,
                Name = "Yar"
            };
        }
    }
}
