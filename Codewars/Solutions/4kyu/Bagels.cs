using System.Reflection;

namespace Codewars.Solutions._4kyu
{
    class Bagels
    {
        public static Bagel Bagel
        {
            get
            {
                var b = new Bagel();
                PropertyInfo property = typeof(Bagel).GetProperty("Value");
                property.DeclaringType.GetProperty("Value");
                property.SetValue(b, 4, BindingFlags.NonPublic | BindingFlags.Instance, null, null, null);
                return b;
            }
        }
    }

    sealed class Bagel
    {
        public int Value { get; private set; } = 3;
    }
}
