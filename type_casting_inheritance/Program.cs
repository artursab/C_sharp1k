
using System.Xml.Serialization;

namespace type_casting_inheritance
{

    class A
    {
        public int publicFiled;
        private int privateFiled;
        protected int protectedFiled;


        protected int MyProperty { get; set; }

        public A() 
        {
            Console.WriteLine(publicFiled);
            Console.WriteLine(privateFiled);
            Console.WriteLine(protectedFiled);
        }

        public void Foo()
        {
            Console.WriteLine(publicFiled);
            Console.WriteLine(privateFiled);
            Console.WriteLine(protectedFiled);
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine(publicFiled);
            //Console.WriteLine(privateFiled);
            Console.WriteLine(protectedFiled);
        }
    }


        class Program
        {

            static void Main(string[] args)
            {
                A a = new A();

            Console.WriteLine(a.publicFiled);
            //Console.WriteLine(a.privateFiled);
            //Console.WriteLine(a.protectedFiled);
            }
        }
    
}

