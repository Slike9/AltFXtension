using System;
using System.Collections.Generic;
using System.Linq;

namespace Ekra14.AltFXtension
{
    public static class EnumerableExtension
    {
        public static void Each<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable == null) throw new ArgumentNullException("enumerable");
            if (action == null) throw new ArgumentNullException("action");

            foreach (var element in enumerable)
            {
                action(element);
            }
        }

        public static bool CountGreater<T>(this IEnumerable<T> enumerable, int count)
        {
            return enumerable.Skip(count).Any();
        }
    }
}
