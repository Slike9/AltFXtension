using System.Collections.Generic;

namespace Ekra14.AltFXtension
{
    public static class CollectionExtension
    {
        public static void AddItems<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            items.IfNotNull(x => x.Each(collection.Add));
        }

        public static void AddItems<T>(this ICollection<T> collection, params T[] items)
        {
            collection.AddItems((IEnumerable<T>)items);
        }

        public static void ReplaceItemsWith<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            collection.Clear();
            collection.AddItems(items);
        }

        public static void ReplaceItemsWith<T>(this ICollection<T> collection, params T[] items)
        {
            collection.ReplaceItemsWith((IEnumerable<T>) items);
        }
    }
}