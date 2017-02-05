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

        public static void Shuffle<T>(this IList<T> list)
        {
            if (list != null)
            {
                var random = new Random();
                var count = list.Count;

                for (var i = 0; i < count; i++)
                {
                    var randomValue = random.Next(i, count);

                    var temp = list[i];
                    list[i] = list[randomValue];
                    list[randomValue] = temp;
                }
            }
        }

    }

}