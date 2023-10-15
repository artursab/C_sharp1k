
namespace Generics
{


    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            
            Console.WriteLine($"a = {a}\t b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a}\t b = {b}");
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b; 
            b = temp;
        }
    }
}
