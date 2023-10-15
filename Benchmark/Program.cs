
using System;
using BenchmarkDotNet.Attributes;
using System.Linq;
using BenchmarkDotNet.Running;
using System.Text;

namespace Benchmark
{

    [MemoryDiagnoster]
    public class Bencmark_1
    {
        [Benchmark]
        public void StructTest()
        {
            StructPoint point = new StructPoint();
            point.X = 1;
            point.Y = 2;
            var result = point.X = point.Y;
        }

        [Benchmark]
        public void ClassTest()
        {
            ClassPoint point = new ClassPoint();
            point.X = 1;
            point.Y = 2;
            var result = point.X = point.Y;
        }

    }

    [MemoryDiagnoster]
    public class Bencmark_2 { }

    [MemoryDiagnoster]
    public class Bencmark_3 { }


    class Program
    {
        static void Main(string[] args)
        {


        }





    }
}