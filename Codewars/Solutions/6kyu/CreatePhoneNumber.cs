﻿namespace Codewars.Solutions._6kyu
{
    public class CreatePhoneNumber
    {
        public static string PhoneNumberCreate(int[] n)
        {
            return string.Format($"({n[0]}{n[1]}{n[2]}) {n[3]}{n[4]}{n[5]}-{n[6]}{n[7]}{n[8]}{n[9]}");
        }
    }
}
