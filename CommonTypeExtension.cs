using System;
using System.Collections.Generic;
using System.Linq;

namespace Ekra14.AltFXtension
{
    public static class CommonTypeExtension
    {
        public static bool Among<T>(this T item, params T[] list)
        {
            return list.Contains(item);
        }

        public static bool In<T>(this T item, params T[] list)
        {
            return list.Contains(item);
        }

        public static bool In<T>(this T item, IEnumerable<T> list)
        {
            if (list == null) throw new ArgumentNullException("list");

            return list.Contains(item);
        }

        public static bool In<T>(this T item, ICollection<T> list)
        {
            if (list == null) throw new ArgumentNullException("list");

            return list.Contains(item);
        }

        public static bool NotIn<T>(this T item, params T[] list)
        {
            return !list.Contains(item);
        }

        public static bool NotIn<T>(this T item, IEnumerable<T> list)
        {
            if (list == null) throw new ArgumentNullException("list");

            return !list.Contains(item);
        }

        public static bool NotIn<T>(this T item, ICollection<T> list)
        {
            if (list == null) throw new ArgumentNullException("list");

            return !list.Contains(item);
        }
        
        public static TResult Maybe<TItem, TResult>(this TItem item, Func<TItem, TResult> func, TResult defaultValue = default(TResult))
            where TItem : class
        {
            if (func == null) throw new ArgumentNullException("func");

            return item != null ? func(item) : defaultValue;
        }

        public static TResult IfNotNull<TItem, TResult>(this TItem item, Func<TItem, TResult> func, TResult defaultValue = default(TResult))
            where TItem : class
        {
            return item.Maybe(func);
        }

        public static TItem IfNotNull<TItem>(this TItem item, Action<TItem> action)
            where TItem : class
        {
            if (action == null) throw new ArgumentNullException("action");
            if (item != null) action(item);
            return item;
        }

        public static TItem As<TItem>(this object item)
            where TItem : class
        {
            return item as TItem;
        }

        public static object IfIs<TItem>(this object item, Action<TItem> action)
            where TItem : class
        {
            (item as TItem).IfNotNull(action);
            return item;
        }

        public static TItem Doing<TItem>(this TItem item, Action<TItem> action)
        {
            if (action == null) throw new ArgumentNullException("action");
            action(item);
            return item;
        }
    }
}