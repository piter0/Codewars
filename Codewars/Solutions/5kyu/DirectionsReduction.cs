using System.Linq;

namespace Codewars.Solutions._5kyu
{
    public class DirectionsReduction
    {
        public string[] DirReduc(string[] arr)
        {
            var list = arr.ToList();
            var k = 0;

            while (k <= arr.Length)
            {
                int i = 0;
                while (i < list.Count() - 1)
                {
                    if (list[i] == "NORTH" && list[i + 1] == "SOUTH"
                        || list[i] == "SOUTH" && list[i + 1] == "NORTH"
                        || list[i] == "EAST" && list[i + 1] == "WEST"
                        || list[i] == "WEST" && list[i + 1] == "EAST")
                    {
                        list[i] = list[i + 1] = string.Empty;
                    }

                    i++;
                }
                k++;
                list = list.Where(x => x.Length > 0).ToList();

                if (list.Count() < 2)
                {
                    return list.ToArray();
                }
            }

            return list.ToArray();
        }
    }
}
