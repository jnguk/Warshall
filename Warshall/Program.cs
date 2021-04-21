using System;

namespace Warshall
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = Warshall.DoWarshall(new bool[,] {
                { true, false, false, true, false },
                { false, true, false, false, false },
                { false, false, false, true, true },
                { true, false, false, false, false },
                { false, true, false, false, true }

            });

            Warshall.Print2DBoolArr(temp);
        }
    }
}
