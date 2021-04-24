namespace Codewars.Solutions._6kyu
{
    public class PersistentBugger
    {
        public int Persistence(long n)
        {
            long currentNumber = 1;
            long multiplicationResult = 1;
            var numberOfMultiplications = 0;

            while (n % 10 != n)
            {
                while (n > 0)
                {
                    currentNumber = n % 10;
                    multiplicationResult *= currentNumber;
                    n /= 10;
                }
                numberOfMultiplications++;
                n = multiplicationResult;
                multiplicationResult = 1;
            }

            return numberOfMultiplications;
        }
    }
}
