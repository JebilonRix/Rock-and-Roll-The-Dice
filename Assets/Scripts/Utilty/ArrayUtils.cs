using System.Linq;

namespace RedPanda.Utils
{
    public static class ArrayUtils
    {
        public static T GetRandomValue<T>(this T[] array) => array[MathUtils.Randomize(array.Length)];
        public static T GetMaxValue<T>(this T[] array) => array.SortArray(array.Length - 1);
        public static T GetMinValue<T>(this T[] array) => array.SortArray(0);
        private static T SortArray<T>(this T[] array, int index)
        {
            array = array.OrderBy(x => x).ToArray();
            return array[index];
        }
    }
}