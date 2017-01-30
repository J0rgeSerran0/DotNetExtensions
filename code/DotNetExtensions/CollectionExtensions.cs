namespace DotNetExtensions
{

    using System.Collections.Generic;
    using System.Threading.Tasks;

    public static class CollectionExtensions
    {

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