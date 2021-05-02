namespace Codewars.Solutions._5kyu
{
    public class GapInPrimes
    {
        public long[] Gap(int g, long m, long n)
        {
            for (long i = m; i <= n - g; i++)
            {
                if (IsPrime(i))
                {
                    for (long j = i + 1; j <= i + g; j++)
                    {
                        if (IsPrime(j))
                        {
                            if (j == i + g)
                            {
                                return new long[2] { i, i + g };
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            return null;
        }

        private bool IsPrime(long num)
        {
            if (num <= 3)
            {
                return true;

            }
            if (num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }

            var i = 5;

            while (i * i <= num)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }
    }
}
