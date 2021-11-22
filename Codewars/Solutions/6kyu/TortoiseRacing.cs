namespace Codewars.Solutions._6kyu
{
    public class TortoiseRacing
    {
        public int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2)
            {
                return null;
            }

            var vdiff = v2 - v1;
            var mod = g % vdiff;

            var h = g / vdiff;
            var m = mod * 60 / vdiff;
            var s = mod * 60 % vdiff * 60 / vdiff;

            return new int[] { h, m, s };
        }
    }
}
