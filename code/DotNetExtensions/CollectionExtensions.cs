namespace DotNetExtensions
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class CollectionExtensions
    {

        public static IList<T> Clone<T>(this IList<T> collection) where T : ICloneable
        {
            return collection.Select(item => (T)item.Clone()).ToList();
        }

        public static bool IsNull<T>(this ICollection<T> items)
        {
            return items == null;
        }

        public static async Task<bool> IsNullAsync<T>(this ICollection<T> items)
        {
            return await Task.Run(() => items == null);
        }

        public static bool IsNullOrEmpty<T>(this ICollection<T> items)
        {
            return (items == null ||
                    items.Count == 0);
        }

        public static async Task<bool> IsNullOrEmptyAsync<T>(this ICollection<T> items)
        {
            return await Task.Run(() =>
                                    (items == null ||
                                    items.Count == 0));
        }

    }

}