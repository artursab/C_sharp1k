namespace explicit_implement_interface
{

    interface IFirstInterface
    {
        void Action();
    }

    interface ISecondInterface
    {
        void Action();
    }

    class MyClass : IFirstInterface, ISecondInterface
    {
        public void Action()
        {
            Console.WriteLine("MyClass action...");
        }
    }

    class MyOtherClass : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Action()
        {
            Console.WriteLine("MyOtherClass IFristInterface.Action");
        }

        void ISecondInterface.Action()
        {
            Console.WriteLine("MyOtherClass ISecondInterface.Action");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Foo(myClass);
            Bar(myClass);

            MyOtherClass myOtherClass = new MyOtherClass();
            Foo(myOtherClass); 
            Bar(myOtherClass);

        }

        static void Foo(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }

        static void Bar(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
    }
}