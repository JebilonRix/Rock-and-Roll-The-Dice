using System.Collections.Generic;

namespace RedPanda.Utils
{
    public static class ListUtils
    {
        public static T GetRandomValue<T>(this List<T> list) => list[MathUtils.Randomize(list.Count)];
        public static T GetMaxValue<T>(this List<T> list) => SortListAndGetElement(list, list.Count - 1);
        public static T GetMinValue<T>(this List<T> list) => SortListAndGetElement(list, 0);
        public static void ShuffleList<T>(this IList<T> list)
        {
            System.Random rng = new System.Random();

            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        private static T SortListAndGetElement<T>(List<T> list, int index)
        {
            list.Sort();
            return list[index];
        }
    }
}