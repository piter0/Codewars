using System;
using System.Linq;

namespace Codewars.Solutions._5kyu
{
    public class CountIPAddresses
    {
        public long IpsBetween(string start, string end)
        {
            var s = start.Split('.').Reverse().ToArray();

            return end.Split('.')
                .Reverse()
                .Select((e, i) => (Convert.ToInt32(e) - Convert.ToInt32(s[i])) * (long)Math.Pow(256, i))
                .Sum();
        }
    }
}
