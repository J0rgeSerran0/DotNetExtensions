namespace DotNetExtensions
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class RandomExtensions 
    {

        public static IEnumerable<int> Shuffle(this IList<int> content, int lowerNumber, int size)
        {
            if (lowerNumber < 0 ||
                size <= 0)
            {
                return null;
            }

            var random = new Random();

            return Enumerable.Range(lowerNumber, size).OrderBy(n => random.Next());
        }

        public static void Shuffle<T>(this IList<T> collection)
        {
            if (collection != null)
            {
                var random = new Random();
                var count = collection.Count;

                for (var i = 0; i < count; i++)
                {
                    var randomValue = random.Next(i, count);

                    var temp = collection[i];
                    collection[i] = collection[randomValue];
                    collection[randomValue] = temp;
                }
            }
        }

    }

}