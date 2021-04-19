using System;
using System.Collections.Generic;

namespace Codewars.Solution._4kyu
{
    public class PathFinder1
    {
        public static bool PathFinder(string maze)
        {
            var arrLen = (int)Math.Sqrt(maze.Length);
            var array = GetArray(maze, arrLen);
            var coloredArray = new bool[arrLen, arrLen];
            var queue = new Queue<Tuple<int, int, char>>();

            queue.Enqueue(new Tuple<int, int, char>(0, 0, array[0, 0]));

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                if (node.Item1 == arrLen - 1 && node.Item2 == arrLen - 1)
                {
                    return true;
                }
                else if (node.Item1 < arrLen && node.Item2 < arrLen && !coloredArray[node.Item1, node.Item2] && node.Item3 == '.')
                {
                    coloredArray[node.Item1, node.Item2] = true;

                    foreach (var neighbor in GetNeighbors(node.Item1, node.Item2, arrLen, array))
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }
            return false;
        }

        private static char[,] GetArray(string maze, int arrLength)
        {
            var arr = new char[arrLength, arrLength];

            for (var i = 0; i < arrLength; i++)
            {
                for (var j = 0; j < arrLength; j++)
                {
                    arr[i, j] = maze.Substring(i + (arrLength * i), arrLength)[j];
                }
            }

            return arr;
        }

        private static IEnumerable<Tuple<int, int, char>> GetNeighbors(int x, int y, int arrLen, char[,] array)
        {
            if (y == 0)
            {
                if (x == 0)
                {
                    yield return new Tuple<int, int, char>(1, 0, array[1, 0]);
                    yield return new Tuple<int, int, char>(0, 1, array[0, 1]);
                }
                if (x > 0 && x < arrLen - 1)
                {
                    yield return new Tuple<int, int, char>(x - 1, 0, array[x - 1, 0]);
                    yield return new Tuple<int, int, char>(x, y + 1, array[x, y + 1]);
                    yield return new Tuple<int, int, char>(x + 1, 0, array[x + 1, 0]);
                }
                if (x == arrLen - 1)
                {
                    yield return new Tuple<int, int, char>(x - 1, 0, array[x - 1, 0]);
                    yield return new Tuple<int, int, char>(x, y + 1, array[x, y + 1]);
                }
            }
            if (y > 0 && y < arrLen - 1)
            {
                if (x == 0)
                {
                    yield return new Tuple<int, int, char>(0, y + 1, array[0, y + 1]);
                    yield return new Tuple<int, int, char>(1, y, array[1, y]);
                    yield return new Tuple<int, int, char>(0, y - 1, array[0, y - 1]);
                }
                if (x > 0 && x < arrLen - 1)
                {
                    yield return new Tuple<int, int, char>(x - 1, y, array[x - 1, y]);
                    yield return new Tuple<int, int, char>(x, y + 1, array[x, y + 1]);
                    yield return new Tuple<int, int, char>(x + 1, y, array[x + 1, y]);
                    yield return new Tuple<int, int, char>(x, y - 1, array[x, y - 1]);
                }
                if (x == arrLen - 1)
                {
                    yield return new Tuple<int, int, char>(x, y - 1, array[x, y - 1]);
                    yield return new Tuple<int, int, char>(x - 1, y, array[x - 1, y]);
                    yield return new Tuple<int, int, char>(x, y + 1, array[x, y + 1]);
                }
            }
            if (y == arrLen - 1)
            {
                if (x == 0)
                {
                    yield return new Tuple<int, int, char>(1, y, array[1, y]);
                    yield return new Tuple<int, int, char>(0, y - 1, array[0, y - 1]);
                }
                if (x > 0 && x < arrLen - 1)
                {
                    yield return new Tuple<int, int, char>(x + 1, y, array[x + 1, y]);
                    yield return new Tuple<int, int, char>(x, y - 1, array[x, y - 1]);
                    yield return new Tuple<int, int, char>(x - 1, y, array[x - 1, y]);
                }
                if (x == arrLen - 1)
                {
                    yield return new Tuple<int, int, char>(x - 1, y, array[x - 1, y]);
                    yield return new Tuple<int, int, char>(x, y - 1, array[x, y - 1]);
                }
            }
        }
    }
}
