namespace Codewars.Solutions._6kyu
{
    public class BuildTower
    {
        public string[] TowerBuilder(int nFloors)
        {
            var array = new string[nFloors][];
            var destArray = new string[nFloors];

            for (var i = 0; i < nFloors; i++)
            {
                array[i] = new string[2 * nFloors - 1];
                for (var j = 0; j < nFloors - i - 1; j++)
                {
                    array[i][j] = " ";
                }
                for (var k = nFloors - i - 1; k < 2 * nFloors - 1; k++)
                {
                    array[i][k] = "*";
                }
                for (var m = nFloors + i; m < 2 * nFloors - 1; m++)
                {
                    array[i][m] = " ";
                }

                destArray[i] = string.Join("", array[i]);
            }

            return destArray;
        }
    }
}
