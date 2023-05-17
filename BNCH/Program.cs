using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace benchmark
{


    public class SortsBenchmark
    {
        private SortA sortA = new SortA();
        private const int ArraySize = 10000;
        private int[] Array;

        public SortsBenchmark()
        {
            Random rand = new Random();
            Array = new int[ArraySize];

            for (int i = 0; i < ArraySize; i++)
            {
                Array[i] = rand.Next();
            }
        }

        [Benchmark]
        public void BubbleSort()
        {
            sortA.BubbleSort(Array);
        }

        [Benchmark]
        public void QuickSort()
        {
            sortA.QuickSort(Array, 0, ArraySize - 1);
        }

        [Benchmark]
        public void InsertionSort()
        {
            sortA.InsertionSort(Array);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<SortsBenchmark>();
        }
    }
}

