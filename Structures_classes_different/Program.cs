﻿namespace Structures_classes_different
{

    public class ClassPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X: {X}\t Y: {Y}");
        }

    }

    public struct StructPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X: {X}\t Y: {Y}");
        }
    }


    class Program
    {
        static void Foo(ClassPoint point)
        {

        }

        static void Bar(ClassPoint point)
        {

        }
        static void Main(string[] args)
        {

            ClassPoint classPoint;
            StructPoint structPoint;
        }
    }
}
