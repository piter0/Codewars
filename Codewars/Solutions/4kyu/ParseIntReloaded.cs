using System;
using System.Linq;

namespace Codewars.Solutions._4kyu
{
    public class ParseIntReloaded
    {
        public int ParseInt(string s)
        {
            var num = s.Split(' ').Where(x => x != "and").ToArray();

            if (num.Length == 1)
            {
                return num[0].Contains("-")
                            ? GetDoubleNumber(num[0])
                            : (num[0].Equals("zero")
                                ? 0
                                : GetSingleNumber(num[0]));
            }
            if (num.Length >= 3 && num.Contains("hundred") && num.Contains("thousand") && (s.IndexOf("hundred") < s.IndexOf("thousand")))
            {
                if (num.Length == 3)
                {
                    return GetSingleNumber(num[0]) * 100000;
                }
                if (num.Length == 4)
                {
                    if (num[2].Equals("thousand"))
                    {
                        return GetSingleNumber(num[0]) * 100000 +
                                    (num[3].Contains("-")
                                    ? GetDoubleNumber(num[3])
                                    : GetSingleNumber(num[3]));
                    }
                    return GetSingleNumber(num[0]) * 100000 +
                                (num[2].Contains("-")
                                ? GetDoubleNumber(num[2]) * 1000
                                : GetSingleNumber(num[2]) * 1000);
                }
                if (num.Length == 5)
                {
                    if (num[2].Equals("thousand"))
                    {
                        return GetSingleNumber(num[0]) * 100000 +
                                    (num[3].Contains("-")
                                    ? GetDoubleNumber(num[3]) * 100
                                    : GetSingleNumber(num[3]) * 100);
                    }
                    if (num[3].Equals("thousand"))
                    {
                        return GetSingleNumber(num[0]) * 100000 +
                                    (num[2].Contains("-")
                                    ? GetDoubleNumber(num[2]) * 1000
                                    : GetSingleNumber(num[2]) * 1000) +
                                       (num[4].Contains("-")
                                        ? GetDoubleNumber(num[4])
                                        : GetSingleNumber(num[4]));
                    }
                    return GetSingleNumber(num[0]) * 100000 +
                            (num[2].Contains("-")
                            ? GetDoubleNumber(num[2]) * 1000
                            : GetSingleNumber(num[2]) * 1000);
                }
                if (num.Length == 6)
                {
                    return GetSingleNumber(num[0]) * 100000 +
                                (num[2].Contains("-")
                                ? GetDoubleNumber(num[2]) * 1000
                                : GetSingleNumber(num[2]) * 1000) +
                                   GetSingleNumber(num[4]) * 100;
                }
                return GetSingleNumber(num[0]) * 100000 +
                    (num[2].Contains("-")
                    ? GetDoubleNumber(num[2]) * 1000
                    : GetSingleNumber(num[2]) * 1000) +
                        GetSingleNumber(num[4]) * 100 +
                        (num[6].Contains("-")
                        ? GetDoubleNumber(num[6])
                        : GetSingleNumber(num[6]));
            }
            if (num[1].Equals("hundred"))
            {
                if (num.Length == 2)
                {
                    return GetSingleNumber(num[0]) * 100;
                }
                return GetSingleNumber(num[0]) * 100 +
                            (num[2].Contains("-")
                            ? GetDoubleNumber(num[2])
                            : GetSingleNumber(num[2]));
            }
            if (num[1].Equals("thousand"))
            {
                if (num.Length == 2)
                {
                    return num[0].Contains("-")
                            ? GetDoubleNumber(num[0]) * 1000
                            : GetSingleNumber(num[0]) * 1000;
                }
                else if (num.Length == 3)
                {
                    return num[0].Contains("-")
                                ? GetDoubleNumber(num[0])
                                : GetSingleNumber(num[0]) * 1000 +
                                    (num[2].Contains("-")
                                    ? GetDoubleNumber(num[2])
                                    : GetSingleNumber(num[2]));
                }
                else if (num.Length == 4)
                {
                    return num[0].Contains("-")
                                ? GetDoubleNumber(num[0]) * 1000
                                : GetSingleNumber(num[0]) * 1000 +
                                    (num[2].Contains("-")
                                        ? GetDoubleNumber(num[2]) * 100
                                        : GetSingleNumber(num[2]) * 100);
                }
                return (num[0].Contains("-")
                            ? GetDoubleNumber(num[0]) * 1000
                            : GetSingleNumber(num[0]) * 1000) +
                                GetSingleNumber(num[2]) * 100 +
                                    (num[4].Contains("-")
                                    ? GetDoubleNumber(num[4])
                                    : GetSingleNumber(num[4]));
            }

            return 1000000;
        }

        private static int GetDoubleNumber(string dn)
        {
            return GetSingleNumber(dn.Substring(0, dn.IndexOf('-'))) + GetSingleNumber(dn.Substring(dn.IndexOf('-') + 1));
        }

        private static int GetSingleNumber(string sn)
        {
            switch (sn)
            {
                case "one": return 1;
                case "two": return 2;
                case "three": return 3;
                case "four": return 4;
                case "five": return 5;
                case "six": return 6;
                case "seven": return 7;
                case "eight": return 8;
                case "nine": return 9;
                case "ten": return 10;
                case "eleven": return 11;
                case "twelve": return 12;
                case "thirteen": return 13;
                case "fourteen": return 14;
                case "fifteen": return 15;
                case "sixteen": return 16;
                case "seventeen": return 17;
                case "eighteen": return 18;
                case "nineteen": return 19;
                case "twenty": return 20;
                case "thirty": return 30;
                case "forty": return 40;
                case "fifty": return 50;
                case "sixty": return 60;
                case "seventy": return 70;
                case "eighty": return 80;
                default: return 90;
            }
        }
    }
}
