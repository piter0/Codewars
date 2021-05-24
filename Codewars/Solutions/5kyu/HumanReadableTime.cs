namespace Codewars.Solutions._5kyu
{
    public class HumanReadableTime
    {
        public string GetReadableTime(int seconds)
        {
            var hours = seconds / 3600;
            var minutes = seconds % 3600 > 59 ? seconds % 3600 / 60 : 0;
            var seconds2 = seconds - 3600 * hours - 60 * minutes;

            return $"{hours.ToString().PadLeft(2, '0')}" +
                   $":{minutes.ToString().PadLeft(2, '0')}" +
                   $":{seconds2.ToString().PadLeft(2, '0')}";
        }
    }
}
