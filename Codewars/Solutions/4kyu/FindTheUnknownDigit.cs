using System;
using System.Linq;

namespace Codewars.Solutions._4kyu
{
    public class FindTheUnknownDigit
    {
        public int SolveExpression(string expression)
        {
            string leftN, rightN;
            char op;
            char[] ops = { '*', '+', '-' };
            var validDigits = Enumerable.Range(0, 10).Except(expression.Where(x => char.IsDigit(x)).Select(x => (int)char.GetNumericValue(x)));
            var result = expression.Split('=')[1];
            var subExp = expression.Substring(0, expression.IndexOf('='));

            if (expression.StartsWith("-"))
            {
                leftN = "-" + subExp.Substring(1, subExp.Substring(1).IndexOfAny(ops));
                rightN = subExp.Substring(subExp.Substring(1).IndexOfAny(ops) + 2);
                op = subExp.Substring(1).First(c => ops.Contains(c));
            }
            else
            {
                leftN = subExp.Substring(0, subExp.IndexOfAny(ops));
                rightN = subExp.Substring(subExp.IndexOfAny(ops) + 1);
                op = subExp.First(c => ops.Contains(c));
            }

            var missingDigits = validDigits.Where(digit =>
            ComputeExpression(GetNumberAsInt(leftN, digit), GetNumberAsInt(rightN, digit), op, GetNumberAsInt(result, digit), HasLeadingZero(result, digit)));

            return missingDigits.Count() > 0 ? missingDigits.First() : -1;
        }

        private static bool ComputeExpression(int leftNumber, int rightNumber, char op, int result, bool leadingZero)
        {
            if (leadingZero) return false;
            if (op == '*') return leftNumber * rightNumber == result;
            else if (op == '+') return leftNumber + rightNumber == result;

            return leftNumber - rightNumber == result;
        }

        private static int GetNumberAsInt(string number, int digit)
        {
            if (number.StartsWith("-"))
            {
                return Int32.Parse(string.Join("", number.Substring(1).Select(c => c == '?' ? digit : char.GetNumericValue(c)))) * -1;
            }
            return Int32.Parse(string.Join("", number.Select(c => c == '?' ? digit : char.GetNumericValue(c))));
        }

        private static bool HasLeadingZero(string number, int digit)
        {
            if (number.StartsWith("-"))
            {
                return number[1] == '?' && digit == 0;
            }
            return number[0] == '?' && digit == 0 && number.Length > 1;
        }
    }
}
