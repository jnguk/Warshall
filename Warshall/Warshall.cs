using System;
using System.Text;

namespace Warshall
{
    public static class Warshall
    {
        public static bool[,] DoWarshall(bool[,] m)
        {
            var n = m.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        m[i, j] = m[i, j] || (m[i, k] && m[k, j]);
                    }
                }
            }

            return m;
        }

        public static void Print2DBoolArr(bool[,] arr)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sb.Append(arr[i, j] ? "1" : "0").Append(' ');
                }

                sb.Append('\n');
            }

            Console.WriteLine(sb);
        }
    }
}
