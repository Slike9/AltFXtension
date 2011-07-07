using System;
using System.Collections.Generic;
using System.Linq;

namespace Ekra14.AltFXtension
{
    public static class FixnumExtension
    {
        public static void Times(this int num, Action action)
        {
            if (action == null) throw new ArgumentNullException("action");

            for (int i = 0; i < num; i++)
            {
                action();
            }
        }

        public static IEnumerable<int> UpTo(this int num, int to)
        {
            if (num > to)
                return Enumerable.Empty<int>();

            return Enumerable.Range(num, to - num + 1);
        }

        public static IEnumerable<int> DownTo(this int num, int to)
        {
            return to.UpTo(num).Reverse();
        }

        public static bool InRange(this int num, int min, int max)
        {
            return num.InRange(new IntegerRange(min, max));
        }

        public static bool InRange(this int num, IntegerRange range)
        {
            return range.Contains(num);
        }

        public static bool NotInRange(this int num, int min, int max)
        {
            return !num.InRange(min, max);
        }
    }
}
