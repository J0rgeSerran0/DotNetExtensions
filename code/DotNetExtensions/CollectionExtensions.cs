namespace DotNetExtensions
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class CollectionExtensions
    {

        public static void AddToFirstPosition<T>(this List<T> collection, T item)
        {
            collection.Insert(0, item);
        }

        public static IList<T> Clone<T>(this IList<T> collection) where T : ICloneable
        {
            return collection.Select(item => (T)item.Clone()).ToList();
        }

        public static IEnumerable<T> EmptyIfNull<T>(this ICollection<T> collection)
        {
            return collection ?? Enumerable.Empty<T>();
        }

        public static string JoinWithDelimiter<T>(this IEnumerable<T> collection, Func<T, string> func, string delimiter = ";")
        {
            return String.Join(delimiter, collection.Select(func).ToArray());
        }

        public static bool IsNull<T>(this ICollection<T> collection)
        {
            return collection == null;
        }

        public static async Task<bool> IsNullAsync<T>(this ICollection<T> collection)
        {
            return await Task.Run(() => collection == null);
        }

        public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
        {
            return (collection == null || collection.Count == 0);
        }

        public static async Task<bool> IsNullOrEmptyAsync<T>(this ICollection<T> collection)
        {
            return await Task.Run(() => (collection == null || collection.Count == 0));
        }

    }

}