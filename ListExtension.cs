using System;
using System.Collections.Generic;

namespace Ekra14.AltFXtension
{
    public static class ListExtension
    {
        public static T ItemAtOrDefault<T>(this IList<T> list, int index, T defaultValue = default(T))
        {
            return list != null && index >= 0 && index < list.Count ? list[index] : defaultValue;
        }

        public static T FirstItem<T> (this IList<T> list)
        {
            if (list == null) throw new ArgumentNullException("list");
            if (list.Count == 0) throw new ArgumentException("List is empty");
            return list[0];
        }

        public static T LastItem<T>(this IList<T> list)
        {
            if (list == null) throw new ArgumentNullException("list");
            if (list.Count == 0) throw new ArgumentException("List is empty");
            return list[list.Count - 1];
        }

    }
}